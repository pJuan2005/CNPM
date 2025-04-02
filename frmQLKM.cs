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
    public partial class frmQLKM : Form
    {
        private DataTable dtKhuyenMai;
        private DataHelper dataHelper = new DataHelper(); // Đối tượng giúp kết nối CSDL

        public frmQLKM()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmQLKM_Load); // Attach the frmQLKM_Load event
            this.ActiveControl = txtMaKM; // Đặt con trỏ vào txtMaKM ngay khi mở form
        }

        private void frmQLKM_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView when the form loads
            string query = "SELECT MaKM, TenKM, NgayBD, NgayKT, MucGiamGia FROM KhuyenMai";
            dtKhuyenMai = dataHelper.GetData(query);
            dgvDanhSachKM.DataSource = dtKhuyenMai;


            // Đặt chiều cao của hàng tiêu đề cột
            dgvDanhSachKM.ColumnHeadersHeight = 30; // Thay 50 bằng giá trị chiều cao mong muốn
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaKM.Text) ||
                string.IsNullOrWhiteSpace(txtTenKM.Text) ||
                string.IsNullOrWhiteSpace(txtMucGG.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime NgayBD = dtpNgayBD.Value;
            DateTime NgayKT = dtpNgayKT.Value;
            decimal mucGiamGia;

            if (!decimal.TryParse(txtMucGG.Text, out mucGiamGia))
            {
                MessageBox.Show("Mức giảm giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm dữ liệu vào SQL Server
            string query = "INSERT INTO KhuyenMai (MaKM, TenKM, NgayBD, NgayKT, MucGiamGia) VALUES (@MaKM, @TenKM, @NgayBD, @NgayKT, @MucGiamGia)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKM", txtMaKM.Text),
                new SqlParameter("@TenKM", txtTenKM.Text),
                new SqlParameter("@NgayBD", dtpNgayBD.Value),
                new SqlParameter("@NgayKT", dtpNgayKT.Value),
                new SqlParameter("@MucGiamGia", decimal.Parse(txtMucGG.Text))
            };

            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLKM_Load(null, null); // Reload the data
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm khuyến mãi vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa nội dung TextBox sau khi thêm thành công
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtMucGG.Clear();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KhuyenMai SET TenKM = @TenKM, NgayBD = @NgayBD, NgayKT = @NgayKT, MucGiamGia = @MucGiamGia WHERE MaKM = @MaKM";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKM", txtMaKM.Text),
                new SqlParameter("@TenKM", txtTenKM.Text),
                new SqlParameter("@NgayBD", dtpNgayBD.Value),
                new SqlParameter("@NgayKT", dtpNgayKT.Value),
                new SqlParameter("@MucGiamGia", decimal.Parse(txtMucGG.Text))
            };

            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLKM_Load(null, null); // Reload the data
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo click vào hàng hợp lệ
            {
                DataGridViewRow row = dgvDanhSachKM.Rows[e.RowIndex];

                txtMaKM.Text = row.Cells["MaKM"].Value.ToString();
                txtTenKM.Text = row.Cells["TenKM"].Value.ToString();
                dtpNgayBD.Value = Convert.ToDateTime(row.Cells["NgayBD"].Value);
                dtpNgayKT.Value = Convert.ToDateTime(row.Cells["NgayKT"].Value);
                txtMucGG.Text = row.Cells["MucGiamGia"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Câu lệnh SQL DELETE
            string query = "DELETE FROM KhuyenMai WHERE MaKM = @MaKM";
            SqlParameter[] parameters = { new SqlParameter("@MaKM", txtMaKM.Text) };

            // Thực thi xóa
            if (dataHelper.ExecuteSQL(query, parameters))
            {
                MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLKM_Load(null, null); // Reload the data
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa nội dung trong các ô nhập liệu
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtMucGG.Clear();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong các ô nhập liệu
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtMucGG.Clear();

            // Đặt lại DateTimePicker về ngày hiện tại
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;

            // Bỏ chọn dòng trong DataGridView
            dgvDanhSachKM.ClearSelection();

            // Xóa nội dung ô tìm kiếm (nếu có)
            txtTimKiem.Clear();

            // Khôi phục danh sách khuyến mãi về trạng thái ban đầu
            dgvDanhSachKM.DataSource = dtKhuyenMai;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maKMCanTim = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(maKMCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã khuyến mãi để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView dv = new DataView(dtKhuyenMai);
            dv.RowFilter = $"MaKM LIKE '%{maKMCanTim}%'"; // Lọc theo MaKM
            dgvDanhSachKM.DataSource = dv; // Hiển thị dữ liệu đã lọc
        }

        private void btnDongTrang_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form hiện tại
        }
    }
}
