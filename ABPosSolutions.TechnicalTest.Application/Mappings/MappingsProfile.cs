using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.UpdateBuilding;
using ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateBuildingCommand, Building>()
                .ForMember(x => x.Address, opt => opt.MapFrom(x => x.Address))
                .ForMember(x => x.BuildingName, opt => opt.MapFrom(x => x.BuildingName));

            CreateMap<UpdateBuildingCommand, Building>()
                .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<CreateInspectionCommand, Inspection>();
        }
    }
}
