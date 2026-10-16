namespace CsharpPack0506MyWinFormApp
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            menuStrip1 = new MenuStrip();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 112);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(384, 112);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(518, 47);
            userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(384, 213);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(518, 47);
            passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 213);
            label2.Name = "label2";
            label2.Size = new Size(123, 41);
            label2.TabIndex = 2;
            label2.Text = "رمز عبور";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ActiveCaptionText;
            loginButton.Location = new Point(283, 342);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(594, 58);
            loginButton.TabIndex = 4;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 52);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 726);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Button loginButton;
        private MenuStrip menuStrip1;
    }
}
