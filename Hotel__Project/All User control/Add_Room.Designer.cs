
namespace Hotel__Project.All_User_control
{
    partial class Add_Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datagrid_view = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_Rnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_Rtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_Btype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Addroom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_price_ = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1241, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1241, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1245, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bed Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1245, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // Datagrid_view
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Datagrid_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Datagrid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagrid_view.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Datagrid_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Datagrid_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Datagrid_view.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.Datagrid_view.EnableHeadersVisualStyles = false;
            this.Datagrid_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view.Location = new System.Drawing.Point(170, 160);
            this.Datagrid_view.Name = "Datagrid_view";
            this.Datagrid_view.RowHeadersVisible = false;
            this.Datagrid_view.RowHeadersWidth = 56;
            this.Datagrid_view.RowTemplate.Height = 24;
            this.Datagrid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_view.Size = new System.Drawing.Size(888, 439);
            this.Datagrid_view.TabIndex = 5;
            this.Datagrid_view.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Datagrid_view.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagrid_view.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagrid_view.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datagrid_view.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagrid_view.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_view.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagrid_view.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagrid_view.ThemeStyle.HeaderStyle.Height = 4;
            this.Datagrid_view.ThemeStyle.ReadOnly = false;
            this.Datagrid_view.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Datagrid_view.ThemeStyle.RowsStyle.Height = 24;
            this.Datagrid_view.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txt_Rnumber
            // 
            this.txt_Rnumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_Rnumber.BorderColor = System.Drawing.Color.Black;
            this.txt_Rnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Rnumber.DefaultText = "";
            this.txt_Rnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Rnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Rnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Rnumber.DisabledState.Parent = this.txt_Rnumber;
            this.txt_Rnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Rnumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Rnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Rnumber.FocusedState.Parent = this.txt_Rnumber;
            this.txt_Rnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rnumber.ForeColor = System.Drawing.Color.Black;
            this.txt_Rnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Rnumber.HoverState.Parent = this.txt_Rnumber;
            this.txt_Rnumber.Location = new System.Drawing.Point(1246, 203);
            this.txt_Rnumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Rnumber.Name = "txt_Rnumber";
            this.txt_Rnumber.PasswordChar = '\0';
            this.txt_Rnumber.PlaceholderText = "";
            this.txt_Rnumber.SelectedText = "";
            this.txt_Rnumber.ShadowDecoration.Parent = this.txt_Rnumber;
            this.txt_Rnumber.Size = new System.Drawing.Size(337, 44);
            this.txt_Rnumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Rnumber.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.Location = new System.Drawing.Point(1627, 973);
            this.txt_price.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(463, 56);
            this.txt_price.TabIndex = 7;
            // 
            // cmb_Rtype
            // 
            this.cmb_Rtype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Rtype.BorderColor = System.Drawing.Color.Black;
            this.cmb_Rtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Rtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rtype.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Rtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Rtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Rtype.FocusedState.Parent = this.cmb_Rtype;
            this.cmb_Rtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.cmb_Rtype.ForeColor = System.Drawing.Color.Black;
            this.cmb_Rtype.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Rtype.HoverState.Parent = this.cmb_Rtype;
            this.cmb_Rtype.ItemHeight = 30;
            this.cmb_Rtype.Items.AddRange(new object[] {
            "AC",
            "Non AC"});
            this.cmb_Rtype.ItemsAppearance.Parent = this.cmb_Rtype;
            this.cmb_Rtype.Location = new System.Drawing.Point(1246, 315);
            this.cmb_Rtype.Name = "cmb_Rtype";
            this.cmb_Rtype.ShadowDecoration.Parent = this.cmb_Rtype;
            this.cmb_Rtype.Size = new System.Drawing.Size(337, 36);
            this.cmb_Rtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_Rtype.TabIndex = 8;
            // 
            // cmb_Btype
            // 
            this.cmb_Btype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Btype.BorderColor = System.Drawing.Color.Black;
            this.cmb_Btype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Btype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Btype.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Btype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Btype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Btype.FocusedState.Parent = this.cmb_Btype;
            this.cmb_Btype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Btype.ForeColor = System.Drawing.Color.Black;
            this.cmb_Btype.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Btype.HoverState.Parent = this.cmb_Btype;
            this.cmb_Btype.ItemHeight = 30;
            this.cmb_Btype.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.cmb_Btype.ItemsAppearance.Parent = this.cmb_Btype;
            this.cmb_Btype.Location = new System.Drawing.Point(1246, 434);
            this.cmb_Btype.Name = "cmb_Btype";
            this.cmb_Btype.ShadowDecoration.Parent = this.cmb_Btype;
            this.cmb_Btype.Size = new System.Drawing.Size(337, 36);
            this.cmb_Btype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_Btype.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_clear.BorderRadius = 25;
            this.btn_clear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Transparent;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(1214, 662);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(150, 53);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Addroom
            // 
            this.btn_Addroom.Animated = true;
            this.btn_Addroom.AutoRoundedCorners = true;
            this.btn_Addroom.BackColor = System.Drawing.Color.Transparent;
            this.btn_Addroom.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Addroom.BorderRadius = 25;
            this.btn_Addroom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Addroom.BorderThickness = 1;
            this.btn_Addroom.CheckedState.Parent = this.btn_Addroom;
            this.btn_Addroom.CustomImages.Parent = this.btn_Addroom;
            this.btn_Addroom.FillColor = System.Drawing.Color.Transparent;
            this.btn_Addroom.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold);
            this.btn_Addroom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Addroom.HoverState.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Addroom.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_Addroom.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Addroom.HoverState.Parent = this.btn_Addroom;
            this.btn_Addroom.Location = new System.Drawing.Point(1473, 662);
            this.btn_Addroom.Name = "btn_Addroom";
            this.btn_Addroom.ShadowDecoration.Parent = this.btn_Addroom;
            this.btn_Addroom.Size = new System.Drawing.Size(142, 53);
            this.btn_Addroom.TabIndex = 11;
            this.btn_Addroom.Text = "Add Room";
            this.btn_Addroom.Click += new System.EventHandler(this.btn_Addroom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_price_
            // 
            this.txt_price_.BackColor = System.Drawing.Color.Transparent;
            this.txt_price_.BorderColor = System.Drawing.Color.Black;
            this.txt_price_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price_.DefaultText = "";
            this.txt_price_.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price_.DisabledState.Parent = this.txt_price_;
            this.txt_price_.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price_.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_price_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price_.FocusedState.Parent = this.txt_price_;
            this.txt_price_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price_.ForeColor = System.Drawing.Color.Black;
            this.txt_price_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price_.HoverState.Parent = this.txt_price_;
            this.txt_price_.Location = new System.Drawing.Point(1246, 555);
            this.txt_price_.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_price_.Name = "txt_price_";
            this.txt_price_.PasswordChar = '\0';
            this.txt_price_.PlaceholderText = "";
            this.txt_price_.SelectedText = "";
            this.txt_price_.ShadowDecoration.Parent = this.txt_price_;
            this.txt_price_.Size = new System.Drawing.Size(337, 44);
            this.txt_price_.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_price_.TabIndex = 12;
            // 
            // Add_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_price_);
            this.Controls.Add(this.btn_Addroom);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_Btype);
            this.Controls.Add(this.cmb_Rtype);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_Rnumber);
            this.Controls.Add(this.Datagrid_view);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Add_Room";
            this.Size = new System.Drawing.Size(1809, 785);
            this.Load += new System.EventHandler(this.Add_Room_Load);
            this.Enter += new System.EventHandler(this.Add_Room_Enter);
            this.Leave += new System.EventHandler(this.Add_Room_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView Datagrid_view;
        private Guna.UI2.WinForms.Guna2TextBox txt_Rnumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Rtype;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Btype;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_Addroom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_price_;
    }
}
