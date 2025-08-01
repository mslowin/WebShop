using FluentValidation;
using WebShop.Application.ViewModels.Customer;

namespace WebShop.Application.Validators.Customer
{
    public class NewCustomerValidator : AbstractValidator<NewCustomerVm>
    {
        public NewCustomerValidator() 
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name cannot exceed 50 characters.");
            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name cannot exceed 50 characters.");
            RuleFor(c => c.CompanyName)
                .MaximumLength(100).WithMessage("Company name cannot exceed 100 characters.");
            RuleFor(c => c.Nip)
                .Matches(@"^\d{10}$").WithMessage("NIP must be a 10-digit number.")
                .When(c => !string.IsNullOrEmpty(c.Nip));
            RuleFor(c => c.Regon)
                .Matches(@"^\d{9}$").WithMessage("REGON must be a 9-digit number.")
                .When(c => !string.IsNullOrEmpty(c.Regon));
        }
    }
}
