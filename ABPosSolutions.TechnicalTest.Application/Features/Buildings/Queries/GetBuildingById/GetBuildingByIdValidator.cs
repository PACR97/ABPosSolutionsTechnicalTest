using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetBuildingById
{
    public class GetBuildingByIdValidator : AbstractValidator<GetBuildingByIdQuery>
    {
        public GetBuildingByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("{Id} cannot be null")
                .NotEmpty().WithMessage("{Id} cannot be empty");
        }
    }
}
