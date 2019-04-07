using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SchoolRecords.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {

        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        int putStudent(int id, Student val);

        [OperationContract]
        int pushStudent(Student val);

        [OperationContract]
        int delStudent(int id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Marks { get; set; }

        [DataMember]
        public string state { get; set; }
    }
}
