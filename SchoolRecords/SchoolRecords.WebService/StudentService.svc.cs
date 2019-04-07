using SchoolRecords.Data.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SchoolRecords.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        private IBusinessAccess _objbusiness = new BusinessAccess();
        public int delStudent(int id)
        {
            return _objbusiness.delStudent(id);
        }

        public Student GetStudent(int id)
        {
            var result = _objbusiness.GetStudent(id);
            return new Student
            {
                Id = result.Id,
                Marks = result.Marks,
                Name = result.Name,
                state = result.state
            };
        }

        public List<Student> GetStudents()
        {
            var result = _objbusiness.GetStudents();
            return result.Select(x => new Student
            {
                Id = x.Id,
                Marks = x.Marks,
                Name = x.Name,
                state = x.state
                
            }).ToList();
        }

        public int pushStudent(Student val)
        {
            var updateStudent = new Data.DataModel.Student
            {
                                    Id = val.Id,
                                    Marks = val.Marks,
                                    Name = val.Name,
                                    state = val.state
                                };
            return _objbusiness.pushStudent(updateStudent);
        }

        public int putStudent(int id, Student val)
        {
            var insertStudent = new Data.DataModel.Student
            {
                Id = val.Id,
                Marks = val.Marks,
                Name = val.Name,
                state = val.state
            };
            return _objbusiness.putStudent(id, insertStudent);
        }
    }
}
