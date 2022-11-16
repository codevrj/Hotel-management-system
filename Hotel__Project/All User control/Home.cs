using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel__Project.All_User_control
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_SMS_Click(object sender, EventArgs e)
        {
            SMS f1 = new SMS();
            f1.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("****|| Developped by:- Viraj ,Hasindu ,Imalka ,Nipuna ||****", "Hotel C-LEX_v1.0", MessageBoxButtons.OK);
        }
    }
}
