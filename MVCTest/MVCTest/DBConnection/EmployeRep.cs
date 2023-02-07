
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.DBConnection
{
    public class EmployeRep
    {
        public List<EmployeModel> ShowRecords()
        {
            
            {
                using (var db = new TestDBEntities())
                {
                    var result = db.Employes.Select(x => new EmployeModel()
                    {
                        EmpID = x.EmpID,
                        EmpName = x.EmpName,
                        MailID = x.MailID,
                        Mobile = x.Mobile,
                        Password = x.Password,
                    }).ToList();
                    return result;
                }
            }
        }

        public void SaveData(EmployeModel model)
        {
            TestDBEntities db = new TestDBEntities();
            Employe emp = new Employe();  //Database Class
            emp.EmpID = model.EmpID;
            emp.EmpName = model.EmpName;
            emp.MailID = model.MailID;
            emp.Mobile = model.Mobile;
            emp.Password = model.Password;
            //----------------Saving data in to DB=================
            db.Employes.Add(emp);
            db.SaveChanges();
        }
        /*
        public void EditRecord(int id, EmployeModel model)
        { TestDBEntities db = new TestDBEntities();
            var result = db.EmployeDatas.FirstOrDefault(x => x.EmpID == id); 
            if (model != null) 
            { 
                result.EmpName = model.EmpName;
                result.MailId = model.MailID;
                result.Mobile = model.Mobile; 
                result.Password = model.Password;
                db.SaveChanges();
            }
        }
        */
    }
}