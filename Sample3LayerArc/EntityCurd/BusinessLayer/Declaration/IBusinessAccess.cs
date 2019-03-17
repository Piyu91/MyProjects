using EntityCurd.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCurd.BusinessLayer
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
