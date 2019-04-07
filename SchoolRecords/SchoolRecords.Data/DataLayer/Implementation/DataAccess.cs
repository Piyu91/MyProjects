using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolRecords.Data.DataModel;

namespace SchoolRecords.Data.DataLayer
{
    class DataAccess : IDataAccess
    {
        // create object of edmx student file to acces list student data memeber
        private ProjEntities _db = new ProjEntities();

        public int delStudent(int id)
        {
            try
            {
                Student student = _db.Students.Find(id);
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public Student GetStudent(int id)
        {

            Student student = _db.Students.Find(id);
            return student;
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }

        public int pushStudent(Student student)
        {
            try
            {
                // _db.Entry(student).State = EntityState.Added;
                _db.Students.Add(student);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;

        }

        public int putStudent(int id, Student student)
        {
            try
            {
                _db.Entry(student).State = EntityState.Modified;
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }
    }
}
