using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CsharpPack0506MyWinFormApp.Forms
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }

        private void شهریهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.Show();
        }

        private void مشاهدهدانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();
            userListForm.Show();
        }


        private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ایجادترمهاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ثبتنامدانشجوToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مشاهدهترمهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermListForm termListForm = new TermListForm();
            termListForm.Show();
        }
    }
}
