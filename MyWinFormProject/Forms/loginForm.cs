using MyWinFormProject.Forms;

namespace MyWinFormProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();
            }
        }
    }
}
