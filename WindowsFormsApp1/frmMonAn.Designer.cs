namespace WindowsFormsApp1
{
    partial class frmMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonAn));
            this.dgvMonAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgcMaMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnChonMonAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnPictureAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonAn.ColumnHeadersHeight = 40;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaMA,
            this.dgcTen,
            this.dgcGia,
            this.dgcEdit,
            this.dgcDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonAn.Location = new System.Drawing.Point(35, 130);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.RowTemplate.Height = 30;
            this.dgvMonAn.Size = new System.Drawing.Size(685, 285);
            this.dgvMonAn.TabIndex = 16;
            this.dgvMonAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonAn.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMonAn.ThemeStyle.ReadOnly = true;
            this.dgvMonAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonAn.ThemeStyle.RowsStyle.Height = 30;
            this.dgvMonAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // dgcMaMA
            // 
            this.dgcMaMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcMaMA.HeaderText = "Mã MA";
            this.dgcMaMA.MinimumWidth = 6;
            this.dgcMaMA.Name = "dgcMaMA";
            this.dgcMaMA.ReadOnly = true;
            this.dgcMaMA.Width = 228;
            // 
            // dgcTen
            // 
            this.dgcTen.HeaderText = "Tên MA";
            this.dgcTen.MinimumWidth = 6;
            this.dgcTen.Name = "dgcTen";
            this.dgcTen.ReadOnly = true;
            // 
            // dgcGia
            // 
            this.dgcGia.HeaderText = "Giá";
            this.dgcGia.MinimumWidth = 6;
            this.dgcGia.Name = "dgcGia";
            this.dgcGia.ReadOnly = true;
            // 
            // dgcEdit
            // 
            this.dgcEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcEdit.FillWeight = 50F;
            this.dgcEdit.HeaderText = "";
            this.dgcEdit.Image = global::WindowsFormsApp1.Properties.Resources.edit1;
            this.dgcEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcEdit.MinimumWidth = 50;
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Width = 50;
            // 
            // dgcDelete
            // 
            this.dgcDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcDelete.FillWeight = 50F;
            this.dgcDelete.HeaderText = "";
            this.dgcDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete1;
            this.dgcDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcDelete.MinimumWidth = 50;
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Width = 50;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(35, 114);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(685, 10);
            this.guna2Separator1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Món ăn";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoLuong.Location = new System.Drawing.Point(606, 432);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(114, 48);
            this.nudSoLuong.TabIndex = 25;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.edit1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::WindowsFormsApp1.Properties.Resources.delete1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
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
            this.btnChonMonAn.Location = new System.Drawing.Point(396, 435);
            this.btnChonMonAn.Name = "btnChonMonAn";
            this.btnChonMonAn.Size = new System.Drawing.Size(180, 45);
            this.btnChonMonAn.TabIndex = 24;
            this.btnChonMonAn.Text = "Chọn món ăn";
            this.btnChonMonAn.Click += new System.EventHandler(this.btnChonMonAn_Click);
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnPictureAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPictureAdd.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPictureAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPictureAdd.Image")));
            this.btnPictureAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPictureAdd.ImageRotate = 0F;
            this.btnPictureAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPictureAdd.Location = new System.Drawing.Point(35, 54);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPictureAdd.Size = new System.Drawing.Size(64, 54);
            this.btnPictureAdd.TabIndex = 13;
            this.btnPictureAdd.UseTransparentBackground = true;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // frmMonAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 493);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.btnChonMonAn);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnPictureAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonAn";
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGia;
        private System.Windows.Forms.DataGridViewImageColumn dgcEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgcDelete;
        public Guna.UI2.WinForms.Guna2DataGridView dgvMonAn;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2ImageButton btnPictureAdd;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnChonMonAn;
        public Guna.UI2.WinForms.Guna2NumericUpDown nudSoLuong;
    }
}