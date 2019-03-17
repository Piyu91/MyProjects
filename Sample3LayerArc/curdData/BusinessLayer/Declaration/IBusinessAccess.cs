using curdData.DataValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curdData.BusinessLayer.Declaration
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
