using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework
{
    [FluentValidation.Attributes.Validator(typeof(DepartmentValidator))]
    public class Department
    {
        public Department()
        {
            Personnels = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Personnel> Personnels { get; set; }
    }
}