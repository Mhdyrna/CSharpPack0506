using CsharpPack0506MyWinFormApp.Forms;

namespace CsharpPack0506MyWinFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Configs", "Logins.txt");
            string[] logins = null;
            if (File.Exists(filePath))
            {
                logins = File.ReadAllLines(filePath);
            }
            else
            {
                MessageBox.Show("Error");
                return;

            }

            if (logins is null || logins.Length == 0) 
            {
                MessageBox.Show("Error");
                return;
            }
            bool succssfulLogin = false;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            for(int i = 0; i < logins.Length; i++)
            {
                var loginRow = logins[i];
                string[] login=loginRow.Split(',');

                if (username.ToLower().Trim() == login[0] && password == login[1])
                {
                    //
                    succssfulLogin=true;
                    break;
                }

            }
            if (succssfulLogin)
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();

            }
            else
            {
                MessageBox.Show("اشتباه است");
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text=string.Empty;
            }

        }
    }
}
