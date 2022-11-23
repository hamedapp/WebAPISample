﻿using Domain.Dtos;
using FluentValidation;
using System.Text.RegularExpressions;

namespace WebAPISample.Modules
{
    public class ValidationModule : AbstractValidator<CustomerDto>
    {
        public ValidationModule()
        {
            RuleFor(x => x.PostalCode).NotEmpty();   
            RuleFor(x => x.FirstName).Length(0, 20)
                .WithMessage("Name must be maximum 20 charachters.");
            RuleFor(x => x.LastName).Length(0, 20)
                .WithMessage("Name must be maximum 20 charachters.");
            //RuleFor(x => x.PostalCode).(10).MaximumLength(12)
            //    .WithMessage("Postal code must be 10 to 12 digit number");
            RuleFor(x => x.Email).EmailAddress()
                .WithMessage("Not Valid Email Address"); ;
            RuleFor(x => x.Mobile)
                .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid"); ;
            RuleFor(x => x.City).NotEmpty().WithMessage("City Number is required.");
        }
    }
}
