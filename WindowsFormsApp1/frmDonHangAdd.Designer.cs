namespace WindowsFormsApp1
{
    partial class frmDonHangAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaDH = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtThoiGian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // cbMaKH
            // 
            this.cbMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaKH.ItemHeight = 30;
            this.cbMaKH.Location = new System.Drawing.Point(141, 86);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(140, 36);
            this.cbMaKH.TabIndex = 1;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDH.DefaultText = "";
            this.txtMaDH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDH.Location = new System.Drawing.Point(141, 22);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.PlaceholderText = "";
            this.txtMaDH.SelectedText = "";
            this.txtMaDH.Size = new System.Drawing.Size(140, 36);
            this.txtMaDH.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.choice;
            this.btnSave.Location = new System.Drawing.Point(97, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 45);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // cbMaNV
            // 
            this.cbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaNV.ItemHeight = 30;
            this.cbMaNV.Location = new System.Drawing.Point(141, 147);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(140, 36);
            this.cbMaNV.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã nhân viên";
            // 
            // cbMaBan
            // 
            this.cbMaBan.BackColor = System.Drawing.Color.Transparent;
            this.cbMaBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaBan.ItemHeight = 30;
            this.cbMaBan.Location = new System.Drawing.Point(430, 22);
            this.cbMaBan.Name = "cbMaBan";
            this.cbMaBan.Size = new System.Drawing.Size(140, 36);
            this.cbMaBan.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã Bàn";
            // 
            // dtThoiGian
            // 
            this.dtThoiGian.Checked = true;
            this.dtThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtThoiGian.Location = new System.Drawing.Point(430, 86);
            this.dtThoiGian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtThoiGian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtThoiGian.Name = "dtThoiGian";
            this.dtThoiGian.Size = new System.Drawing.Size(200, 36);
            this.dtThoiGian.TabIndex = 30;
            this.dtThoiGian.Value = new System.DateTime(2025, 4, 2, 13, 40, 47, 514);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(430, 147);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(140, 36);
            this.cboTrangThai.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Thời gian đặt";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.DarkGreen;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.choice;
            this.btnClose.Location = new System.Drawing.Point(346, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChonMonAn
            // 
            this.btnChonMonAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonMonAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonMonAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonMonAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonMonAn.FillColor = System.Drawing.Color.DarkGreen;
            this.btnChonMonAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonMonAn.ForeColor = System.Drawing.Color.White;
            this.btnChonMonAn.Image = global::WindowsFormsApp1.Properties.Resources.choice;
            this.btnChonMonAn.Location = new System.Drawing.Point(31, 220);
            this.btnChonMonAn.Name = "btnChonMonAn";
            this.btnChonMonAn.Size = new System.Drawing.Size(143, 45);
            this.btnChonMonAn.TabIndex = 25;
            this.btnChonMonAn.Text = "Chọn món ăn";
            this.btnChonMonAn.Click += new System.EventHandler(this.btnChonMonAn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(427, 234);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(17, 17);
            this.lblTongTien.TabIndex = 31;
            this.lblTongTien.Text = "...";
            // 
            // frmDonHangAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtThoiGian);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChonMonAn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonHangAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonHangAdd";
            this.Load += new System.EventHandler(this.frmDonHangAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDH;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNV;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaBan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtThoiGian;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnChonMonAn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTongTien;
    }
}