namespace CsharpPack0506MyWinFormApp.Forms
{
    partial class RegisterUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstUserNameTextBox = new TextBox();
            firstName = new Label();
            lastUserNameTextBox = new TextBox();
            lastName = new Label();
            label1 = new Label();
            userPhoneNumberTextBox = new TextBox();
            nationalCodeLabel = new Label();
            nationalCodeTextBox = new TextBox();
            searchUserButton = new Button();
            RegisterUserButton = new Button();
            userDataGridView = new DataGridView();
            registerDataMock = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstUserNameTextBox
            // 
            firstUserNameTextBox.Location = new Point(89, 27);
            firstUserNameTextBox.Name = "firstUserNameTextBox";
            firstUserNameTextBox.Size = new Size(469, 47);
            firstUserNameTextBox.TabIndex = 3;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(29, 27);
            firstName.Name = "firstName";
            firstName.Size = new Size(54, 41);
            firstName.TabIndex = 2;
            firstName.Text = "نام";
            // 
            // lastUserNameTextBox
            // 
            lastUserNameTextBox.Location = new Point(211, 106);
            lastUserNameTextBox.Name = "lastUserNameTextBox";
            lastUserNameTextBox.Size = new Size(347, 47);
            lastUserNameTextBox.TabIndex = 5;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(29, 106);
            lastName.Name = "lastName";
            lastName.Size = new Size(176, 41);
            lastName.TabIndex = 4;
            lastName.Text = "نام خانوادگی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 185);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 4;
            label1.Text = "شماره تماس";
            // 
            // userPhoneNumberTextBox
            // 
            userPhoneNumberTextBox.Location = new Point(211, 185);
            userPhoneNumberTextBox.Name = "userPhoneNumberTextBox";
            userPhoneNumberTextBox.Size = new Size(347, 47);
            userPhoneNumberTextBox.TabIndex = 5;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(29, 263);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(109, 41);
            nationalCodeLabel.TabIndex = 4;
            nationalCodeLabel.Text = "کد ملی";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(211, 263);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(347, 47);
            nationalCodeTextBox.TabIndex = 5;
            // 
            // searchUserButton
            // 
            searchUserButton.Location = new Point(29, 330);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(529, 58);
            searchUserButton.TabIndex = 6;
            searchUserButton.Text = "جست و جو کاربر";
            searchUserButton.UseVisualStyleBackColor = true;
            // 
            // RegisterUserButton
            // 
            RegisterUserButton.Location = new Point(29, 404);
            RegisterUserButton.Name = "RegisterUserButton";
            RegisterUserButton.Size = new Size(529, 58);
            RegisterUserButton.TabIndex = 7;
            RegisterUserButton.Text = "ثبت نام کاربر";
            RegisterUserButton.UseVisualStyleBackColor = true;
            RegisterUserButton.Click += RegisterUserButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(594, 27);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 102;
            userDataGridView.Size = new Size(806, 769);
            userDataGridView.TabIndex = 8;
            // 
            // registerDataMock
            // 
            registerDataMock.Location = new Point(29, 478);
            registerDataMock.Name = "registerDataMock";
            registerDataMock.Size = new Size(529, 58);
            registerDataMock.TabIndex = 9;
            registerDataMock.Text = "افزودن اعضا بصورت ماک";
            registerDataMock.UseVisualStyleBackColor = true;
            registerDataMock.Click += registerDataMock_Click;
            // 
            // RegisterUserForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 808);
            Controls.Add(registerDataMock);
            Controls.Add(userDataGridView);
            Controls.Add(RegisterUserButton);
            Controls.Add(searchUserButton);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(nationalCodeLabel);
            Controls.Add(userPhoneNumberTextBox);
            Controls.Add(label1);
            Controls.Add(lastUserNameTextBox);
            Controls.Add(lastName);
            Controls.Add(firstUserNameTextBox);
            Controls.Add(firstName);
            Name = "RegisterUserForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstUserNameTextBox;
        private Label firstName;
        private TextBox lastUserNameTextBox;
        private Label lastName;
        private Label label1;
        private TextBox userPhoneNumberTextBox;
        private Label nationalCodeLabel;
        private TextBox nationalCodeTextBox;
        private Button searchUserButton;
        private Button RegisterUserButton;
        private DataGridView userDataGridView;
        private Button registerDataMock;
    }
}