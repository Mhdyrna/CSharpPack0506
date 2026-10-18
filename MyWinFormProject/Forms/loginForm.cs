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

            string pathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Configs", "logins.txt");
            string[] logins = null;

            if (File.Exists(pathFile))
            {
                logins = File.ReadAllLines(pathFile);
            }
            else
            {
                MessageBox.Show("سیستم با خطا روبرو شد");
                return;
            }
            if(logins is null || logins.Length==0)
            {
                MessageBox.Show("سیستم با خطا روبرو شد");
                return;
            }
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool successfulLogin = false;
            for(int i = 0;i<logins.Length;i++)
            {
                var loginRow = logins[i];
                string[] login = loginRow.Split(',');
                if (username.ToLower().Trim() == login[0] && password == login[1])
                {
                    successfulLogin = true;
                    break;
                  
                }

            }
            if(successfulLogin)
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات را به درستی وارد کنید.");
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
