using EmpApplication.Models;
using EmpApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpApplication.Controllers
{
    public class EmpController : Controller
    {
        static List<Employee> empDetails;
         static EmpController()
        {
            empDetails = new List<Employee>();
            empDetails.Add(new Employee { EmpId = 1, EmpName = "Sukanta", EmpDept = "Dev", EmpEmail = "suku@test.com" });
            empDetails.Add(new Employee { EmpId = 2, EmpName = "Priyanka", EmpDept = "Dev", EmpEmail = "piyu@test.com" });
        }
        // GET: Emp
        public ActionResult Index()
        {
            EmpViewModel empViewModel = new EmpViewModel();
            empViewModel.empList = empDetails;
            empViewModel.empSingle = new Employee();
            return View(empViewModel);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult InsertPost([Bind(Include = "EmpId, EmpName, EmpEmail, EmpDept")] Employee empdtls)
        {
            if (ModelState.IsValid)
            {
                var maxid = empDetails.Max(x => x.EmpId);
                empdtls.EmpId = maxid + 1;

                empDetails.Add(empdtls);
            }
           
            return RedirectToAction("Index");

        }

        // GET: PersonalDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
           var delemp = empDetails.Find(x=> x.EmpId == id);
            if (delemp == null)
            {
                return RedirectToAction("Index");
            }
            return View(delemp);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmp(int id)
        {
            var delemp = empDetails.Find(x => x.EmpId == id);
            empDetails.Remove(delemp);
            return RedirectToAction("Index");

        }
        // GET: PersonalDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var editEmp = empDetails.Find(x => x.EmpId == id);
            if (editEmp == null)
            {
                return RedirectToAction("Index");
            }
            return View(editEmp);

        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
       
        public ActionResult EditEmp([Bind(Include = "EmpId, EmpName, EmpEmail, EmpDept")] Employee empdtls)
        {
            if (ModelState.IsValid)
            {
                var empdts = empDetails.Find(x => x.EmpId == empdtls.EmpId);
                if (empdts != null)
                {
                    empdts.EmpName = empdtls.EmpName;
                    empdts.EmpEmail = empdtls.EmpEmail;
                    empdts.EmpDept = empdtls.EmpDept;
                }


            }
            return RedirectToAction("Index") ;
        }

    }
}