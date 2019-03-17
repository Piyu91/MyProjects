using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curdData.DataLayer.Declaration;
using curdData.DataValue;

namespace curdData.DataLayer.Implemetation
{
    class DataAccess : IDataAccess
    {
        static List<Student> students = new List<Student>();
        public DataAccess()
        {
            //if(students.Count == 0)
            //{
            //    students.Add(new Student { ID = 2, Name = "Priyanka", Marks = 60, state = "W.B." });
            //    students.Add(new Student { ID = 3, Name = "Sukanta", Marks = 80, state = "Assam" });
            //}
        }


        public int delStudent(int id)
        {
            
            try
            {
                students.Remove(students.Where(x => x.ID == id).FirstOrDefault());
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }

        public Student GetStudent(int id)
        {
            return students.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public int pushStudent(Student val)
        {
            try
            {
               var maxId =  students.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();
                val.ID = maxId + 1;
                students.Add(val);
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }

        public int putStudent(int id, Student val)
        {
            
            try
            {
                var stuRow = students.FirstOrDefault(x => x.ID == id);
                stuRow.Name = val.Name;
                stuRow.Marks = val.Marks;
                stuRow.state = val.state;
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }
    }
}
