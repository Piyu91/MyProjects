using EntityCurd.DataLayer.Declaration;
using EntityCurd.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCurd.DataLayer.Implemetation
{
    class DataAccess : IDataAccess
    {
        private ProjEntities db = new ProjEntities();

        public int delStudent(int id)
        {
            try
            {
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return -1;
            }
            return 1;
        }

        public Student GetStudent(int id)
        {
            
            Student student = db.Students.Find(id);
            return student;
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int pushStudent(Student student)
        {
            try
            {
               // db.Entry(student).State = EntityState.Added;
                db.Students.Add(student);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return -1;
            }
            return 1;
           
        }

        public int putStudent(int id, Student student)
        {
            try
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return -1;
            }
            return 1;
        }
    }
}
