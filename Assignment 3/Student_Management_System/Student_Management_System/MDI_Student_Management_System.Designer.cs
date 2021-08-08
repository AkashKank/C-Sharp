namespace Student_Management_System
{
    partial class MDI_Student_Management_System
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeblocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.codeblocksToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.searchStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllStudentsToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewAllStudentsToolStripMenuItem
            // 
            this.viewAllStudentsToolStripMenuItem.Name = "viewAllStudentsToolStripMenuItem";
            this.viewAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.viewAllStudentsToolStripMenuItem.Text = "View All Students";
            this.viewAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentsToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // codeblocksToolStripMenuItem
            // 
            this.codeblocksToolStripMenuItem.Name = "codeblocksToolStripMenuItem";
            this.codeblocksToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.codeblocksToolStripMenuItem.Text = "Codeblocks";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1023, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1023, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(704, 8);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Location = new System.Drawing.Point(434, 11);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(42, 17);
            this.lbl_Head.TabIndex = 5;
            this.lbl_Head.Text = "Head";
            // 
            // MDI_Student_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Student_Management_System";
            this.Text = "View All Students";
            this.Load += new System.EventHandler(this.MDI_Student_Management_System_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeblocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Head;
    }
}



