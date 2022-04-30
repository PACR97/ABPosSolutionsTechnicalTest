using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetTotalInspections
{
    public class GetTotalInspectionsValidator : AbstractValidator<GetTotalInspectionsQuery>
    {
        public GetTotalInspectionsValidator()
        {
            RuleFor(x => x.SatusId)
                .NotNull().WithMessage("{SatusId} cannot be null")
                .NotEmpty().WithMessage("{SatusId} cannot be empty");
        }
    }
}
