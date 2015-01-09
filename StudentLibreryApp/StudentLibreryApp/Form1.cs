using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLibreryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student aStudent = new Student();
        Librery aLibrery = new Librery();
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            aStudent.Name = studentNameTextBox.Text;
            aStudent.Id = studentIdTextBox.Text;
            aStudent.Department = studentDeptTextBox.Text;

            
            aLibrery.IsbnNo = bookIsbnTextBox.Text;
            aLibrery.Book = bookNameTextBox.Text;
            aLibrery.BorrowDate = borrowDateTextBox.Text;
            aLibrery.Aurthor = aurtherNameTextBox.Text;

            aStudent.StudentLibrery = aLibrery;

            MessageBox.Show("Data has been saved");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == aLibrery.IsbnNo)
            {
                ListViewItem myItem = new ListViewItem();
                myItem.Text = aStudent.Name;
                myItem.SubItems.Add(aStudent.Id);
                myItem.SubItems.Add(aStudent.Department);
                myItem.SubItems.Add(aLibrery.Book);
                myItem.SubItems.Add(aLibrery.Aurthor);
                myItem.SubItems.Add(aLibrery.BorrowDate);

                showListView.Items.Add(myItem);
            }
            else
            {
                MessageBox.Show("Sorry! Try again.");
            }
            
        }

        private void showListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
