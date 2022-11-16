
namespace Hotel__Project
{
    partial class SMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTonum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_messege = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Animated = true;
            this.btn_send.AutoRoundedCorners = true;
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_send.BorderRadius = 20;
            this.btn_send.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_send.BorderThickness = 1;
            this.btn_send.CheckedState.Parent = this.btn_send;
            this.btn_send.CustomImages.Parent = this.btn_send;
            this.btn_send.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_send.Font = new System.Drawing.Font("Segoe UI Semibold", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_send.HoverState.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_send.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_send.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.Parent = this.btn_send;
            this.btn_send.Location = new System.Drawing.Point(657, 502);
            this.btn_send.Name = "btn_send";
            this.btn_send.ShadowDecoration.Parent = this.btn_send;
            this.btn_send.Size = new System.Drawing.Size(142, 43);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "SEND";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.BorderRadius = 20;
            this.btn_clear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_clear.HoverState.CustomBorderColor = System.Drawing.SystemColors.Desktop;
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btn_clear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(280, 502);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(142, 43);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Messege:";
            // 
            // txtTonum
            // 
            this.txtTonum.Animated = true;
            this.txtTonum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTonum.DefaultText = "";
            this.txtTonum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTonum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTonum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTonum.DisabledState.Parent = this.txtTonum;
            this.txtTonum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTonum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTonum.FocusedState.Parent = this.txtTonum;
            this.txtTonum.ForeColor = System.Drawing.Color.Black;
            this.txtTonum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTonum.HoverState.Parent = this.txtTonum;
            this.txtTonum.Location = new System.Drawing.Point(169, 89);
            this.txtTonum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTonum.Name = "txtTonum";
            this.txtTonum.PasswordChar = '\0';
            this.txtTonum.PlaceholderText = "";
            this.txtTonum.SelectedText = "";
            this.txtTonum.ShadowDecoration.Parent = this.txtTonum;
            this.txtTonum.Size = new System.Drawing.Size(320, 46);
            this.txtTonum.TabIndex = 16;
            // 
            // txt_messege
            // 
            this.txt_messege.Animated = true;
            this.txt_messege.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_messege.DefaultText = "";
            this.txt_messege.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_messege.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_messege.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_messege.DisabledState.Parent = this.txt_messege;
            this.txt_messege.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_messege.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_messege.FocusedState.Parent = this.txt_messege;
            this.txt_messege.ForeColor = System.Drawing.Color.Black;
            this.txt_messege.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_messege.HoverState.Parent = this.txt_messege;
            this.txt_messege.Location = new System.Drawing.Point(169, 168);
            this.txt_messege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_messege.Name = "txt_messege";
            this.txt_messege.PasswordChar = '\0';
            this.txt_messege.PlaceholderText = "";
            this.txt_messege.SelectedText = "";
            this.txt_messege.ShadowDecoration.Parent = this.txt_messege;
            this.txt_messege.Size = new System.Drawing.Size(726, 294);
            this.txt_messege.TabIndex = 17;
            // 
            // txtPort
            // 
            this.txtPort.Animated = true;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultText = "";
            this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.DisabledState.Parent = this.txtPort;
            this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.FocusedState.Parent = this.txtPort;
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.HoverState.Parent = this.txtPort;
            this.txtPort.Location = new System.Drawing.Point(628, 89);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PlaceholderText = "";
            this.txtPort.SelectedText = "";
            this.txtPort.ShadowDecoration.Parent = this.txtPort;
            this.txtPort.Size = new System.Drawing.Size(267, 46);
            this.txtPort.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port";
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1060, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txt_messege);
            this.Controls.Add(this.txtTonum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SMS";
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_send;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTonum;
        private Guna.UI2.WinForms.Guna2TextBox txt_messege;
        private Guna.UI2.WinForms.Guna2TextBox txtPort;
        private System.Windows.Forms.Label label3;
    }
}