namespace MyWinFormProject.Forms
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
            ورزشکارانToolStripMenuItem = new ToolStripMenuItem();
            ثبتنامورزشکارانToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهورزشکارانToolStripMenuItem = new ToolStripMenuItem();
            رشتههاToolStripMenuItem = new ToolStripMenuItem();
            ایجادرشتههاToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهرشتههاToolStripMenuItem = new ToolStripMenuItem();
            سانسهاToolStripMenuItem = new ToolStripMenuItem();
            ایجادسانسToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهسانسهاToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ورزشکارانToolStripMenuItem, رشتههاToolStripMenuItem, سانسهاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(800, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ورزشکارانToolStripMenuItem
            // 
            ورزشکارانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتنامورزشکارانToolStripMenuItem, مشاهدهورزشکارانToolStripMenuItem });
            ورزشکارانToolStripMenuItem.Name = "ورزشکارانToolStripMenuItem";
            ورزشکارانToolStripMenuItem.Size = new Size(163, 48);
            ورزشکارانToolStripMenuItem.Text = "ورزشکاران";
            // 
            // ثبتنامورزشکارانToolStripMenuItem
            // 
            ثبتنامورزشکارانToolStripMenuItem.Name = "ثبتنامورزشکارانToolStripMenuItem";
            ثبتنامورزشکارانToolStripMenuItem.Size = new Size(448, 54);
            ثبتنامورزشکارانToolStripMenuItem.Text = "ثبت نام ورزشکاران";
            // 
            // مشاهدهورزشکارانToolStripMenuItem
            // 
            مشاهدهورزشکارانToolStripMenuItem.Name = "مشاهدهورزشکارانToolStripMenuItem";
            مشاهدهورزشکارانToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهورزشکارانToolStripMenuItem.Text = "مشاهده ورزشکاران";
            // 
            // رشتههاToolStripMenuItem
            // 
            رشتههاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ایجادرشتههاToolStripMenuItem, مشاهدهرشتههاToolStripMenuItem });
            رشتههاToolStripMenuItem.Name = "رشتههاToolStripMenuItem";
            رشتههاToolStripMenuItem.Size = new Size(138, 48);
            رشتههاToolStripMenuItem.Text = "رشته ها";
            // 
            // ایجادرشتههاToolStripMenuItem
            // 
            ایجادرشتههاToolStripMenuItem.Name = "ایجادرشتههاToolStripMenuItem";
            ایجادرشتههاToolStripMenuItem.Size = new Size(448, 54);
            ایجادرشتههاToolStripMenuItem.Text = "ایجاد رشته ها";
            // 
            // مشاهدهرشتههاToolStripMenuItem
            // 
            مشاهدهرشتههاToolStripMenuItem.Name = "مشاهدهرشتههاToolStripMenuItem";
            مشاهدهرشتههاToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهرشتههاToolStripMenuItem.Text = "مشاهده رشته ها";
            // 
            // سانسهاToolStripMenuItem
            // 
            سانسهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ایجادسانسToolStripMenuItem, مشاهدهسانسهاToolStripMenuItem });
            سانسهاToolStripMenuItem.Name = "سانسهاToolStripMenuItem";
            سانسهاToolStripMenuItem.Size = new Size(164, 48);
            سانسهاToolStripMenuItem.Text = "سانس ها ";
            // 
            // ایجادسانسToolStripMenuItem
            // 
            ایجادسانسToolStripMenuItem.Name = "ایجادسانسToolStripMenuItem";
            ایجادسانسToolStripMenuItem.Size = new Size(448, 54);
            ایجادسانسToolStripMenuItem.Text = "ایجاد سانس";
            // 
            // مشاهدهسانسهاToolStripMenuItem
            // 
            مشاهدهسانسهاToolStripMenuItem.Name = "مشاهدهسانسهاToolStripMenuItem";
            مشاهدهسانسهاToolStripMenuItem.Size = new Size(448, 54);
            مشاهدهسانسهاToolStripMenuItem.Text = "مشاهده سانس ها";
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
            Load += LayoutForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ورزشکارانToolStripMenuItem;
        private ToolStripMenuItem ثبتنامورزشکارانToolStripMenuItem;
        private ToolStripMenuItem مشاهدهورزشکارانToolStripMenuItem;
        private ToolStripMenuItem رشتههاToolStripMenuItem;
        private ToolStripMenuItem ایجادرشتههاToolStripMenuItem;
        private ToolStripMenuItem مشاهدهرشتههاToolStripMenuItem;
        private ToolStripMenuItem سانسهاToolStripMenuItem;
        private ToolStripMenuItem ایجادسانسToolStripMenuItem;
        private ToolStripMenuItem مشاهدهسانسهاToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}