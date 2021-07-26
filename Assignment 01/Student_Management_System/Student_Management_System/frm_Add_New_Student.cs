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

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();

            obj.Show();

            this.Hide();
        }


        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();
            this.Hide();

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_ID.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_Department.Text != "")
            {

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details(ID,Name,DOB,Department) Values (@S_ID,@S_Name,@S_DOB,@S_Department)";
                Cmd.Parameters.Add("S_ID", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("S_Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Department", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Succesfully...!", "Success", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Incomplete Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_ID.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "";
            cmb_Department.Text = "";

            Con_Close();
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {

        }
    }

        
}
