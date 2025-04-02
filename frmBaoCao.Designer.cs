namespace QuanLyNhaHang
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.btnXuatBC = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnDongTrang = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radSLKH = new System.Windows.Forms.RadioButton();
            this.radDSNV = new System.Windows.Forms.RadioButton();
            this.radDT = new System.Windows.Forms.RadioButton();
            this.radSLDH = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChon = new System.Windows.Forms.Label();
            this.dgvBaoCao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(374, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.radThang);
            this.groupBox2.Controls.Add(this.dtpDen);
            this.groupBox2.Controls.Add(this.dtpTu);
            this.groupBox2.Controls.Add(this.btnXuatBC);
            this.groupBox2.Controls.Add(this.btnBaoCao);
            this.groupBox2.Controls.Add(this.btnDongTrang);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblChon);
            this.groupBox2.Location = new System.Drawing.Point(29, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 326);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(10, 88);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(137, 20);
            this.radNam.TabIndex = 27;
            this.radNam.TabStop = true;
            this.radNam.Text = "Báo cáo theo năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(291, 88);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(144, 20);
            this.radThang.TabIndex = 26;
            this.radThang.TabStop = true;
            this.radThang.Text = "Báo cáo theo tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThang_CheckedChanged);
            // 
            // dtpDen
            // 
            this.dtpDen.Location = new System.Drawing.Point(496, 34);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(200, 22);
            this.dtpDen.TabIndex = 23;
            // 
            // dtpTu
            // 
            this.dtpTu.Location = new System.Drawing.Point(199, 34);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(200, 22);
            this.dtpTu.TabIndex = 22;
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.AutoRoundedCorners = true;
            this.btnXuatBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatBC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatBC.ForeColor = System.Drawing.Color.White;
            this.btnXuatBC.Location = new System.Drawing.Point(755, 260);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.Size = new System.Drawing.Size(180, 45);
            this.btnXuatBC.TabIndex = 21;
            this.btnXuatBC.Text = "Xuất báo cáo";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoRoundedCorners = true;
            this.btnBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(755, 104);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(180, 45);
            this.btnBaoCao.TabIndex = 20;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDongTrang
            // 
            this.btnDongTrang.AutoRoundedCorners = true;
            this.btnDongTrang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTrang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDongTrang.ForeColor = System.Drawing.Color.White;
            this.btnDongTrang.Location = new System.Drawing.Point(755, 177);
            this.btnDongTrang.Name = "btnDongTrang";
            this.btnDongTrang.Size = new System.Drawing.Size(180, 45);
            this.btnDongTrang.TabIndex = 19;
            this.btnDongTrang.Text = "Đóng trang";
            this.btnDongTrang.Click += new System.EventHandler(this.btnDongTrang_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radSLKH);
            this.groupBox3.Controls.Add(this.radDSNV);
            this.groupBox3.Controls.Add(this.radDT);
            this.groupBox3.Controls.Add(this.radSLDH);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(9, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 169);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn loại báo cáo";
            // 
            // radSLKH
            // 
            this.radSLKH.AutoSize = true;
            this.radSLKH.Location = new System.Drawing.Point(298, 124);
            this.radSLKH.Name = "radSLKH";
            this.radSLKH.Size = new System.Drawing.Size(223, 23);
            this.radSLKH.TabIndex = 29;
            this.radSLKH.TabStop = true;
            this.radSLKH.Text = "báo cáo số lượng khách hàng";
            this.radSLKH.UseVisualStyleBackColor = true;
            // 
            // radDSNV
            // 
            this.radDSNV.AutoSize = true;
            this.radDSNV.Location = new System.Drawing.Point(298, 44);
            this.radDSNV.Name = "radDSNV";
            this.radDSNV.Size = new System.Drawing.Size(221, 23);
            this.radDSNV.TabIndex = 28;
            this.radDSNV.TabStop = true;
            this.radDSNV.Text = "Báo cáo danh sách nhân viên";
            this.radDSNV.UseVisualStyleBackColor = true;
            // 
            // radDT
            // 
            this.radDT.AutoSize = true;
            this.radDT.Location = new System.Drawing.Point(21, 44);
            this.radDT.Name = "radDT";
            this.radDT.Size = new System.Drawing.Size(151, 23);
            this.radDT.TabIndex = 24;
            this.radDT.TabStop = true;
            this.radDT.Text = "báo cáo doanh thu";
            this.radDT.UseVisualStyleBackColor = true;
            // 
            // radSLDH
            // 
            this.radSLDH.AutoSize = true;
            this.radSLDH.Location = new System.Drawing.Point(21, 112);
            this.radSLDH.Name = "radSLDH";
            this.radSLDH.Size = new System.Drawing.Size(213, 23);
            this.radSLDH.TabIndex = 25;
            this.radSLDH.TabStop = true;
            this.radSLDH.Text = "Báo cáo số lượng đơn hàng";
            this.radSLDH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(438, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(161, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "từ";
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChon.Location = new System.Drawing.Point(6, 34);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(162, 19);
            this.lblChon.TabIndex = 0;
            this.lblChon.Text = "chọn khoảng thời gian:";
            // 
            // dgvBaoCao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBaoCao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.ColumnHeadersHeight = 4;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.GridColor = System.Drawing.Color.Black;
            this.dgvBaoCao.Location = new System.Drawing.Point(29, 96);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.Size = new System.Drawing.Size(974, 252);
            this.dgvBaoCao.TabIndex = 15;
            this.dgvBaoCao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBaoCao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBaoCao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCao.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvBaoCao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBaoCao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBaoCao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvBaoCao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoCao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBaoCao.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBaoCao.ThemeStyle.ReadOnly = false;
            this.dgvBaoCao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvBaoCao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBaoCao.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBaoCao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 729);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnXuatBC;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnDongTrang;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.RadioButton radSLKH;
        private System.Windows.Forms.RadioButton radDSNV;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radDT;
        private System.Windows.Forms.RadioButton radSLDH;
    }
}