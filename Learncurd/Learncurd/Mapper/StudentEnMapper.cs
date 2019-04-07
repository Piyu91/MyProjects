using EntityCurd.DataModel;
using Learncurd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learncurd.Mapper
{
    public class StudentEnMapper
    {
        public static List<StudentModel> MapList(List<Student> student)
        {
            var result = student.Select(x => new StudentModel
            {
                ID = x.Id,
                Name = x.Name,
                Marks = x.Marks,
                state = x.state
            }).ToList();

            return result;
        }
        public static StudentModel Map(Student student)
        {
            var result = new StudentModel
            {
                ID = student.Id,
                Name = student.Name,
                Marks = student.Marks,
                state = student.state
            };
            return result;
        }
        public static Student reverseMap(StudentModel student)
        {
            var result = new Student
            {
                Id = student.ID,
                Name = student.Name,
                Marks = student.Marks,
                state = student.state
            };
            return result;
        }
    }
}