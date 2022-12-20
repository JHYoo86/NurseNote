
namespace NurseNote
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.시스템ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBManager = new System.Windows.Forms.ToolStripMenuItem();
            this.코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.진료과코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.진료의코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.병동코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.병실코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegPat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.병실등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시스템ToolStripMenuItem,
            this.코드관리ToolStripMenuItem,
            this.mnuRegPat,
            this.병실등록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 시스템ToolStripMenuItem
            // 
            this.시스템ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuDBManager});
            this.시스템ToolStripMenuItem.Name = "시스템ToolStripMenuItem";
            this.시스템ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.시스템ToolStripMenuItem.Text = "시스템";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(114, 22);
            this.mnuExit.Text = "종료";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDBManager
            // 
            this.mnuDBManager.Name = "mnuDBManager";
            this.mnuDBManager.Size = new System.Drawing.Size(114, 22);
            this.mnuDBManager.Text = "DB관리";
            this.mnuDBManager.Click += new System.EventHandler(this.mnuDBManager_Click);
            // 
            // 코드관리ToolStripMenuItem
            // 
            this.코드관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.진료과코드관리ToolStripMenuItem,
            this.진료의코드관리ToolStripMenuItem,
            this.병동코드관리ToolStripMenuItem,
            this.병실코드관리ToolStripMenuItem});
            this.코드관리ToolStripMenuItem.Name = "코드관리ToolStripMenuItem";
            this.코드관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.코드관리ToolStripMenuItem.Text = "코드관리";
            // 
            // 진료과코드관리ToolStripMenuItem
            // 
            this.진료과코드관리ToolStripMenuItem.Name = "진료과코드관리ToolStripMenuItem";
            this.진료과코드관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.진료과코드관리ToolStripMenuItem.Text = "진료과 코드관리";
            this.진료과코드관리ToolStripMenuItem.Click += new System.EventHandler(this.진료과코드관리ToolStripMenuItem_Click);
            // 
            // 진료의코드관리ToolStripMenuItem
            // 
            this.진료의코드관리ToolStripMenuItem.Name = "진료의코드관리ToolStripMenuItem";
            this.진료의코드관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.진료의코드관리ToolStripMenuItem.Text = "진료의 코드관리";
            this.진료의코드관리ToolStripMenuItem.Click += new System.EventHandler(this.진료의코드관리ToolStripMenuItem_Click);
            // 
            // 병동코드관리ToolStripMenuItem
            // 
            this.병동코드관리ToolStripMenuItem.Name = "병동코드관리ToolStripMenuItem";
            this.병동코드관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.병동코드관리ToolStripMenuItem.Text = "병동코드관리";
            this.병동코드관리ToolStripMenuItem.Click += new System.EventHandler(this.병동코드관리ToolStripMenuItem_Click);
            // 
            // 병실코드관리ToolStripMenuItem
            // 
            this.병실코드관리ToolStripMenuItem.Name = "병실코드관리ToolStripMenuItem";
            this.병실코드관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.병실코드관리ToolStripMenuItem.Text = "병실코드관리";
            this.병실코드관리ToolStripMenuItem.Click += new System.EventHandler(this.병실코드관리ToolStripMenuItem_Click);
            // 
            // mnuRegPat
            // 
            this.mnuRegPat.Name = "mnuRegPat";
            this.mnuRegPat.Size = new System.Drawing.Size(67, 20);
            this.mnuRegPat.Text = "환자등록";
            this.mnuRegPat.Click += new System.EventHandler(this.mnuRegPat_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 713);
            this.panel1.TabIndex = 1;
            // 
            // 병실등록ToolStripMenuItem
            // 
            this.병실등록ToolStripMenuItem.Name = "병실등록ToolStripMenuItem";
            this.병실등록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.병실등록ToolStripMenuItem.Text = "병실등록";
            this.병실등록ToolStripMenuItem.Click += new System.EventHandler(this.병실등록ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 시스템ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDBManager;
        private System.Windows.Forms.ToolStripMenuItem mnuRegPat;
        private System.Windows.Forms.ToolStripMenuItem 코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 진료과코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 진료의코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 병동코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 병실코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 병실등록ToolStripMenuItem;
    }
}