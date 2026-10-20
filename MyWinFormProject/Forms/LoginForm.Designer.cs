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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            userNameTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            timeLabel = new Label();
            dateLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            timerOpacity = new System.Windows.Forms.Timer(components);
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
            passwordTextBox.UseSystemPasswordChar = true;
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
            loginButton.MouseEnter += loginButton_MouseEnter;
            loginButton.MouseLeave += loginButton_MouseLeave;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = SystemColors.ActiveCaptionText;
            timeLabel.Location = new Point(38, 76);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(97, 41);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "ساعت";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = SystemColors.ActiveCaptionText;
            dateLabel.Location = new Point(38, 23);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(80, 41);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "تاریخ";
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // timerOpacity
            // 
            timerOpacity.Interval = 20;
            timerOpacity.Tick += timerOpacity_Tick;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 245);
            ClientSize = new Size(601, 891);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Opacity = 0D;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به سامانه";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label timeLabel;
        private Label dateLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer timerOpacity;
    }
}
