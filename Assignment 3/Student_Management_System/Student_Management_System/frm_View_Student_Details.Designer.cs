namespace Student_Management_System
{
    partial class frm_View_Student_Details
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
            this.lbl_View_Student_Details = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgv_View_Student_Details = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DBDataSet = new Student_Management_System.Student_DBDataSet();
            this.student_DetailsTableAdapter = new Student_Management_System.Student_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_Details
            // 
            this.lbl_View_Student_Details.AutoSize = true;
            this.lbl_View_Student_Details.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_View_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_Details.Location = new System.Drawing.Point(141, 35);
            this.lbl_View_Student_Details.Name = "lbl_View_Student_Details";
            this.lbl_View_Student_Details.Size = new System.Drawing.Size(676, 78);
            this.lbl_View_Student_Details.TabIndex = 0;
            this.lbl_View_Student_Details.Text = "View Student Details";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(871, 35);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(117, 40);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(419, 517);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(164, 39);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_View_Student_Details
            // 
            this.dgv_View_Student_Details.AllowUserToAddRows = false;
            this.dgv_View_Student_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Student_Details.AutoGenerateColumns = false;
            this.dgv_View_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgv_View_Student_Details.DataSource = this.studentDetailsBindingSource;
            this.dgv_View_Student_Details.Location = new System.Drawing.Point(36, 143);
            this.dgv_View_Student_Details.Name = "dgv_View_Student_Details";
            this.dgv_View_Student_Details.ReadOnly = true;
            this.dgv_View_Student_Details.RowTemplate.Height = 24;
            this.dgv_View_Student_Details.Size = new System.Drawing.Size(993, 348);
            this.dgv_View_Student_Details.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_DBDataSet;
            // 
            // student_DBDataSet
            // 
            this.student_DBDataSet.DataSetName = "Student_DBDataSet";
            this.student_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1056, 577);
            this.Controls.Add(this.dgv_View_Student_Details);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_Student_Details);
            this.Name = "frm_View_Student_Details";
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_Details;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_View_Student_Details;
        private Student_DBDataSet student_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}