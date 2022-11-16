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
    public partial class REPORTS : Form
    {
        public REPORTS()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Creport_Click(object sender, EventArgs e)
        {
            Cus_report o1 = new Cus_report();
            o1.Show();
                
        }

        private void btn_Ereport_Click(object sender, EventArgs e)
        {

        }
    }
}
