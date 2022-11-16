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
    public partial class Customer_details : UserControl
    {
        Function fn = new Function();
        string query;


        public Customer_details()
        {
            InitializeComponent();
        }

        private void cmb_serchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_serchby.SelectedIndex == 0)
            {             
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.room_no,rooms.room_type,rooms.bed,rooms.price from customer inner join rooms on customer.room_id = rooms.room_id";
                getrecords(query);
            }

            else if (cmb_serchby.SelectedIndex == 1)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.room_no,rooms.room_type,rooms.bed,rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where checkout is null";
                getrecords(query);
            }
            else if (cmb_serchby.SelectedIndex == 2)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.room_no,rooms.room_type,rooms.bed,rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where checkout is not null";
                getrecords(query);
            }
        }
        private void getrecords(string query)
        {
            DataSet ds = fn.getData(query);
            datagridCus.DataSource = ds.Tables[0];
        }
    }
}
