namespace Student_Management_System
{
    partial class frm_Update_Student_Details
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
            this.lbl_Update_Student_Details = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Update_Student_Details
            // 
            this.lbl_Update_Student_Details.AutoSize = true;
            this.lbl_Update_Student_Details.BackColor = System.Drawing.Color.Plum;
            this.lbl_Update_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Student_Details.Location = new System.Drawing.Point(108, 33);
            this.lbl_Update_Student_Details.Name = "lbl_Update_Student_Details";
            this.lbl_Update_Student_Details.Size = new System.Drawing.Size(752, 78);
            this.lbl_Update_Student_Details.TabIndex = 0;
            this.lbl_Update_Student_Details.Text = "Update Student Details";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(210, 200);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 32);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(210, 273);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(94, 32);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(210, 353);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(191, 32);
            this.lbl_DOB.TabIndex = 3;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(210, 434);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(173, 32);
            this.lbl_Department.TabIndex = 4;
            this.lbl_Department.Text = "Department";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(496, 200);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(364, 30);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(496, 273);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(364, 30);
            this.tb_Name.TabIndex = 2;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(496, 353);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(364, 30);
            this.dtp_DOB.TabIndex = 3;
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Computer Science",
            "Mathematics",
            "Electronics",
            "Statistic",
            "Biology",
            "Chemistry"});
            this.cmb_Department.Location = new System.Drawing.Point(496, 434);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(364, 33);
            this.cmb_Department.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.HotPink;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(149, 548);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(155, 43);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Orchid;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(448, 548);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(158, 44);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.HotPink;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(738, 548);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(143, 44);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(918, 33);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(127, 39);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(866, 195);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 41);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1095, 627);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Update_Student_Details);
            this.Name = "frm_Update_Student_Details";
            this.Text = "Update Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Update_Student_Details;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Search;
    }
}