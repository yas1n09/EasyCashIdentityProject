
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be empty.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname can not be empty.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username can not be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid e-mail address.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password can not be empty.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password can not be empty.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maximum 30 chars");
            RuleFor(x => x.Name).MinimumLength(6).WithMessage("Minimum 30 chars");
            RuleFor(x => x.ConfirmPassword).Equal(y=> y.Password).WithMessage("Passwords must be the same");


        }
    }
}
