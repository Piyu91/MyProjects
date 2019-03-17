using EntityCurd.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learncurd.Mapper;
using Learncurd.Models;
using System.Net;

namespace Learncurd.Controllers
{
    public class StudentEnController : Controller
    {
        IBusinessAccess businessAccess = new BusinessAccess();
        // GET: StudentEn
        public ActionResult Index()
        {
            return View(StudentEnMapper.MapList(businessAccess.GetStudents()));
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Marks,state")] StudentModel student)
        {
            if (ModelState.IsValid)
            {
                businessAccess.pushStudent(StudentEnMapper.reverseMap(student));
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModel student = StudentEnMapper.Map(businessAccess.GetStudent(id));
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }


        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModel student = StudentEnMapper.Map(businessAccess.GetStudent(id));
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

       
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Marks,state")] StudentModel student)
        {
            if (ModelState.IsValid)
            {
                businessAccess.putStudent(student.ID, StudentEnMapper.reverseMap(student));
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModel student = StudentEnMapper.Map(businessAccess.GetStudent(id));
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            businessAccess.delStudent(id);
           
            return RedirectToAction("Index");
        }


    }
}