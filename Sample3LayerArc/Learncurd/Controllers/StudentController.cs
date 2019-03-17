using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using curdData.BusinessLayer.Implementation;
using curdData.BusinessLayer.Declaration;
using Learncurd.Mapper;
using Learncurd.Models;

namespace Learncurd.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        IBusinessAccess businessAccess = new BusinessAccess();
        public ActionResult Index()
        {
            var stuBLResult = businessAccess.GetStudents();
            var stuModel = StudentMapper.MapList(stuBLResult);
            return View(stuModel);
        }
        public ActionResult Details(int id)
        {
            var stuBLResult = businessAccess.GetStudent(id);
            var stuModel = StudentMapper.Map(stuBLResult);
            return View(stuModel);
        }

        public ActionResult Edit(int id)
        {
            var stuBLResult = businessAccess.GetStudent(id);
            var stuModel = StudentMapper.Map(stuBLResult);
            return View(stuModel);
        }
        [HttpPost]
        public ActionResult Edit(int id, StudentModel student)
        {
            var studentBl = StudentMapper.reverseMap(student);
            var stuBLResult = businessAccess.putStudent(id, studentBl);
            ViewBag.Res = stuBLResult;
            return View();
        }
        public ActionResult Delete(int id)
        {
            var stuBLResult = businessAccess.GetStudent(id);
            var stuModel = StudentMapper.Map(stuBLResult);
            return View(stuModel);
        }

        [HttpPost]
        public ActionResult Delete(int id, StudentModel student)
        {
            var stuBLResult = businessAccess.delStudent(id);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            var studentBl = StudentMapper.reverseMap(student);
            var stuBLResult = businessAccess.pushStudent(studentBl);
            
            return RedirectToAction("Index");
        }
    }
}