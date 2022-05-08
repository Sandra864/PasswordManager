using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class ApplicationUserValidator : AbstractValidator<ApplicationUser>
    {
        public ApplicationUserValidator()
        {
            RuleFor(Q => Q.Email).NotEmpty().EmailAddress().MaximumLength(255);
            RuleFor(p => p.firstName).NotEmpty().WithMessage("{PropertyName} is Empty");
            RuleFor(p => p.lastName).NotEmpty().WithMessage("{PropertyName} is Empty");
        }
    }
}
