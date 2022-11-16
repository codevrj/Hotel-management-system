using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel__Project.All_User_control
{
    public partial class Add_Room : UserControl
    {
        Function fn = new Function();
        string query;

        public Add_Room()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txt_Rnumber.Clear();
            cmb_Rtype.SelectedIndex = -1;
            txt_price_.Clear();
            cmb_Btype.SelectedIndex = -1;
        }

        private void Add_Room_Load(object sender, EventArgs e)
        { 
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            Datagrid_view.DataSource = ds.Tables[0];
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Rnumber.Clear();
            cmb_Rtype.SelectedIndex = -1;
            cmb_Btype.SelectedIndex = -1;
            txt_price_.Clear();
        }

        private void btn_Addroom_Click(object sender, EventArgs e)
        {
            if (txt_Rnumber.Text != "" && cmb_Rtype.Text != "" && cmb_Btype.Text != "" && txt_price_.Text != "")
            {
                try
                {
                    string r_type, B_type;
                    Int64 r_nm, price;
                    r_nm = Int64.Parse(txt_Rnumber.Text);
                    r_type = cmb_Rtype.Text;
                    B_type = cmb_Btype.Text;
                    price = Int64.Parse(txt_price_.Text);

                    query = "insert into rooms (room_no,room_type,bed,price) values ('" + r_nm + "','" + r_type + "','" + B_type + "','" + price + "')";
                    fn.setData(query, "Room No:"+r_nm+" Added");

                    Add_Room_Load(this, null);
                    clearAll();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Inputs Check Again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                catch(SqlException)
                {
                    MessageBox.Show("Database error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                catch(Exception)
                {
                    MessageBox.Show("Please Check Again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
                }

            }

            else
            {
                MessageBox.Show("Please Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_Room_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        private void Add_Room_Enter(object sender, EventArgs e)
        {
            Add_Room_Load(this, null);
        }
    }
}