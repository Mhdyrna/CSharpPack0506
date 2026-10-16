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
            string username= userNameTextBox.Text;
            string password= passwordTextBox.Text;
            if (username == "admin" && password == "admin")
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات را به درستی وارد کنید.");
                userNameTextBox.Text=string.Empty;
                passwordTextBox.Text=string.Empty;

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
