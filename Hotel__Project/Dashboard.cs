using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel__Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_cusReg_Click(object sender, EventArgs e)
        {
            moving_pannel.Left = btn_cusReg.Left;
            customer_Reg1.Visible = true;
            customer_Reg1.BringToFront();
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            moving_pannel.Left = btn_addroom.Left;
            add_Room1.Visible = true;
            add_Room1.BringToFront();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            moving_pannel.Left = btn_checkout.Left;
            checkOut1.Visible = true;
            checkOut1.BringToFront();
        }

        private void btn_cusDetails_Click(object sender, EventArgs e)
        {
            moving_pannel.Left = btn_cusDetails.Left;
           customer_details1.Visible = true;
            customer_details1.BringToFront();

            
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            moving_pannel.Left = btn_employee.Left;
            employee1.Visible = true;
            employee1.BringToFront();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void add_Room1_Load(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            add_Room1.Visible = false;
            
            btn_home.PerformClick();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            REPORTS p1 = new REPORTS();
            p1.Show();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {           
            moving_pannel.Left = btn_home.Left;
            home1.Visible = true;
            home1.BringToFront();
        }
    }
}
