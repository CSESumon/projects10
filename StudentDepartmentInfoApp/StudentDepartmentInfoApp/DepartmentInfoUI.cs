using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDepartmentInfoApp
{
    public partial class DepartmentInfoUI : Form
    {
        public DepartmentInfoUI()
        {
            InitializeComponent();
        }

        public Department aDepartment;
        private void departmentButton_Click(object sender, EventArgs e)
        {
            aDepartment=new Department(deptCodeTextBox.Text,deptNameTextBox.Text);
            

            MessageBox.Show("Department Created");
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student(studentRegNoTextBox.Text,studentNameTextBox.Text,studentEmailTextBox.Text);
            string msg=aDepartment.AddStudent(aStudent);
            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string info = "Code " + aDepartment.Code + " Name " + aDepartment.Name + "\n";
            info += "Reg No \t Name \t Email \n";
            foreach (Student aStudent in aDepartment.GetStudents() )
            {
                string aRow = aStudent.RegNo + "\t" + aStudent.Name + "\t" + aStudent.Email + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
