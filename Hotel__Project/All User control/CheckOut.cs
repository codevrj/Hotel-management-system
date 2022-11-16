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
    public partial class CheckOut : UserControl
    {
        Function fn = new Function();
        string query;

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.room_no,rooms.room_type,rooms.bed,rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where chekout = 'NO' ";
            DataSet ds=fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }

        private void txt__name_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.room_no,rooms.room_type,rooms.bed,rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where cname like '" + txt__name.Text + "%' and chekout = 'NO' ";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }

        int id;
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_name.Text = datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_roomNo.Text = datagrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        public void clearAll()
        {
            txt__name.Clear();
            txt_name.Clear();
            txt_roomNo.Clear();
            picker_checkout.ResetText();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if(txt_name.Text!="")
            {
                if(MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    string cdate = picker_checkout.Text;
                    query = "update customer set chekout = 'YES',checkout=' "+cdate+"' where cid="+id+" update rooms set booked='NO' where room_no='"+txt_roomNo.Text+"'";
                    fn.setData(query,"Check Out Successfully.");
                    CheckOut_Load(this, null);

                    clearAll();
                }
            }

            else
            {
                MessageBox.Show("No Customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
