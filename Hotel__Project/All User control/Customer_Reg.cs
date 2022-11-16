using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel__Project.All_User_control
{
    public partial class Customer_Reg : UserControl
    {
        Function fn = new Function();
        string query;

        public Customer_Reg()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        public void clearAll()
        {
            txt_name.Clear();
            txt_mobNo.Clear();
            txt_nationlty.Clear();
            cmb_gender.SelectedIndex = -1;
            picker_dob.ResetText();
            txt_idproof.Clear();
            txt_adress.Clear();
            picker_checkin.ResetText();
            cmb_Btype.SelectedIndex = -1;
            cmb_Rtype.SelectedIndex = -1;
            cmb_roomNo.Items.Clear();
            txt_price_.ResetText();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btn_Allote_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_mobNo.Text != "" && txt_nationlty.Text != "" && cmb_gender.Text != "" && picker_dob.Text != "" && txt_idproof.Text != "" && txt_adress.Text != "" && picker_checkin.Text != "")
            {
              try
                {
                    string name , mobile,nationality, gender,dob,id,address,checkin;                   
                    name = txt_name.Text;
                    mobile = txt_mobNo.Text;
                    nationality = txt_nationlty.Text;
                    gender = cmb_gender.Text;
                    dob = picker_dob.Text;
                    id = txt_idproof.Text;
                    address = txt_adress.Text;
                    checkin = picker_checkin.Text;

                    if (txt_name.Text.Any(char.IsDigit) || txt_name.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show(" The Name field cannot have numbers & special charactors.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_mobNo.Text.Any(char.IsSymbol) || txt_mobNo.Text.Any(char.IsLetter))
                    {
                        MessageBox.Show(" Mobile No Cannot have any letters or charactors.Check again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((txt_mobNo.Text.Length != 10))
                    {
                        MessageBox.Show(" Mobile No: must have 10 numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_nationlty.Text.Any(char.IsDigit) || txt_nationlty.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("This field cannot have Numbers & special charactors.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_idproof.Text.Any(char.IsLetter)||(txt_idproof.Text.Length!=12)||txt_idproof.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show(" Please check ID number again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "insert into customer(cname,mobile,nationality,gender,dob,idproof,addres,checkin,room_id) values ('" + name + "','" + mobile + "','" + nationality + "','" + gender + "','" + dob + "','" + id + "','" + address + "','" + checkin + "'," + rid + ") update rooms set booked='YES' where room_no='" + cmb_roomNo.Text + "'";
                        fn.setData(query, "Room No:" + cmb_roomNo.Text + " Allocation Successful");

                        clearAll();
                    }

                }

                catch(FormatException)
                {
                    MessageBox.Show("Invalid Inputs!!!,Check Again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch(SqlException)
                {
                    MessageBox.Show("Database Error!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Check Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("You should fill all fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        int rid;

        private void cmb_Btype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Rtype.SelectedIndex = -1;
            cmb_roomNo.Items.Clear();
            txt_price_.Text="";
        }

        private void cmb_Rtype_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmb_roomNo.Items.Clear();
            txt_price_.Text = "";
            query = "select room_no from rooms where bed='" + cmb_Btype.Text + "'and room_type='" + cmb_Rtype.Text + "'and booked='NO' ";
            setComboBox(query, cmb_roomNo);

        }

        private void cmb_roomNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            query = "select price,room_id from rooms where room_no='" + cmb_roomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txt_price_.Text = ("Rs:"+ds.Tables[0].Rows[0][0].ToString()+"/=");

            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void Customer_Reg_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
