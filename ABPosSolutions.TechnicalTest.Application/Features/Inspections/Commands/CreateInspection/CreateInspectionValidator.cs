using FluentValidation;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection
{
    public class CreateInspectionValidator : AbstractValidator<CreateInspectionCommand>
    {
        public CreateInspectionValidator()
        {

            RuleFor(x => x.Description)
                .NotNull().WithMessage("{Description} cannot be null")
                .NotEmpty().WithMessage("{Description} cannot be empty");

            RuleFor(x => x.InspectionTypeId)
                .NotNull().WithMessage("{InspectionTypeId} cannot be null")
                .NotEmpty().WithMessage("{InspectionTypeId} cannot be empty")
                .MaximumLength(50).WithMessage("{InspectionTypeId} cannot be more than 50 characters");

            RuleFor(x => x.StatusId)
                .NotNull().WithMessage("{StatusId} cannot be null")
                .NotEmpty().WithMessage("{StatusId} cannot be empty")
                .MaximumLength(50).WithMessage("{StatusId} cannot be more than 50 characters");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("{UserId} cannot be null")
                .NotEmpty().WithMessage("{UserId} cannot be empty")
                .MaximumLength(50).WithMessage("{UserId} cannot be more than 50 characters");
        }
    }
}
