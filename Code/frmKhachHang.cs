using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            frmTrangChu trangChu = new frmTrangChu();
            trangChu.Show();
            this.Hide();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM KhachHang";
            DataHelper dataHelper = new DataHelper();
            dataHelper.LoadDataGridView(query, guna2DataGridView1);

            // Cố định hàng đầu tiên
            if (guna2DataGridView1.Rows.Count > 0)
            {
                guna2DataGridView1.Rows[0].Frozen = true;  // Cố định hàng đầu tiên
            }

            // Không cho phép thay đổi kích thước cột
            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                column.Resizable = DataGridViewTriState.False; // Tắt thay đổi kích thước cột
            }

            // Cải thiện khả năng hiển thị và cố định tiêu đề cột
            guna2DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            guna2DataGridView1.ColumnHeadersHeight = 40; // Chiều cao tiêu đề
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim();
            string tenKH = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string ngayDK = dtpNgayDangKy.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Mã và tên khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"INSERT INTO KhachHang (MaKH, TenKH, SDT, Email, NgayDangKy) " +
                           $"VALUES (N'{maKH}', N'{tenKH}', '{sdt}', '{email}', '{ngayDK}')";

            DataHelper dataHelper = new DataHelper();
            dataHelper.ExecuteSQL(query);

            // Cập nhật lại loại khách hàng
            string updateLoaiKHQuery = @"
        UPDATE KH
        SET KH.LoaiKH = 
            CASE 
                WHEN DB.SoLanDatBan >= 10 THEN N'VIP'
                WHEN DB.SoLanDatBan >= 5 THEN N'Thường xuyên'
                WHEN DB.SoLanDatBan = 0 OR DB.SoLanDatBan IS NULL THEN N'Chưa từng đến'
                ELSE N'Thỉnh thoảng'
            END
        FROM KhachHang KH
        LEFT JOIN (
            SELECT MaKH, COUNT(*) AS SoLanDatBan 
            FROM DatBan 
            WHERE MaKH IS NOT NULL
            GROUP BY MaKH
        ) DB ON KH.MaKH = DB.MaKH";

            dataHelper.ExecuteSQL(updateLoaiKHQuery);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim();
            string tenKH = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string ngayDK = dtpNgayDangKy.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"UPDATE KhachHang SET TenKH = N'{tenKH}', SDT = '{sdt}', Email = '{email}', " +
                           $"NgayDangKy = '{ngayDK}' WHERE MaKH = '{maKH}'";

            DataHelper dataHelper = new DataHelper();
            dataHelper.ExecuteSQL(query);

            // Cập nhật lại loại khách hàng sau khi sửa
            string updateLoaiKHQuery = @"
        UPDATE KH
        SET KH.LoaiKH = 
            CASE 
                WHEN DB.SoLanDatBan >= 10 THEN N'VIP'
                WHEN DB.SoLanDatBan >= 5 THEN N'Thường xuyên'
                WHEN DB.SoLanDatBan = 0 OR DB.SoLanDatBan IS NULL THEN N'Chưa từng đến'
                ELSE N'Thỉnh thoảng'
            END
        FROM KhachHang KH
        LEFT JOIN (
            SELECT MaKH, COUNT(*) AS SoLanDatBan 
            FROM DatBan 
            WHERE MaKH IS NOT NULL
            GROUP BY MaKH
        ) DB ON KH.MaKH = DB.MaKH";

            dataHelper.ExecuteSQL(updateLoaiKHQuery);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM KhachHang WHERE MaKH = '{maKH}'";

                DataHelper dataHelper = new DataHelper();
                dataHelper.ExecuteSQL(query);
                LoadData();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = txtSoDienThoaiTimKiem.Text.Trim();
            string query = $"SELECT MaKH, TenKH, SDT, Email, LoaiKH, NgayDangKy FROM KhachHang WHERE SDT LIKE '%{sdt}%'";

            DataHelper dataHelper = new DataHelper();
            dataHelper.LoadDataGridView(query, guna2DataGridView1);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            dtpNgayDangKy.Value = DateTime.Now;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                txtMaKhachHang.Text = row.Cells["MaKH"].Value?.ToString() ?? "";
                txtTenKhachHang.Text = row.Cells["TenKH"].Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                if (DateTime.TryParse(row.Cells["NgayDangKy"].Value?.ToString(), out DateTime ngayDangKy))
                {
                    dtpNgayDangKy.Value = ngayDangKy;
                }
                else
                {
                    dtpNgayDangKy.Value = DateTime.Now;
                }
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
