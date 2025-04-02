using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        DatabaseHelper dbh = new DatabaseHelper();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDonHangAdd frmdh = new frmDonHangAdd();
            frmdh.ShowDialog();
            LoadDuLieu();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvDonHang.Columns[e.ColumnIndex].Name == "dgcChiTiet")
                {
                    
                    string maDonHang = dgvDonHang.Rows[e.RowIndex].Cells["dgcMaDH"].Value.ToString();

                    
                    frmChiTietDonHang frm = new frmChiTietDonHang(maDonHang);
                    frm.ShowDialog();
                }
            }
        }

        private void LoadDuLieu()
        {
            string query = "SELECT * FROM DonHang";
            DataTable dt = dbh.ExecuteQuery(query); 
            if (dt != null)
            {
                dgvDonHang.DataSource = dt; 
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.AutoGenerateColumns = false; 

            dgvDonHang.Columns["dgcMaDH"].DataPropertyName = "MaDonHang";
            dgvDonHang.Columns["dgcMaKH"].DataPropertyName = "MaKH";
            dgvDonHang.Columns["dgcMaNV"].DataPropertyName = "MaNV";
            dgvDonHang.Columns["dgcMaBan"].DataPropertyName = "MaBan";
            dgvDonHang.Columns["dgcThoiGianDat"].DataPropertyName = "ThoiGianDat";
            dgvDonHang.Columns["dgcTrangThai"].DataPropertyName = "TrangThai";
            dgvDonHang.Columns["dgcTongTien"].DataPropertyName = "TongTien";

            LoadDuLieu();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                string maDonHang = dgvDonHang.SelectedRows[0].Cells["dgcMaDH"].Value.ToString();
                CapNhatTrangThai(maDonHang);
            }
        }
        private void CapNhatTrangThai(string maDonHang)
        {
            
            string query = "UPDATE DonHang SET TrangThai = N'Đã hoàn thành' WHERE MaDonHang = @MaDonHang";
            SqlParameter[] parameters = { new SqlParameter("@MaDonHang", maDonHang) };

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Đơn hàng đã được thanh toán và thay đổi trạng thái.");
                LoadDuLieu(); // Tải lại dữ liệu để hiển thị trạng thái mới
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật trạng thái đơn hàng.");
            }
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaDH_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
