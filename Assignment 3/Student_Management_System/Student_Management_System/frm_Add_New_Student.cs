using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Department.Text = "";

            tb_ID.Focus();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MDI_Student_Management_System Obj = new MDI_Student_Management_System();

            Obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login Obj = new Frm_Login();

            Obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_Department.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details (Id,Name,DOB,Department)Values(@S_ID,@S_Name,@S_DOB,@S_Department)";

                Cmd.Parameters.Add("S_ID", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("S_Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Department", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Succesfully...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();

            }

            else
            {
                MessageBox.Show("Incomplete Informatin...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Clear_Controls();
        }





    }
}
