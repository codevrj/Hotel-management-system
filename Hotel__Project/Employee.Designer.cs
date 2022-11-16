
namespace Hotel__Project
{
    partial class Employee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Employee_detail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_usrname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelToSet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emp_details = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.datagridEmp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.txt_EmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datagrid_del_Emp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_confpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Employee_detail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.emp_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEmp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_del_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee";
            // 
            // Employee_detail
            // 
            this.Employee_detail.Controls.Add(this.tabPage1);
            this.Employee_detail.Controls.Add(this.emp_details);
            this.Employee_detail.Controls.Add(this.tabPage3);
            this.Employee_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_detail.Location = new System.Drawing.Point(18, 78);
            this.Employee_detail.Name = "Employee_detail";
            this.Employee_detail.SelectedIndex = 0;
            this.Employee_detail.Size = new System.Drawing.Size(1769, 692);
            this.Employee_detail.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Employee_detail.TabIndex = 4;
            this.Employee_detail.SelectedIndexChanged += new System.EventHandler(this.Employee_detail_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.txt_confpass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.btn_register);
            this.tabPage1.Controls.Add(this.txt_pass);
            this.tabPage1.Controls.Add(this.txt_usrname);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cmb_gender);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_mobile);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelToSet);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1761, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Registration";
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_clear.BorderRadius = 20;
            this.btn_clear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.btn_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(1117, 546);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(145, 43);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseTransparentBackground = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.Animated = true;
            this.btn_register.AutoRoundedCorners = true;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_register.BorderRadius = 20;
            this.btn_register.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_register.BorderThickness = 1;
            this.btn_register.CheckedState.Parent = this.btn_register;
            this.btn_register.CustomImages.Parent = this.btn_register;
            this.btn_register.FillColor = System.Drawing.Color.Transparent;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_register.HoverState.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_register.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_register.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_register.HoverState.Parent = this.btn_register;
            this.btn_register.Location = new System.Drawing.Point(1396, 546);
            this.btn_register.Name = "btn_register";
            this.btn_register.ShadowDecoration.Parent = this.btn_register;
            this.btn_register.Size = new System.Drawing.Size(145, 43);
            this.btn_register.TabIndex = 17;
            this.btn_register.Text = "Register";
            this.btn_register.UseTransparentBackground = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.Parent = this.txt_pass;
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedState.Parent = this.txt_pass;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.HoverState.Parent = this.txt_pass;
            this.txt_pass.Location = new System.Drawing.Point(1167, 341);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '°';
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.ShadowDecoration.Parent = this.txt_pass;
            this.txt_pass.Size = new System.Drawing.Size(337, 44);
            this.txt_pass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_pass.TabIndex = 16;
            // 
            // txt_usrname
            // 
            this.txt_usrname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usrname.DefaultText = "";
            this.txt_usrname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_usrname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_usrname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usrname.DisabledState.Parent = this.txt_usrname;
            this.txt_usrname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usrname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usrname.FocusedState.Parent = this.txt_usrname;
            this.txt_usrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usrname.ForeColor = System.Drawing.Color.Black;
            this.txt_usrname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usrname.HoverState.Parent = this.txt_usrname;
            this.txt_usrname.Location = new System.Drawing.Point(1167, 235);
            this.txt_usrname.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.PasswordChar = '\0';
            this.txt_usrname.PlaceholderText = "";
            this.txt_usrname.SelectedText = "";
            this.txt_usrname.ShadowDecoration.Parent = this.txt_usrname;
            this.txt_usrname.Size = new System.Drawing.Size(337, 44);
            this.txt_usrname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_usrname.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(958, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(958, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "User Name";
            // 
            // cmb_gender
            // 
            this.cmb_gender.BackColor = System.Drawing.Color.Transparent;
            this.cmb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_gender.FocusedState.Parent = this.cmb_gender;
            this.cmb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.cmb_gender.ForeColor = System.Drawing.Color.Black;
            this.cmb_gender.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_gender.HoverState.Parent = this.cmb_gender;
            this.cmb_gender.ItemHeight = 30;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.ItemsAppearance.Parent = this.cmb_gender;
            this.cmb_gender.Location = new System.Drawing.Point(377, 450);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.ShadowDecoration.Parent = this.cmb_gender;
            this.cmb_gender.Size = new System.Drawing.Size(337, 36);
            this.cmb_gender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_gender.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(377, 545);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "Enter e-mail address";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(337, 44);
            this.txt_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_email.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-mail";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mobile.DefaultText = "";
            this.txt_mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobile.DisabledState.Parent = this.txt_mobile;
            this.txt_mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobile.FocusedState.Parent = this.txt_mobile;
            this.txt_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.ForeColor = System.Drawing.Color.Black;
            this.txt_mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mobile.HoverState.Parent = this.txt_mobile;
            this.txt_mobile.Location = new System.Drawing.Point(377, 341);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.PasswordChar = '\0';
            this.txt_mobile.PlaceholderText = "Enter Contact Number";
            this.txt_mobile.SelectedText = "";
            this.txt_mobile.ShadowDecoration.Parent = this.txt_mobile;
            this.txt_mobile.Size = new System.Drawing.Size(337, 44);
            this.txt_mobile.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_mobile.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.Parent = this.txt_name;
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.FocusedState.Parent = this.txt_name;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.HoverState.Parent = this.txt_name;
            this.txt_name.Location = new System.Drawing.Point(377, 235);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "Enter full name";
            this.txt_name.SelectedText = "";
            this.txt_name.ShadowDecoration.Parent = this.txt_name;
            this.txt_name.Size = new System.Drawing.Size(337, 44);
            this.txt_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(242, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mobile No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(242, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(242, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // labelToSet
            // 
            this.labelToSet.AutoSize = true;
            this.labelToSet.BackColor = System.Drawing.Color.Black;
            this.labelToSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToSet.ForeColor = System.Drawing.Color.Red;
            this.labelToSet.Location = new System.Drawing.Point(289, 145);
            this.labelToSet.Name = "labelToSet";
            this.labelToSet.Size = new System.Drawing.Size(31, 29);
            this.labelToSet.TabIndex = 1;
            this.labelToSet.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID -";
            // 
            // emp_details
            // 
            this.emp_details.Controls.Add(this.label10);
            this.emp_details.Controls.Add(this.datagridEmp);
            this.emp_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_details.ForeColor = System.Drawing.Color.Black;
            this.emp_details.Location = new System.Drawing.Point(4, 29);
            this.emp_details.Name = "emp_details";
            this.emp_details.Padding = new System.Windows.Forms.Padding(3);
            this.emp_details.Size = new System.Drawing.Size(1761, 659);
            this.emp_details.TabIndex = 1;
            this.emp_details.Text = "Employee Details";
            this.emp_details.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(744, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 37);
            this.label10.TabIndex = 7;
            this.label10.Text = "Employee Details";
            // 
            // datagridEmp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEmp.BackgroundColor = System.Drawing.Color.White;
            this.datagridEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridEmp.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridEmp.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridEmp.EnableHeadersVisualStyles = false;
            this.datagridEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridEmp.Location = new System.Drawing.Point(75, 117);
            this.datagridEmp.Name = "datagridEmp";
            this.datagridEmp.RowHeadersVisible = false;
            this.datagridEmp.RowHeadersWidth = 56;
            this.datagridEmp.RowTemplate.Height = 24;
            this.datagridEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEmp.Size = new System.Drawing.Size(1612, 472);
            this.datagridEmp.TabIndex = 6;
            this.datagridEmp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagridEmp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridEmp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridEmp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridEmp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridEmp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridEmp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridEmp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridEmp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridEmp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridEmp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridEmp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridEmp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridEmp.ThemeStyle.HeaderStyle.Height = 4;
            this.datagridEmp.ThemeStyle.ReadOnly = false;
            this.datagridEmp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridEmp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridEmp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridEmp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridEmp.ThemeStyle.RowsStyle.Height = 24;
            this.datagridEmp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridEmp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_delete);
            this.tabPage3.Controls.Add(this.txt_EmpID);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.datagrid_del_Emp);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1761, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BorderRadius = 20;
            this.btn_delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.HoverState.CustomBorderColor = System.Drawing.Color.Crimson;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(1101, 162);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(145, 43);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseTransparentBackground = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Animated = true;
            this.txt_EmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmpID.DefaultText = "";
            this.txt_EmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmpID.DisabledState.Parent = this.txt_EmpID;
            this.txt_EmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmpID.FocusedState.Parent = this.txt_EmpID;
            this.txt_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F);
            this.txt_EmpID.ForeColor = System.Drawing.Color.Black;
            this.txt_EmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmpID.HoverState.Parent = this.txt_EmpID;
            this.txt_EmpID.Location = new System.Drawing.Point(710, 162);
            this.txt_EmpID.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.PasswordChar = '\0';
            this.txt_EmpID.PlaceholderText = "Enter ID";
            this.txt_EmpID.SelectedText = "";
            this.txt_EmpID.ShadowDecoration.Parent = this.txt_EmpID;
            this.txt_EmpID.Size = new System.Drawing.Size(337, 44);
            this.txt_EmpID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_EmpID.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(775, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 37);
            this.label11.TabIndex = 9;
            this.label11.Text = "Delete Employee ";
            // 
            // datagrid_del_Emp
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_del_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_del_Emp.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_del_Emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_del_Emp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_del_Emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_del_Emp.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_del_Emp.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_del_Emp.EnableHeadersVisualStyles = false;
            this.datagrid_del_Emp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_del_Emp.Location = new System.Drawing.Point(79, 239);
            this.datagrid_del_Emp.Name = "datagrid_del_Emp";
            this.datagrid_del_Emp.RowHeadersVisible = false;
            this.datagrid_del_Emp.RowHeadersWidth = 56;
            this.datagrid_del_Emp.RowTemplate.Height = 24;
            this.datagrid_del_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_del_Emp.Size = new System.Drawing.Size(1599, 374);
            this.datagrid_del_Emp.TabIndex = 8;
            this.datagrid_del_Emp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid_del_Emp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_del_Emp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_del_Emp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_del_Emp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_del_Emp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_del_Emp.ThemeStyle.HeaderStyle.Height = 4;
            this.datagrid_del_Emp.ThemeStyle.ReadOnly = false;
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_del_Emp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_confpass
            // 
            this.txt_confpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confpass.DefaultText = "";
            this.txt_confpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confpass.DisabledState.Parent = this.txt_confpass;
            this.txt_confpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confpass.FocusedState.Parent = this.txt_confpass;
            this.txt_confpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confpass.ForeColor = System.Drawing.Color.Black;
            this.txt_confpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confpass.HoverState.Parent = this.txt_confpass;
            this.txt_confpass.Location = new System.Drawing.Point(1167, 442);
            this.txt_confpass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_confpass.Name = "txt_confpass";
            this.txt_confpass.PasswordChar = '°';
            this.txt_confpass.PlaceholderText = "";
            this.txt_confpass.SelectedText = "";
            this.txt_confpass.ShadowDecoration.Parent = this.txt_confpass;
            this.txt_confpass.Size = new System.Drawing.Size(337, 44);
            this.txt_confpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_confpass.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(958, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm Password";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_detail);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1809, 785);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Leave += new System.EventHandler(this.Employee_Leave);
            this.Employee_detail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.emp_details.ResumeLayout(false);
            this.emp_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEmp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_del_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Employee_detail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelToSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage emp_details;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_mobile;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_usrname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridEmp;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmpID;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_del_Emp;
        private Guna.UI2.WinForms.Guna2TextBox txt_confpass;
        private System.Windows.Forms.Label label3;
    }
}
