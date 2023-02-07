using System;
using System.Collections.Generic;
using System.Linq;
using MVCdemo02.Models;


namespace MVCdemo02.DB_Connection
{
    public class EmployeRep
    {
        public List<EmployeModel> ShowRecords()
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


        /*internal void Savedata(Controllers.EmployeModel emp)
          {
              throw new NotImplementedException();
          }  */
    }
}
        
    
