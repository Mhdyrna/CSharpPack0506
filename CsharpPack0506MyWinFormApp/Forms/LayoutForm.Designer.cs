namespace CsharpPack0506MyWinFormApp.Forms
{
    partial class LayoutForm
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
            menuStrip1 = new MenuStrip();
            ثبتنامToolStripMenuItem = new ToolStripMenuItem();
            شهریهToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهدانشجویانToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهترمهاToolStripMenuItem = new ToolStripMenuItem();
            ترمهایباقیماندهToolStripMenuItem = new ToolStripMenuItem();
            ترمباقیماندهToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ثبتنامToolStripMenuItem, مشاهدهترمهاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ثبتنامToolStripMenuItem
            // 
            ثبتنامToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { شهریهToolStripMenuItem, مشاهدهدانشجویانToolStripMenuItem });
            ثبتنامToolStripMenuItem.Name = "ثبتنامToolStripMenuItem";
            ثبتنامToolStripMenuItem.Size = new Size(174, 48);
            ثبتنامToolStripMenuItem.Text = "دانشجویان";
            // 
            // شهریهToolStripMenuItem
            // 
            شهریهToolStripMenuItem.Name = "شهریهToolStripMenuItem";
            شهریهToolStripMenuItem.Size = new Size(448, 54);
            شهریهToolStripMenuItem.Text = "ثبت نام ";
            شهریهToolStripMenuItem.Click += شهریهToolStripMenuItem_Click;
            // 
            // مشاهدهدانشجویانToolStripMenuItem
            // 
            مشاهدهدانشجویانToolStripMenuItem.Name = "مشاهدهدانشجویانToolStripMenuItem";
            مشاهدهدانشجویانToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهدانشجویانToolStripMenuItem.Text = "مشاهده دانشجویان";
            مشاهدهدانشجویانToolStripMenuItem.Click += مشاهدهدانشجویانToolStripMenuItem_Click;
            // 
            // مشاهدهترمهاToolStripMenuItem
            // 
            مشاهدهترمهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ترمباقیماندهToolStripMenuItem, ترمهایباقیماندهToolStripMenuItem });
            مشاهدهترمهاToolStripMenuItem.Name = "مشاهدهترمهاToolStripMenuItem";
            مشاهدهترمهاToolStripMenuItem.Size = new Size(225, 48);
            مشاهدهترمهاToolStripMenuItem.Text = "مشاهده ترم ها";
            // 
            // ترمهایباقیماندهToolStripMenuItem
            // 
            ترمهایباقیماندهToolStripMenuItem.Name = "ترمهایباقیماندهToolStripMenuItem";
            ترمهایباقیماندهToolStripMenuItem.Size = new Size(448, 54);
            ترمهایباقیماندهToolStripMenuItem.Text = "لیست ترمها";
            ترمهایباقیماندهToolStripMenuItem.Click += ترمهایباقیماندهToolStripMenuItem_Click;
            // 
            // ترمباقیماندهToolStripMenuItem
            // 
            ترمباقیماندهToolStripMenuItem.Name = "ترمباقیماندهToolStripMenuItem";
            ترمباقیماندهToolStripMenuItem.Size = new Size(448, 54);
            ترمباقیماندهToolStripMenuItem.Text = "ترم باقیمانده";
            ترمباقیماندهToolStripMenuItem.Click += ترمباقیماندهToolStripMenuItem_Click;
            // 
            // LayoutForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LayoutForm";
            Text = "LayoutForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ثبتنامToolStripMenuItem;
        private ToolStripMenuItem شهریهToolStripMenuItem;
        private ToolStripMenuItem مشاهدهترمهاToolStripMenuItem;
        private ToolStripMenuItem ترمهایباقیماندهToolStripMenuItem;
        private ToolStripMenuItem مشاهدهدانشجویانToolStripMenuItem;
        private ToolStripMenuItem ترمباقیماندهToolStripMenuItem;
    }
}