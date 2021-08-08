namespace Student_Management_System
{
    partial class Frm_Login
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(308, 425);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(141, 47);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Login.Location = new System.Drawing.Point(284, 30);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(204, 78);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(179, 193);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(153, 32);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(179, 311);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(147, 32);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(409, 203);
            this.tb_Username.MaxLength = 30;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(276, 30);
            this.tb_Username.TabIndex = 4;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(409, 321);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(276, 30);
            this.tb_Password.TabIndex = 5;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(865, 514);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
    }
}