using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string FatherName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int Semester{ get; set; }
        public char Section {get; set; }
        public int ClassID { get; set; }
        public int  LoginID { get; set; }

        public string Address { get; set; }

        public string username { get; set; }
        public string password { get; set; }

    }
}
