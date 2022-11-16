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
    public partial class Login : Form
    {
        Function fn = new Function();
        string query;


        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username='" + txt_usrName.Text + "' and pass='" + txt_passwrd.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txt_usrName.UseWaitCursor = true;
                lable_error.Visible = false;

                Dashboard d1 = new Dashboard();
                d1.Show();

            }

            else
            {
                lable_error.Visible = true;
                txt_passwrd.Clear();
                txt_usrName.Clear();
            }

        }

    }
}
