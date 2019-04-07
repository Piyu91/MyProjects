using SchoolRecords.Data.DataModel;
using System.Collections.Generic;

namespace SchoolRecords.Data.BusinessLayer
{
    public interface IBusinessAccess
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        int putStudent(int id, Student val);
        int pushStudent(Student val);
        int delStudent(int id);
    }
}
