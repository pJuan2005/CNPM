using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmQLKhoNL : Form
    {
        private DataTable dtKhoNL;
        private DataHelper dataHelper = new DataHelper();

        public frmQLKhoNL()
        {
            InitializeComponent();
            this.Load += frmQLKhoNL_Load;
            this.ActiveControl = txtMaNL; // Đặt con trỏ vào txtMaNL ngay khi mở form
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNL.Text) ||
                string.IsNullOrWhiteSpace(txtTenNL.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtSLTon.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO KhoNguyenLieu (MaNL, TenNL, DonViTinh, SoLuongTon, GiaNhap) VALUES (@MaNL, @TenNL, @DonViTinh, @SoLuongTon, @GiaNhap)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNL", txtMaNL.Text),
                new SqlParameter("@TenNL", txtTenNL.Text),
                new SqlParameter("@DonViTinh", txtDonViTinh.Text),
                new SqlParameter("@SoLuongTon", int.Parse(txtSLTon.Text)),
                new SqlParameter("@GiaNhap", decimal.Parse(txtGiaNhap.Text))
            };

            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLKhoNL_Load(null, null);
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nguyên liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtMaNL.Clear();
            txtTenNL.Clear();
            txtDonViTinh.Clear();
            txtSLTon.Clear();
            txtGiaNhap.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KhoNguyenLieu SET TenNL = @TenNL, DonViTinh = @DonViTinh, SoLuongTon = @SoLuongTon, GiaNhap = @GiaNhap WHERE MaNL = @MaNL";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNL", txtMaNL.Text),
                new SqlParameter("@TenNL", txtTenNL.Text),
                new SqlParameter("@DonViTinh", txtDonViTinh.Text),
                new SqlParameter("@SoLuongTon", int.Parse(txtSLTon.Text)),
                new SqlParameter("@GiaNhap", decimal.Parse(txtGiaNhap.Text))
            };

            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thông báo");
                frmQLKhoNL_Load(null, null);
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật nguyên liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            string query = "DELETE FROM KhoNguyenLieu WHERE MaNL = @MaNL";
            SqlParameter[] parameters = { new SqlParameter("@MaNL", txtMaNL.Text) };

            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo");
                frmQLKhoNL_Load(null, null);
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa nguyên liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtMaNL.Clear();
            txtTenNL.Clear();
            txtDonViTinh.Clear();
            txtSLTon.Clear();
            txtGiaNhap.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNL.Clear();
            txtTenNL.Clear();
            txtDonViTinh.Clear();
            txtSLTon.Clear();
            txtGiaNhap.Clear();
            dgvDanhSachNL.ClearSelection();
            txtTimKiem.Clear();
            dgvDanhSachNL.DataSource = dtKhoNL;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNLCanTim = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNLCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã nguyên liệu để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView dv = new DataView(dtKhoNL);
            dv.RowFilter = $"MaNL LIKE '%{maNLCanTim}%'";
            dgvDanhSachNL.DataSource = dv;
        }

        private void btnDongTrang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLKhoNL_Load(object sender, EventArgs e)
        {
            string query = "SELECT MaNL, TenNL, DonViTinh, SoLuongTon, GiaNhap FROM KhoNguyenLieu";
            dtKhoNL = dataHelper.GetData(query);
            dgvDanhSachNL.DataSource = dtKhoNL;

            // Đặt chiều cao của hàng tiêu đề cột
            dgvDanhSachNL.ColumnHeadersHeight = 30; // Thay 50 bằng giá trị chiều cao mong muốn
        }

        private void dgvDanhSachNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào tiêu đề
            {
                DataGridViewRow row = dgvDanhSachNL.Rows[e.RowIndex];
                txtMaNL.Text = row.Cells["MaNL"].Value.ToString();
                txtTenNL.Text = row.Cells["TenNL"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtSLTon.Text = row.Cells["SoLuongTon"].Value.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
            }
        }
    }
}
