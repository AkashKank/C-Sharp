using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_DBDataSet.Student_Details);

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
    }
}
