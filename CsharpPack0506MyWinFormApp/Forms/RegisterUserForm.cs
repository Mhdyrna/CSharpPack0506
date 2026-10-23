using CSharpPack0506.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace CsharpPack0506MyWinFormApp.Forms
{
    public partial class RegisterUserForm : Form
    {
        List<Student> students= new List<Student>();
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            string name = firstUserNameTextBox.Text;
            string lastName = lastUserNameTextBox.Text;
            string mobile = userPhoneNumberTextBox.Text;
            string nationalCode = nationalCodeTextBox.Text;
            Student student = new Student(name,lastName,mobile,nationalCode);

            students.Add(student);
            userDataGridView.DataSource = students;

            firstUserNameTextBox.Text = default;
            lastUserNameTextBox.Text = default;
            userPhoneNumberTextBox.Text = default;
            nationalCodeTextBox.Text = default;

        }
    }
}
