using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.UpdateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Web.Models;
using ABPosSolutions.TechnicalTest.Web.Models.Account;
using AutoMapper;

namespace ABPosSolutions.TechnicalTest.Web.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<RegisterVm, ApplicationUser>();
            CreateMap<CreateBuildingDto, CreateBuildingCommand>();
            CreateMap<CreateBuildingDto, UpdateBuildingCommand>();
            CreateMap<Inspection, CreateInspectionDto>();
            CreateMap<CreateInspectionDto, CreateInspectionCommand>();
        }
    }
}
