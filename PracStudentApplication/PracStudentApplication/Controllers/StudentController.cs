using PracStudentApplication.Models;
using PracStudentApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracStudentApplication.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _listStudent;

        static StudentController()
        {
            _listStudent = new List<Student>();
            // Student std = new Student() { StuId=1, StuMarks=20, StuName="Priyanka Saha", StuEmail="p@gmail.com" };

            _listStudent.Add(new Student() { StuId = 1, StuMarks = 20, StuName = "Priyanka Saha", StuEmail = "p@gmail.com" });
            _listStudent.Add(new Student() { StuId = 2, StuMarks = 30, StuName = "Sukanta Saha", StuEmail = "s@gmail.com" });

        }
        // GET: Student
        public ActionResult Index()
        {
            StudentViewModel StudentViewModel = new StudentViewModel();
            StudentViewModel.listStudents = _listStudent;
            StudentViewModel.StudentSingle = new Student();

            return View(StudentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]

       public ActionResult InserPost([Bind(Include = "StuId, StuName, StuEmail, StuMarks")]  Student insertpostStu)
        {
            if (ModelState.IsValid)
            {
                var maxid = _listStudent.Max(x => x.StuId);
                insertpostStu.StuId = maxid + 1;
                _listStudent.Add(insertpostStu);
            }

            return RedirectToAction("Index");

        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var delStudet = _listStudent.Find(x => id == x.StuId);
            if (delStudet == null)
            {
                return RedirectToAction("Index");
            }

            return View(delStudet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult studentDelete(int id)
        {

            var delStudet = _listStudent.Find(x => id == x.StuId);
            _listStudent.Remove(delStudet);
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var editStu = _listStudent.Find(x => id == x.StuId);

            if (editStu == null)
            {
                return RedirectToAction("Index");
            }

            return View(editStu);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]

        public ActionResult Editstudent([Bind(Include = "StuId, StuName, StuEmail, StuMarks")]  Student editpostStu)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var editstu = _listStudent.Find(delegate (Student x)
                                                {
                                                    return x.StuId == editpostStu.StuId;
                                                });

                editstu.StuId = editpostStu.StuId;
                editstu.StuEmail = editpostStu.StuEmail;
                editstu.StuMarks = editpostStu.StuMarks;
                editstu.StuName = editpostStu.StuName;
            }

            return RedirectToAction("Index");
        }
    }
}