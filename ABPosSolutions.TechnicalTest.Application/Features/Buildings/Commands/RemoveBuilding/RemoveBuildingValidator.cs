using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.RemoveBuilding
{
    public class RemoveBuildingValidator : AbstractValidator<RemoveBuildingCommand>
    {
        public RemoveBuildingValidator()
        {
            RuleFor(x => x.BuildingId)
                .NotNull().WithMessage("{BuildingId} cannot be null")
                .NotEmpty().WithMessage("{BuildingId} cannot be empty")
                .MaximumLength(50).WithMessage("{BuildingId} cannot be more than 50 characters");
        }
    }
}
