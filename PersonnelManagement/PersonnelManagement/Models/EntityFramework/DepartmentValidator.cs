using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50);
        }
    }
}