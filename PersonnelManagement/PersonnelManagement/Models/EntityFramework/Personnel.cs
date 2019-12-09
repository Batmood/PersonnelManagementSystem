using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using FluentValidation;

namespace PersonnelManagement.Models.EntityFramework
{
   //[FluentValidation.Attributes.Validator(typeof(PersonnelValidator))]
    public class Personnel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ushort Salary { get; set; }
        public bool Gender { get; set; }
        public bool MarritalStatus { get; set; }
        public string PersonnelImagePath { get; set; }
        public string PersonnelImageName{ get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}