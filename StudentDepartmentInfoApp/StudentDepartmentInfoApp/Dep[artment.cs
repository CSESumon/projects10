using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentInfoApp
{
    public class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        private List<Student> students;
        private const int MAX_NO_OF_STUDENTS = 10;

        public string AddStudent(Student aStudent)
        {
            if (students.Count<MAX_NO_OF_STUDENTS)
            {
                if (HasThisRegNo(aStudent.RegNo))
                {
                    return "Already Exists";
                }
                students.Add(aStudent);
                return "Student Added";
            }
            else
            {
                return "Overflow";
            }
        }

        private bool HasThisRegNo(string regNO)
        {
            foreach (Student studentRef in students)
            {
                if (studentRef.RegNo==regNO)
                {
                    return true;
                }
            }
            return false;
        }

        public Department(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
            students=new List<Student>();
        }

        public Student[] GetStudents()
        {
            return students.ToArray();
        } 
    }
}
