using MVCdemo02.DB_Connection;
using MVCdemo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVCdemo02.Controllers
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
        [HttpGet]   //We enter the values
        public ActionResult Create() 
        {
            EmployeModel emp = new EmployeModel();
            return View(emp);
        }
        [HttpPost]  //It will save data into DB
        public ActionResult Create(EmployeModel emp)
        {
            Empobj.SaveData(emp);
            return RedirectToAction("Index");
        }

    }
}