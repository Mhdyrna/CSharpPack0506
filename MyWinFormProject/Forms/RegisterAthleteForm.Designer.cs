namespace MyWinFormProject.Forms
{
    partial class RegisterAthleteForm
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstAthleteNameTextBox = new TextBox();
            lastAthleteNameTextBox = new TextBox();
            mobileLabel = new Label();
            athleteMobileNumberTextBox = new TextBox();
            athleteNationalCodeTextBox = new TextBox();
            nationalCodeLabel = new Label();
            searchAthleteButton = new Button();
            registerAthleteButton = new Button();
            registerAthleteDataMockButton = new Button();
            athleteDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)athleteDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(1516, 46);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(62, 41);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "نام ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(1402, 116);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(176, 41);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "نام خانوادگی";
            // 
            // firstAthleteNameTextBox
            // 
            firstAthleteNameTextBox.Location = new Point(1007, 46);
            firstAthleteNameTextBox.Name = "firstAthleteNameTextBox";
            firstAthleteNameTextBox.RightToLeft = RightToLeft.Yes;
            firstAthleteNameTextBox.Size = new Size(474, 47);
            firstAthleteNameTextBox.TabIndex = 0;
            // 
            // lastAthleteNameTextBox
            // 
            lastAthleteNameTextBox.Location = new Point(1007, 116);
            lastAthleteNameTextBox.Name = "lastAthleteNameTextBox";
            lastAthleteNameTextBox.RightToLeft = RightToLeft.Yes;
            lastAthleteNameTextBox.Size = new Size(389, 47);
            lastAthleteNameTextBox.TabIndex = 1;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new Point(1405, 189);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new Size(173, 41);
            mobileLabel.TabIndex = 3;
            mobileLabel.Text = "شماره تماس";
            // 
            // athleteMobileNumberTextBox
            // 
            athleteMobileNumberTextBox.Location = new Point(1007, 189);
            athleteMobileNumberTextBox.Name = "athleteMobileNumberTextBox";
            athleteMobileNumberTextBox.RightToLeft = RightToLeft.Yes;
            athleteMobileNumberTextBox.Size = new Size(389, 47);
            athleteMobileNumberTextBox.TabIndex = 2;
            // 
            // athleteNationalCodeTextBox
            // 
            athleteNationalCodeTextBox.Location = new Point(1007, 261);
            athleteNationalCodeTextBox.Name = "athleteNationalCodeTextBox";
            athleteNationalCodeTextBox.RightToLeft = RightToLeft.Yes;
            athleteNationalCodeTextBox.Size = new Size(389, 47);
            athleteNationalCodeTextBox.TabIndex = 3;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(1469, 264);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(109, 41);
            nationalCodeLabel.TabIndex = 3;
            nationalCodeLabel.Text = "کد ملی";
            // 
            // searchAthleteButton
            // 
            searchAthleteButton.Location = new Point(1007, 336);
            searchAthleteButton.Name = "searchAthleteButton";
            searchAthleteButton.Size = new Size(571, 58);
            searchAthleteButton.TabIndex = 4;
            searchAthleteButton.Text = "جست و جو ورزشکار";
            searchAthleteButton.UseVisualStyleBackColor = true;
            searchAthleteButton.Click += searchAthleteButton_Click;
            // 
            // registerAthleteButton
            // 
            registerAthleteButton.Location = new Point(1007, 420);
            registerAthleteButton.Name = "registerAthleteButton";
            registerAthleteButton.Size = new Size(571, 58);
            registerAthleteButton.TabIndex = 5;
            registerAthleteButton.Text = "ثبت نام ورزشکار";
            registerAthleteButton.UseVisualStyleBackColor = true;
            registerAthleteButton.Click += registerAthleteButton_Click;
            // 
            // registerAthleteDataMockButton
            // 
            registerAthleteDataMockButton.Location = new Point(1007, 506);
            registerAthleteDataMockButton.Name = "registerAthleteDataMockButton";
            registerAthleteDataMockButton.Size = new Size(571, 58);
            registerAthleteDataMockButton.TabIndex = 6;
            registerAthleteDataMockButton.Text = "ثبت نام ورزشکاران بصورت ماک";
            registerAthleteDataMockButton.UseVisualStyleBackColor = true;
            registerAthleteDataMockButton.Click += registerAthleteDataMockButton_Click;
            // 
            // athleteDataGridView
            // 
            athleteDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            athleteDataGridView.Location = new Point(25, 33);
            athleteDataGridView.Name = "athleteDataGridView";
            athleteDataGridView.RowHeadersWidth = 102;
            athleteDataGridView.Size = new Size(929, 766);
            athleteDataGridView.TabIndex = 5;
            // 
            // RegisterAthleteForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1609, 786);
            Controls.Add(athleteDataGridView);
            Controls.Add(registerAthleteDataMockButton);
            Controls.Add(registerAthleteButton);
            Controls.Add(searchAthleteButton);
            Controls.Add(nationalCodeLabel);
            Controls.Add(mobileLabel);
            Controls.Add(athleteNationalCodeTextBox);
            Controls.Add(athleteMobileNumberTextBox);
            Controls.Add(lastAthleteNameTextBox);
            Controls.Add(firstAthleteNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "RegisterAthleteForm";
            Text = "RegisterAthleteForm";
            Load += RegisterAthleteForm_Load;
            ((System.ComponentModel.ISupportInitialize)athleteDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstAthleteNameTextBox;
        private TextBox lastAthleteNameTextBox;
        private Label mobileLabel;
        private TextBox athleteMobileNumberTextBox;
        private TextBox athleteNationalCodeTextBox;
        private Label nationalCodeLabel;
        private Button searchAthleteButton;
        private Button registerAthleteButton;
        private Button registerAthleteDataMockButton;
        private DataGridView athleteDataGridView;
    }
}