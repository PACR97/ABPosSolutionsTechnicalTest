using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.UpdateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetAllBuildings;
using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetBuildingById;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Web.Models;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ABPosSolutions.TechnicalTest.Web.Controllers
{
    public class BuildingController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public BuildingController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            GetAllBuildingsQuery query = new GetAllBuildingsQuery();
            List<Building> buildings = await mediator.Send(query);
            return View(buildings);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(string id)
        {
            CreateBuildingDto dto;
            if (string.IsNullOrEmpty(id))
            {
                dto = new CreateBuildingDto();
            }
            else
            {
                Building building = await GetBuildingAsync(id);
                dto = new CreateBuildingDto
                {
                    Address = building.Address,
                    BuildingName = building.BuildingName,
                };
            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Detail(CreateBuildingDto dto)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(dto.Id))
                {
                    CreateBuildingCommand command = mapper.Map<CreateBuildingCommand>(dto);
                    Building building = await mediator.Send(command);
                    return RedirectToAction("Detail", new { id = building.Id });
                }
                else
                {
                    UpdateBuildingCommand command = mapper.Map<UpdateBuildingCommand>(dto);
                    Building building = await mediator.Send(command);
                    return RedirectToAction("Detail", new { id = building.Id });
                }
            }
            else
            {
                return View(dto);
            }
            
        }

        private async Task<Building> GetBuildingAsync(string id)
        {
            try
            {
                GetBuildingByIdQuery query = new GetBuildingByIdQuery() { Id = id};
                Building building = await mediator.Send(query);
                return building;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
