using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithMoreSatisfyingInspections
{
    public class GetUsersWithMoreSatisfyingInspectionsValidator : AbstractValidator<GetUsersWithMoreSatisfyingInspectionsQuery>
    {
        public GetUsersWithMoreSatisfyingInspectionsValidator()
        {
            RuleFor(x => x.StatusId)
                .NotNull().WithMessage("{StatusId} cannot be null")
                .NotEmpty().WithMessage("{StatusId} cannot be empty");
        }
    }
}
