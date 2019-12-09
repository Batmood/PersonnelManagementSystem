using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework
{
    public class PersonnelValidator:AbstractValidator<Personnel>
    {
        public PersonnelValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50);
            RuleFor(x => x.LastName).MaximumLength(50);
            RuleFor(x => x.Gender).NotNull();
            RuleFor(x => x.MarritalStatus).NotNull();

        }
    }
}