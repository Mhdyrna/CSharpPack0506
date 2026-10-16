namespace MyWinFormProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            userNameTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 113);
            label1.Name = "label1";
            label1.Size = new Size(157, 46);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(12, 192);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.RightToLeft = RightToLeft.No;
            userNameTextBox.Size = new Size(577, 51);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 301);
            label2.Name = "label2";
            label2.Size = new Size(136, 46);
            label2.TabIndex = 0;
            label2.Text = "رمز عبور";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 379);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(577, 51);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Location = new Point(12, 528);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(577, 89);
            loginButton.TabIndex = 2;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 245);
            ClientSize = new Size(601, 891);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به سامانه";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}
