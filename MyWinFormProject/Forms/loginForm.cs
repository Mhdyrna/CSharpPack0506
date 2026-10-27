using MyWinFormProject.Forms;
using System.Globalization;

namespace MyWinFormProject
{
    public partial class LoginForm : Form
    {
        int count = 0;  // فقط هنگام ساخته شدن فرم مقداردهی اولیه می‌شود
        public LoginForm()
        {
            InitializeComponent();
            UpdateClock();
            clockTimer.Start();
            timerOpacity.Interval = 20;
            timerOpacity.Start();


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
            if (logins is null || logins.Length == 0)
            {
                MessageBox.Show("سیستم با خطا روبرو شد");
                return;
            }


            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool successfulLogin = false;
            for (int i = 0; i < logins.Length; i++)
            {
                var loginRow = logins[i];
                string[] login = loginRow.Split(',');
                if (username.ToLower().Trim() == login[0] && password == login[1])
                {
                    successfulLogin = true;
                    break;

                }

            }
            if (string.IsNullOrEmpty(userNameTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("نام کاربری و رمز عبور را وارد کنید");
                return;
            }
            if (successfulLogin)
            {
                LayoutForm layoutForm = new LayoutForm();
                layoutForm.Show();
            }
            else
            {
                count++;
                MessageBox.Show("اطلاعات را به درستی وارد کنید");
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                if (count == 3)
                {
                    MessageBox.Show("برنامه به علت خطای مکرر بسته شد");
                    Application.Exit();
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdateClock()
        {

            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd",
                                                    CultureInfo.InvariantCulture);
        }
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.025;
            }
            else
            {
                this.Opacity = 1;
                timerOpacity.Stop();
            }
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.DarkBlue;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.LightBlue;
        }
    }
}
