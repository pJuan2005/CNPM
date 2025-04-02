using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            frmMonAnAdd frmMa = new frmMonAnAdd();
            frmMa.ShowDialog();
            LoadData(); // Cập nhật danh sách sau khi thêm mới
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            dgvMonAn.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgvMonAn.Columns["dgcMaMA"].DataPropertyName = "MaMon";
            dgvMonAn.Columns["dgcTen"].DataPropertyName = "TenMon";
            dgvMonAn.Columns["dgcGia"].DataPropertyName = "Gia";
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM MonAn";
            DatabaseHelper dbh = new DatabaseHelper();
            dgvMonAn.DataSource = dbh.ExecuteQuery(query);
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvMonAn.Columns[e.ColumnIndex].Name == "dgcEdit")
                {
                    // Lấy dữ liệu từ DataGridView
                    string maMon = dgvMonAn.CurrentRow.Cells["dgcMaMA"].Value.ToString();
                    string tenMon = dgvMonAn.CurrentRow.Cells["dgcTen"].Value.ToString();
                    decimal gia = Convert.ToDecimal(dgvMonAn.CurrentRow.Cells["dgcGia"].Value);

                    // Mở frmMonAnAdd và truyền dữ liệu
                    frmMonAnAdd frm = new frmMonAnAdd();
                    frm.SetMonAnData(maMon, tenMon, gia);
                    frm.ShowDialog(); // Mở form chỉnh sửa
                    LoadData();
                }
                else if (dgvMonAn.Columns[e.ColumnIndex].Name == "dgcDelete")
                {
                    DeleteMonAn();
                }
            }
        }

        

        private void DeleteMonAn()
        {
            Guna2MessageDialog gunaMessageDialog = new Guna2MessageDialog
            {
                Text = "Bạn có chắc muốn xóa món ăn này?",
                Caption = "Xác nhận",
                Buttons = MessageDialogButtons.YesNo,
                Icon = MessageDialogIcon.Warning,
                Style = MessageDialogStyle.Dark,
                Parent = this
            };

            if (gunaMessageDialog.Show() == DialogResult.Yes)
            {
                string ma = dgvMonAn.CurrentRow.Cells["dgcMaMA"].Value.ToString();
                string query = "DELETE FROM MonAn WHERE MaMon = @ma";
                SqlParameter[] parameters = { new SqlParameter("@ma", ma) };

                DatabaseHelper dbh = new DatabaseHelper();
                dbh.ExecuteNonQuery(query, parameters);
                LoadData(); // Cập nhật danh sách sau khi xóa
            }
        }


        public List<ChiTietDonHang> danhSachMon = new List<ChiTietDonHang>();
        private void btnChonMonAn_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                string monAnID = dgvMonAn.SelectedRows[0].Cells["dgcMaMA"].Value.ToString();
                string tenMon = dgvMonAn.SelectedRows[0].Cells["dgcTen"].Value.ToString();
                int soLuong = Convert.ToInt32(nudSoLuong.Value);
                decimal gia = Convert.ToDecimal(dgvMonAn.SelectedRows[0].Cells["dgcGia"].Value);

                danhSachMon.Add(new ChiTietDonHang
                {
                    MonAnID = monAnID,
                    TenMon = tenMon,
                    SoLuong = soLuong,
                    GiaTien = gia,
                    ThanhTien = soLuong * gia
                }); ;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
