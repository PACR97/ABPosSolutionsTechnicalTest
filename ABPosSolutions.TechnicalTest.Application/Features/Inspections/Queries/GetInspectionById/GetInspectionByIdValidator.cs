using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionById
{
    public class GetInspectionByIdValidator : AbstractValidator<GetInspectionByIdQuery>
    {
        public GetInspectionByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("{Id} cannot be null")
                .NotEmpty().WithMessage("{Id} cannot be empty");
        }
    }
}
