using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentInfoApp
{
    public class Student
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string RegNo { set; get; }

        public Student(string name,string email,string regNo)
        {
            Name = name;
            Email = email;
            RegNo = regNo;
        }
    }
}
