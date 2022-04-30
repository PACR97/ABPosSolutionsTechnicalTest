using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetTotalInspections;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithLessSatisfyingInspections;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithMoreSatisfyingInspections;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using ABPosSolutions.TechnicalTest.Web.Extensions;
using ABPosSolutions.TechnicalTest.Web.Models;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ABPosSolutions.TechnicalTest.Web.Controllers
{
    [Authorize(Roles ="Supervisor")]
    public class SupervisorController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;

        public SupervisorController(IMediator mediator, IMapper mapper, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.configuration = configuration;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<UsersWithInspectionsCountOutputDto> usersWithMoreInspections = await GetUsersWithMoreInspectionsSatisfactoryCounts(configuration["SatisfactoryStatusId"]);

            List<UsersWithInspectionsCountOutputDto> usersWithLessInspections = await GetUsersWithLessInspectionsSatisfactoryCounts(configuration["SatisfactoryStatusId"]);

            TotalInspectionsResponse totalSatisfactory = await GetTotalInspectionsResponseAsync(configuration["SatisfactoryStatusId"]);

            TotalInspectionsResponse totalUnsatisfactory = await GetTotalInspectionsResponseAsync(configuration["UnsatisfactoryStatusId"]);

            var users = userManager.Users;

            usersWithMoreInspections = usersWithMoreInspections.Select(x =>
            {
                x.UserId = users.FirstOrDefault(y => y.Id == x.UserId)!.UserName ?? x.UserId;
                return x;
            }).ToList();

            usersWithLessInspections = usersWithLessInspections.Select(x =>
            {
                x.UserId = users.FirstOrDefault(y => y.Id == x.UserId)!.UserName ?? x.UserId;
                return x;
            }).ToList();

            SupervisorIndexVm vm = new SupervisorIndexVm()
            {
                TotalSatisfactory = totalSatisfactory,
                TotalUnsatisfactory = totalUnsatisfactory,
                UsersWithLessSatisfyingInspections = usersWithLessInspections,
                UsersWithMoreSatisfyingInspections = usersWithMoreInspections
            };
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> RefreshUsersWithInspectionsCount(bool moreSatisfying)
        {
            try
            {
                List<UsersWithInspectionsCountOutputDto> usersWithInspections;
                if (moreSatisfying)
                {
                    usersWithInspections = await GetUsersWithMoreInspectionsSatisfactoryCounts(configuration["SatisfactoryStatusId"]);
                }
                else
                {
                    usersWithInspections = await GetUsersWithLessInspectionsSatisfactoryCounts(configuration["SatisfactoryStatusId"]);
                }
                string html = await this.RenderViewAsync("_UsersInspectionsCount", usersWithInspections, true);
                return Json(new { ok = true, html, moreSatisfying });
            }
            catch (Exception e)
            {
                return Json(new {ok= false, message= e.Message});
                throw;
            }
        }

        private async Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithMoreInspectionsSatisfactoryCounts(string statusId)
        {
            try
            {
                GetUsersWithMoreSatisfyingInspectionsQuery query = new()
                {
                    StatusId = statusId
                };
                return await mediator.Send(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithLessInspectionsSatisfactoryCounts(string statusId)
        {
            try
            {
                GetUsersWithLessSatisfyingInspectionsQuery query = new()
                {
                    StatusId = statusId,
                };
                return await mediator.Send(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<TotalInspectionsResponse> GetTotalInspectionsResponseAsync(string statusId)
        {
            try
            {
                GetTotalInspectionsQuery query = new()
                {
                    SatusId = statusId
                };
                return await mediator.Send(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
