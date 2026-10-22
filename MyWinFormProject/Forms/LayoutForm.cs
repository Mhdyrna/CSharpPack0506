using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyWinFormProject.Forms
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }

        private void LayoutForm_Load(object sender, EventArgs e)
        {

        }

        private void مشاهدهورزشکارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AthleteListForm athleteListForm = new AthleteListForm();
            athleteListForm.Show();
        }

        private void ثبتنامورزشکارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterAthleteForm registerAthleteForm = new RegisterAthleteForm();
            registerAthleteForm.Show();
        }

        private void مشاهدهرشتههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryListForm = new CategoryListForm();
            categoryListForm.Show();
        }

        private void ایجادرشتههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Show();
        }

        private void ایجادسانسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSessionForm addSessionForm = new AddSessionForm();
            addSessionForm.Show();
        }

        private void مشاهدهسانسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionListForm sessionListForm = new SessionListForm();
            sessionListForm.Show();
        }
    }
}
