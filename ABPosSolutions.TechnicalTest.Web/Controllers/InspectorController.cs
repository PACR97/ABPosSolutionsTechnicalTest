using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionById;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionsByUser;
using ABPosSolutions.TechnicalTest.Application.Features.InspectionTypes.GetAllInspectionTypes;
using ABPosSolutions.TechnicalTest.Application.Features.Statuses.Queries.GetAllStatuses;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Web.Models;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ABPosSolutions.TechnicalTest.Web.Controllers
{
    [Authorize]
    public class InspectorController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        
        public InspectorController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            List<Inspection> inspections = await GetInspectionsByUser(userId);
            inspections = inspections.Select(x =>
            {
                x.UserId = User.FindFirst(ClaimTypes.Name)!.Value;
                return x;
            }).ToList();
            return View(inspections);
        }

        [HttpGet]
        public async Task<IActionResult> CreateInspection(string id)
        {
            try
            {
                CreateInspectionDto dto;
                if (string.IsNullOrEmpty(id))
                {
                    dto = new CreateInspectionDto();
                }
                else
                {
                    Inspection inspection = await GetInspectionAsync(id);
                    dto = mapper.Map<CreateInspectionDto>(inspection);
                }

                List<Status> statuses = await GetStatusesAsync();
                List<InspectionType> inspectionTypes = await GetInspectionTypesAsync();
                CreateInspectionVm vm = new CreateInspectionVm()
                {
                    Input = dto,
                    Statuses = statuses,
                    InspectionTypes = inspectionTypes
                };
                return View(vm);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateInspection([Bind(Prefix ="Input")]CreateInspectionDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CreateInspectionCommand command = mapper.Map<CreateInspectionCommand>(dto);
                    command.UserId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
                    Inspection inspection = await mediator.Send(command);
                    return RedirectToAction("Index", "Inspector");
                }
                else
                {
                    List<Status> statuses = await GetStatusesAsync();
                    List<InspectionType> inspectionTypes = await GetInspectionTypesAsync();
                    CreateInspectionVm vm = new CreateInspectionVm()
                    {
                        Input = dto,
                        Statuses = statuses,
                        InspectionTypes = inspectionTypes
                    };
                    return View(vm);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<Inspection>> GetInspectionsByUser(string userId)
        {
            try
            {
                GetInspectionsByUserQuery query = new GetInspectionsByUserQuery()
                {
                    UserId = userId
                };
                List<Inspection> inspections = await mediator.Send(query);
                return inspections;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private async Task<Inspection> GetInspectionAsync(string id)
        {
            try
            {
                GetInspectionByIdQuery query = new GetInspectionByIdQuery() { Id = id };
                Inspection inspection = await mediator.Send(query);
                return inspection;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<Status>> GetStatusesAsync()
        {
            try
            {
                GetAllStatusesQuery query = new GetAllStatusesQuery();
                List<Status> statuses = await mediator.Send(query);
                return statuses;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<InspectionType>> GetInspectionTypesAsync()
        {
            try
            {
                GetAllInspectionTypesQuery query = new GetAllInspectionTypesQuery();
                return await mediator.Send(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
