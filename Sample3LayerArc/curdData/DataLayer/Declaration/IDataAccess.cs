using curdData.DataValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curdData.DataLayer.Declaration
{
    interface IDataAccess
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        int putStudent(int id , Student val);
        int pushStudent(Student val);
        int delStudent(int id);

    }
}
