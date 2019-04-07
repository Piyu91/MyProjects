using System.Collections.Generic;
using SchoolRecords.Data.DataLayer;
using SchoolRecords.Data.DataModel;

namespace SchoolRecords.Data.BusinessLayer
{
    public class BusinessAccess : IBusinessAccess
    {
        private IDataAccess _dataAccess = new DataAccess();

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
            return _dataAccess.putStudent(id, val);
        }
    }
}
