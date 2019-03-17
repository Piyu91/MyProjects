using EntityCurd.DataModel;
using System.Collections.Generic;


namespace EntityCurd.DataLayer.Declaration
{
    interface IDataAccess
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        int putStudent(int id, Student val);
        int pushStudent(Student val);
        int delStudent(int id);
    }
}
