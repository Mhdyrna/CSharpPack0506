using CsharpPack0506.DataLayer.Models;
using CSharpPack0506.BusinessLayer.Extensions;
using CSharpPack0506.BusinessLayer.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;


namespace MyWinFormProject.Forms
{
    public partial class RegisterAthleteForm : Form
    {
        List<Athlete> athletes = new List<Athlete>();
        public RegisterAthleteForm()
        {
            InitializeComponent();
        }

        private void registerAthleteButton_Click(object sender, EventArgs e)
        {
            string name = firstAthleteNameTextBox.Text;
            string lastName = lastAthleteNameTextBox.Text;
            string nationalCode = athleteNationalCodeTextBox.Text;
            string mobile = athleteMobileNumberTextBox.Text.ToMobileFormat();
            if (!MobileValidation.Validate(mobile))
            {
                MessageBox.Show("11 کاراکتر وارد کنید");
                return;
            }
            Athlete athlete = new Athlete(name, lastName, mobile, nationalCode);
            athletes.Add(athlete);
            athleteDataGridView.DataSource = athletes;

            firstAthleteNameTextBox.Text = default;
            lastAthleteNameTextBox = default;
            athleteNationalCodeTextBox = default;
            athleteMobileNumberTextBox = default;



        }

        private void registerAthleteDataMockButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "MockData", "athletesData.json");
            string json = null;
            if (File.Exists(filePath))
            {
                json = File.ReadAllText(filePath);
            }
            else
            {
                MessageBox.Show("فایل یافت نشد");
            }
            List<Athlete> athletes = JsonConvert.DeserializeObject<List<Athlete>>(json);
            athleteDataGridView.DataSource = athletes;
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LemonChiffon;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Navy;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.RoyalBlue;
        }

        private void RegisterAthleteForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enter += TextBox_Enter;
                    textBox.Leave += TextBox_Leave;
                }
                if (control is Button button)
                {
                    button.BackColor = Color.RoyalBlue;
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;

                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void searchAthleteButton_MouseEnter(object sender, EventArgs e)
        {
            searchAthleteButton.BackColor = Color.BlueViolet;
        }

        private void searchAthleteButton_Click(object sender, EventArgs e)
        {

        }

        private void registerAthleteButton_MouseEnter(object sender, EventArgs e)
        {
            registerAthleteButton.BackColor = Color.GreenYellow;
        }

        private void registerAthleteDataMockButton_MouseEnter(object sender, EventArgs e)
        {
            registerAthleteDataMockButton.BackColor = Color.Yellow;
        }
    }
}
