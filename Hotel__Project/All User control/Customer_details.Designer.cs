
namespace Hotel__Project.All_User_control
{
    partial class Customer_details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_serchby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datagridCus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(866, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Search By";
            // 
            // cmb_serchby
            // 
            this.cmb_serchby.Animated = true;
            this.cmb_serchby.BackColor = System.Drawing.Color.Transparent;
            this.cmb_serchby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_serchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_serchby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_serchby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_serchby.FocusedState.Parent = this.cmb_serchby;
            this.cmb_serchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.cmb_serchby.ForeColor = System.Drawing.Color.Black;
            this.cmb_serchby.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.cmb_serchby.HoverState.Parent = this.cmb_serchby;
            this.cmb_serchby.ItemHeight = 30;
            this.cmb_serchby.Items.AddRange(new object[] {
            "All Customer details",
            "In Hotel Customer",
            "CheckedOut Customer"});
            this.cmb_serchby.ItemsAppearance.Parent = this.cmb_serchby;
            this.cmb_serchby.Location = new System.Drawing.Point(753, 170);
            this.cmb_serchby.Name = "cmb_serchby";
            this.cmb_serchby.ShadowDecoration.Parent = this.cmb_serchby;
            this.cmb_serchby.Size = new System.Drawing.Size(337, 36);
            this.cmb_serchby.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_serchby.TabIndex = 55;
            this.cmb_serchby.SelectedIndexChanged += new System.EventHandler(this.cmb_serchby_SelectedIndexChanged);
            // 
            // datagridCus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridCus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCus.BackgroundColor = System.Drawing.Color.White;
            this.datagridCus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridCus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridCus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridCus.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridCus.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridCus.EnableHeadersVisualStyles = false;
            this.datagridCus.GridColor = System.Drawing.Color.Gray;
            this.datagridCus.Location = new System.Drawing.Point(59, 244);
            this.datagridCus.Name = "datagridCus";
            this.datagridCus.RowHeadersVisible = false;
            this.datagridCus.RowHeadersWidth = 56;
            this.datagridCus.RowTemplate.Height = 24;
            this.datagridCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCus.Size = new System.Drawing.Size(1689, 490);
            this.datagridCus.TabIndex = 56;
            this.datagridCus.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagridCus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridCus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridCus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridCus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridCus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridCus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridCus.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.datagridCus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridCus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridCus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridCus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridCus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridCus.ThemeStyle.HeaderStyle.Height = 4;
            this.datagridCus.ThemeStyle.ReadOnly = false;
            this.datagridCus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridCus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridCus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridCus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridCus.ThemeStyle.RowsStyle.Height = 24;
            this.datagridCus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridCus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Customer_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagridCus);
            this.Controls.Add(this.cmb_serchby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_details";
            this.Size = new System.Drawing.Size(1809, 785);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_serchby;
        private Guna.UI2.WinForms.Guna2DataGridView datagridCus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
