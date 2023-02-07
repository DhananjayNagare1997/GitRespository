using MVCTest.DBConnection;
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        EmployeRep Empobj = null;
        public EmployeController() //Constructor
        {
            Empobj = new EmployeRep();
        }
        public ActionResult Index()
        {
            var result = Empobj.ShowRecords();
            return View(result);
        }
        [HttpGet]        //We enter the values
                         //Model ko object banake retun karenge, aur vo Model ke sare field leke View banayega.
        public ActionResult Create()
        {
            EmployeModel emp = new EmployeModel();
            return View(emp);
        }
        [HttpPost]  //It will save data into DB
                    //Aur usi View ko ham argument mai lenge, aur jo methode banayeng usme object ko pass karenge, so hamara data save ho jayega
        
        public ActionResult Create(EmployeModel emp)
        {
            Empobj.SaveData(emp);
            return RedirectToAction("Index");
        }
        /*
        [HttpGet]
        public ActionResult Edit(int id)
        {

            using (var db = new TestDBEntities())
            {
                var data = db.EmployeDatas.Where(x => x.EmpID == id).SingleOrDefault();
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, EmployeModel mode)
        {
            Empobj.EditRecord(id, mode);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            using (var db = new TestDBEntities())
            {
                var data = db.Employes.Where(x => x.EmpID == id).SingleOrDefault;
                return View(data);
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var db = new TestDBEntities())
            {
                var data = db.EmployeDatas.FirstOrDefault(x => x.EmpID == id);
                if (data != null)
                {
                    db.EmployeDatas.Remove(data);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else return View();
            }
        }
        */
    }
}
