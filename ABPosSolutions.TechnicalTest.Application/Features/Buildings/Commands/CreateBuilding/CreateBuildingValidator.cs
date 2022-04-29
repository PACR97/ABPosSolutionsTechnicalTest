using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding
{
    public class CreateBuildingValidator : AbstractValidator<CreateBuildingCommand>
    {
        public CreateBuildingValidator()
        {
            RuleFor(x => x.BuildingName)
                .NotNull().WithMessage("{BuildingName} cannot be null")
                .NotEmpty().WithMessage("{BuildingName} cannot be empty")
                .MaximumLength(100).WithMessage("{BuildingName} cannot be more than 100 characters");

            RuleFor(x => x.Address)
                .NotNull().WithMessage("{Address} cannot be null")
                .NotEmpty().WithMessage("{Address} cannot be empty")
                .MaximumLength(200).WithMessage("{BuildingName} cannot be more than 200 characters");

        }
    }
}
