﻿using System;
using Entities;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Password).MinimumLength(8);
            RuleFor(p => p.LastName).NotEmpty();

        }
    }
}
