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
using System.Text.RegularExpressions;


namespace Hotel__Project
{
    public partial class Employee : UserControl
    {
        Function fn = new Function();
        string query;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            getMax();
        }

        public void clearAll()
        {
            txt_name.Clear();
            txt_mobile.Clear();
            cmb_gender.SelectedIndex = -1;
            txt_email.Clear();
            txt_usrname.Clear();
            txt_pass.Clear();
            txt_confpass.Clear();
        }

        public void setEmpReport(DataGridView dgv)// DatagridView method.
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];           
        }   

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txt_name.Text!="" && txt_mobile.Text!="" && cmb_gender.Text!=""&& txt_email.Text!=""&&txt_usrname.Text!=""&&txt_pass.Text!=""&&txt_confpass.Text!="")
            {
                try
                {
                    string name, gender, email, username, pass;
                    name = txt_name.Text;
                    Int64 mno =Int64.Parse(txt_mobile.Text);
                    gender = cmb_gender.Text;
                    email = txt_email.Text;
                    username = txt_usrname.Text;
                    pass = txt_pass.Text;

                    if (txt_name.Text.Any(char.IsDigit) || txt_name.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show(" The Name field cannot have numbers & special charactors.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_mobile.Text.Any(char.IsSymbol)||txt_mobile.Text.Any(char.IsLetter))
                    {
                        MessageBox.Show(" Mobile No Cannot have any letters or charactors.Check again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if((txt_mobile.Text.Length != 10))
                    {
                        MessageBox.Show(" Mobile No: Should '10' numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    {
                        MessageBox.Show(" E-mail check again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_usrname.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("This field cannot have any special charactors.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_pass.Text.Length != 8)
                    {
                        MessageBox.Show("You should enter a password containing 8 charactors..", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(txt_pass.Text!=txt_confpass.Text)
                    {
                        MessageBox.Show("You should enter confirm password same as password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "insert into employee(ename,mobile,gender,email,username,pass) values('" + name + "','" + mno + "','" + gender + "','" + email + "','" + username + "','" + pass + "')";
                        fn.setData(query, "Employee Registered");

                        clearAll();
                        getMax();
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Inputs,Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Check Again!", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }   

            else
            {
                MessageBox.Show("You should fill all fields.", "Warning...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void Employee_detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Employee_detail.SelectedIndex == 1)
            {
                setEmpReport(datagridEmp);
            }
            else if (Employee_detail.SelectedIndex == 2)
            {
                setEmpReport(datagrid_del_Emp);
            }

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_EmpID.Text!="")
            {
                try
                {
                    if (MessageBox.Show("Are You sure delete this?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        query = "delete from employee where eid=" + txt_EmpID.Text + "";
                        fn.setData(query, "Record Deleted.");
                        Employee_detail_SelectedIndexChanged(this, null);
                    }
                
                }
                catch(SqlException)
                {
                    MessageBox.Show("Database Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                MessageBox.Show(" ID was not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void getMax()
        {
            query = "select max (eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 01).ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
