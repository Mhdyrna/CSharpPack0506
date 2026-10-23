using CSharpPack0506.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSharpPack0506.BusinessLayer.Extensions;
using Newtonsoft.Json;
using CSharpPack0506.BusinessLayer.Validation;
namespace CsharpPack0506MyWinFormApp.Forms
{
    public partial class RegisterUserForm : Form
    {
        List<Student> students = new List<Student>();
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            string name = firstUserNameTextBox.Text;
            string lastName = lastUserNameTextBox.Text;
            string mobile = userPhoneNumberTextBox.Text.ToMobileFormat();
            string nationalCode = nationalCodeTextBox.Text;

            if (!MobileValidation.Validate(mobile))
            {
                MessageBox.Show("11 کاراکتر وارد کنید");
                return;
            }

            Student student = new Student(name, lastName, mobile, nationalCode);



            students.Add(student);
            userDataGridView.DataSource = students;

            firstUserNameTextBox.Text = default;
            lastUserNameTextBox.Text = default;
            userPhoneNumberTextBox.Text = default;
            nationalCodeTextBox.Text = default;

        }

        private void registerDataMock_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "Files", "MockData", "students.json");
            string json = null;
            if (File.Exists(filePath))
            {
                json = File.ReadAllText(filePath);
            }
            else
            {
                MessageBox.Show("فایل داده ماک یافت نشد");
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            userDataGridView.DataSource = students;



        }
    }
}
