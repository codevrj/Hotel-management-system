using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Ports;
using System.Threading;


namespace Hotel__Project
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();
                sp.PortName = txtPort.Text;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);

                sp.WriteLine("AT+CMGF=1 " + Environment.NewLine);
                Thread.Sleep(100);

                sp.WriteLine("AT+CMGS=\"'" + txtPort.Text+"\'" + Environment.NewLine);
                Thread.Sleep(100);

                sp.WriteLine(txt_messege.Text + Environment.NewLine);
                Thread.Sleep(100);

                sp.Write(new byte[] { 26 }, 0, 1);

                var response = sp.ReadExisting();

                if (response.Contains("Error"))
                    MessageBox.Show("Send failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Message has been sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sp.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtTonum.Clear();
            txtPort.Clear();
            txt_messege.Clear();
        }
    }
}
