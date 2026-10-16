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
            دانشجویانToolStripMenuItem = new ToolStripMenuItem();
            ثبتنامدانشجوToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهدانشجویانToolStripMenuItem = new ToolStripMenuItem();
            ترمToolStripMenuItem = new ToolStripMenuItem();
            ایجادترمهاToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهترمهاToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { دانشجویانToolStripMenuItem, ترمToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // دانشجویانToolStripMenuItem
            // 
            دانشجویانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتنامدانشجوToolStripMenuItem, مشاهدهدانشجویانToolStripMenuItem });
            دانشجویانToolStripMenuItem.Name = "دانشجویانToolStripMenuItem";
            دانشجویانToolStripMenuItem.Size = new Size(174, 48);
            دانشجویانToolStripMenuItem.Text = "دانشجویان";
            دانشجویانToolStripMenuItem.Click += ثبتنامToolStripMenuItem_Click;
            // 
            // ثبتنامدانشجوToolStripMenuItem
            // 
            ثبتنامدانشجوToolStripMenuItem.Name = "ثبتنامدانشجوToolStripMenuItem";
            ثبتنامدانشجوToolStripMenuItem.Size = new Size(448, 54);
            ثبتنامدانشجوToolStripMenuItem.Text = "ثبت نام دانشجو";
            ثبتنامدانشجوToolStripMenuItem.Click += ثبتنامدانشجوToolStripMenuItem_Click;
            // 
            // مشاهدهدانشجویانToolStripMenuItem
            // 
            مشاهدهدانشجویانToolStripMenuItem.Name = "مشاهدهدانشجویانToolStripMenuItem";
            مشاهدهدانشجویانToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهدانشجویانToolStripMenuItem.Text = "مشاهده دانشجویان";
            مشاهدهدانشجویانToolStripMenuItem.Click += مشاهدهدانشجویانToolStripMenuItem_Click;
            // 
            // ترمToolStripMenuItem
            // 
            ترمToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ایجادترمهاToolStripMenuItem, مشاهدهترمهاToolStripMenuItem });
            ترمToolStripMenuItem.Name = "ترمToolStripMenuItem";
            ترمToolStripMenuItem.Size = new Size(116, 48);
            ترمToolStripMenuItem.Text = "ترم ها";
            // 
            // ایجادترمهاToolStripMenuItem
            // 
            ایجادترمهاToolStripMenuItem.Name = "ایجادترمهاToolStripMenuItem";
            ایجادترمهاToolStripMenuItem.Size = new Size(448, 54);
            ایجادترمهاToolStripMenuItem.Text = "ایجاد ترم ";
            ایجادترمهاToolStripMenuItem.Click += ایجادترمهاToolStripMenuItem_Click;
            // 
            // مشاهدهترمهاToolStripMenuItem
            // 
            مشاهدهترمهاToolStripMenuItem.Name = "مشاهدهترمهاToolStripMenuItem";
            مشاهدهترمهاToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهترمهاToolStripMenuItem.Text = "مشاهده ترم ها";
            مشاهدهترمهاToolStripMenuItem.Click += مشاهدهترمهاToolStripMenuItem_Click;
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
        private ToolStripMenuItem دانشجویانToolStripMenuItem;
        private ToolStripMenuItem مشاهدهدانشجویانToolStripMenuItem;
        private ToolStripMenuItem ثبتنامدانشجوToolStripMenuItem;
        private ToolStripMenuItem ترمToolStripMenuItem;
        private ToolStripMenuItem ایجادترمهاToolStripMenuItem;
        private ToolStripMenuItem مشاهدهترمهاToolStripMenuItem;
    }
}