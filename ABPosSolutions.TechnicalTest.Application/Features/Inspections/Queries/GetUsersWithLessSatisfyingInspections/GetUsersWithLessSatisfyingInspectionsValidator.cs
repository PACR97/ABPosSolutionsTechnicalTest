using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithLessSatisfyingInspections
{
    public class GetUsersWithLessSatisfyingInspectionsValidator : AbstractValidator<GetUsersWithLessSatisfyingInspectionsQuery>
    {
        public GetUsersWithLessSatisfyingInspectionsValidator()
        {
            RuleFor(x => x.StatusId)
                .NotNull().WithMessage("{StatusId} cannot be null")
                .NotEmpty().WithMessage("{StatusId} cannot be empty");
        }
    }
}
