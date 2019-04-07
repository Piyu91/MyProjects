using curdData.BusinessLayer.Declaration;
using curdData.DataLayer.Implemetation;
using curdData.DataValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curdData.BusinessLayer.Implementation
{
    public class BusinessAccess : IBusinessAccess
    {
        private DataAccess _dataAccess = new DataAccess();

        public int delStudent(int id)
        {
            return _dataAccess.delStudent(id);
        }

        public Student GetStudent(int id)
        {
            return _dataAccess.GetStudent(id);
        }

        public List<Student> GetStudents()
        {
            return _dataAccess.GetStudents();
        }

        public int pushStudent(Student val)
        {
            return _dataAccess.pushStudent(val);
        }

        public int putStudent(int id, Student val)
        {
            return _dataAccess.putStudent(id,val);
        }
    }
}
