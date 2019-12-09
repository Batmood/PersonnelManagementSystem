using PersonnelManagement.Models.EntityFramework;
using PersonnelManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonnelManagement.Controllers
{
    public class PersonnelController : Controller
    {
        PersonnelContext Db = new PersonnelContext();
        // GET: Personnel
        public ActionResult Index()
        {
            var model = Db.Personnels.Include(x=>x.Department).ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult New()
        {
            var model = new PersonnelFormViewModel()
            {
                Departments = Db.Departments.ToList()
            };

            return View("PersonnelForm",model);
        }
        [HttpGet]
        public ActionResult Upload()
        {
            return View("PersonnelForm");
        }
        [HttpPost]
        public ActionResult Upload(Personnel personnel, HttpPostedFileBase PersonnelImagePath)
        { 
            Personnel personnelImage = new Personnel();
            personnelImage.PersonnelImageName = personnel.PersonnelImageName;
            personnelImage.PersonnelImagePath = PersonnelImagePath.FileName.ToString();

            var path = Server.MapPath("~/Content/Images");
            PersonnelImagePath.SaveAs(Path.Combine(path, PersonnelImagePath.FileName.ToString()));
            Db.Personnels.Add(personnelImage);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Save(Personnel personnel)
        {
            
            if (personnel.Id==0)
            {
                
                Db.Personnels.Add(personnel);
            }
            else
            {
                Db.Entry(personnel).State = EntityState.Modified;
            }
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {

            var model = new PersonnelFormViewModel()
            {
                Personnel = Db.Personnels.Find(id),
                Departments = Db.Departments.ToList()
            };
            return View("PersonnelForm",model);
        }
        public ActionResult Delete(int id)
        {
            var model = Db.Personnels.Find(id);
            if (model==null)
            {
                return HttpNotFound();
            }
            Db.Personnels.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}