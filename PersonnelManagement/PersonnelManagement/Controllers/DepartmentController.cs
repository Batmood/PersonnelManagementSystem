using PersonnelManagement.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonnelManagement.Controllers
{
    public class DepartmentController : Controller
    {
        PersonnelContext Db = new PersonnelContext();
        // GET: Department
        public ActionResult Index()
        {
            var model = Db.Departments.ToList();

            return View(model);
        }
        [HttpGet]
        public ActionResult New()
        {
            return View("DepartmentForm",new Department());
        }
        [HttpPost]
        public ActionResult Save(Department department)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmentForm");
            }
            if (department.Id==0)
            {
                Db.Departments.Add(department);
            }
            else
            {
                
                Db.Entry(department).State = EntityState.Modified;
            }
           
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var update = Db.Departments.Find(id);
            if (update==null)
            {
                return HttpNotFound();
            }
            return View("DepartmentForm",update);
        }
        public ActionResult Delete(int id)
        {
            var modelDelete = Db.Departments.Find(id);
            if (modelDelete==null)
            {
                return HttpNotFound();
            }
            Db.Departments.Remove(modelDelete);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}