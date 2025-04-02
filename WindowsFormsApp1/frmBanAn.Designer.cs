namespace WindowsFormsApp1
{
    partial class frmBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanAn));
            this.dgBanAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgcMaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnChonBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnPictureAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBanAn
            // 
            this.dgBanAn.AllowUserToAddRows = false;
            this.dgBanAn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgBanAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBanAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBanAn.ColumnHeadersHeight = 19;
            this.dgBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaBA,
            this.dgcTen,
            this.dgcTrangThai,
            this.dgcEdit,
            this.dgcDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBanAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgBanAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.Location = new System.Drawing.Point(22, 128);
            this.dgBanAn.Name = "dgBanAn";
            this.dgBanAn.ReadOnly = true;
            this.dgBanAn.RowHeadersVisible = false;
            this.dgBanAn.RowHeadersWidth = 51;
            this.dgBanAn.RowTemplate.Height = 30;
            this.dgBanAn.Size = new System.Drawing.Size(685, 285);
            this.dgBanAn.TabIndex = 22;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgBanAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgBanAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBanAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBanAn.ThemeStyle.HeaderStyle.Height = 19;
            this.dgBanAn.ThemeStyle.ReadOnly = true;
            this.dgBanAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBanAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBanAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBanAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgBanAn.ThemeStyle.RowsStyle.Height = 30;
            this.dgBanAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBanAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBanAn_CellClick);
            this.dgBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBanAn_CellClick);
            // 
            // dgcMaBA
            // 
            this.dgcMaBA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcMaBA.Frozen = true;
            this.dgcMaBA.HeaderText = "Mã BA";
            this.dgcMaBA.MinimumWidth = 6;
            this.dgcMaBA.Name = "dgcMaBA";
            this.dgcMaBA.ReadOnly = true;
            this.dgcMaBA.Width = 228;
            // 
            // dgcTen
            // 
            this.dgcTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcTen.Frozen = true;
            this.dgcTen.HeaderText = "Tên BA";
            this.dgcTen.MinimumWidth = 6;
            this.dgcTen.Name = "dgcTen";
            this.dgcTen.ReadOnly = true;
            this.dgcTen.Width = 179;
            // 
            // dgcTrangThai
            // 
            this.dgcTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcTrangThai.Frozen = true;
            this.dgcTrangThai.HeaderText = "Trạng Thái";
            this.dgcTrangThai.MinimumWidth = 6;
            this.dgcTrangThai.Name = "dgcTrangThai";
            this.dgcTrangThai.ReadOnly = true;
            this.dgcTrangThai.Width = 178;
            // 
            // dgcEdit
            // 
            this.dgcEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgcEdit.FillWeight = 50F;
            this.dgcEdit.HeaderText = "";
            this.dgcEdit.Image = global::WindowsFormsApp1.Properties.Resources.edit;
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
            this.dgcDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.dgcDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcDelete.MinimumWidth = 50;
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Width = 50;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(22, 112);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(685, 10);
            this.guna2Separator1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bàn Ăn";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.edit;
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
            this.dataGridViewImageColumn2.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // btnChonBan
            // 
            this.btnChonBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonBan.FillColor = System.Drawing.Color.DarkGreen;
            this.btnChonBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonBan.ForeColor = System.Drawing.Color.White;
            this.btnChonBan.Image = global::WindowsFormsApp1.Properties.Resources.choice;
            this.btnChonBan.Location = new System.Drawing.Point(469, 456);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(180, 45);
            this.btnChonBan.TabIndex = 23;
            this.btnChonBan.Text = "Chọn bàn";
            this.btnChonBan.Click += new System.EventHandler(this.btnChonBan_Click);
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnPictureAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPictureAdd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPictureAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPictureAdd.Image")));
            this.btnPictureAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPictureAdd.ImageRotate = 0F;
            this.btnPictureAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPictureAdd.Location = new System.Drawing.Point(22, 52);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPictureAdd.Size = new System.Drawing.Size(64, 54);
            this.btnPictureAdd.TabIndex = 19;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // frmBanAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 524);
            this.Controls.Add(this.btnChonBan);
            this.Controls.Add(this.dgBanAn);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnPictureAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanAn";
            this.Load += new System.EventHandler(this.frmBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBanAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btnPictureAdd;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DataGridView dgBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTrangThai;
        private System.Windows.Forms.DataGridViewImageColumn dgcEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgcDelete;
        private Guna.UI2.WinForms.Guna2Button btnChonBan;
    }
}