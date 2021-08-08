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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
        {
            InitializeComponent();
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

            tb_ID.Enabled = true;
            tb_ID.Focus();
            tb_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Department.Enabled = false;
        }



        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login Obj = new Frm_Login();

            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Student_Details where ID = " + tb_ID.Text + "";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_ID.Enabled = false;
                    tb_Name.Enabled = true;
                    dtp_DOB.Enabled = true;
                    cmb_Department.Enabled = true;

                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    dtp_DOB.Text = (Obj["DOB"].ToString());
                    cmb_Department.Text = Obj.GetString(Obj.GetOrdinal("Department"));
                }

                else
                {
                    MessageBox.Show("No Such Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear_Controls();
                }

                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && cmb_Department.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Student_Details Set Name = @S_Name,DOB = @S_DOB,Department = @S_Department where ID = " + tb_ID.Text + "";

                Cmd.Parameters.Add("S_Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("S_DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("S_Department", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Details Updated Succesfully...!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }

            else
            {
                MessageBox.Show("Incomplete Information", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MDI_Student_Management_System Obj = new MDI_Student_Management_System();

            Obj.Show();
            this.Hide();
        }
    }
}
