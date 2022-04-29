using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionsByUser
{
    public class GetInspectionsByUserValidator : AbstractValidator<GetInspectionsByUserQuery>
    {
        public GetInspectionsByUserValidator()
        {
            RuleFor(x => x.UserId)
                .NotNull().WithMessage("{UserId} cannot be null")
                .NotEmpty().WithMessage("{UserId} cannot be empty");
        }
    }
}
