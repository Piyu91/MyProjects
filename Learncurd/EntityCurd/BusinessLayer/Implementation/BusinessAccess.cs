using EntityCurd.DataLayer.Declaration;
using EntityCurd.DataLayer.Implemetation;
using EntityCurd.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCurd.BusinessLayer
{
    public class BusinessAccess : IBusinessAccess
    {
        IDataAccess dataAccess = new DataAccess();

        public int delStudent(int id)
        {
            return dataAccess.delStudent(id);
        }

        public Student GetStudent(int id)
        {
            return dataAccess.GetStudent(id);
        }

        public List<Student> GetStudents()
        {
            return dataAccess.GetStudents();
        }

        public int pushStudent(Student val)
        {
            return dataAccess.pushStudent(val);
        }

        public int putStudent(int id, Student val)
        {
            return dataAccess.putStudent(id, val);
        }
    }
}
