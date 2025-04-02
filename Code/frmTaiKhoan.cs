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
    public partial class frmTaiKhoan : Form
    {
        private DataHelper dataHelper = new DataHelper();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtMaTaiKhoan.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtMaNhanVien.Clear();

            cmbVaiTro.SelectedIndex = -1;
            cmbTrangThai.SelectedIndex = -1;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM TaiKhoan";
            dataHelper.LoadDataGridView(query, dgvTaiKhoan);
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập không được quá 50 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Text = txtTenDangNhap.Text.Substring(0, 50); // Giới hạn ký tự
                txtTenDangNhap.SelectionStart = txtTenDangNhap.Text.Length; // Giữ con trỏ ở cuối
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu không được quá 50 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Text = txtMatKhau.Text.Substring(0, 50);
                txtMatKhau.SelectionStart = txtMatKhau.Text.Length;
            }
        }

        private void cmbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVaiTro.Items.Count == 0) // Kiểm tra xem đã thêm dữ liệu chưa
            {
                cmbVaiTro.Items.AddRange(new string[] { "Admin", "Quản lý", "Nhân viên" });
            }
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrangThai.Items.Count == 0)
            {
                cmbTrangThai.Items.AddRange(new string[] { "Hoạt động", "Bị khóa" });
            }
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenDangNhap = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                LoadTaiKhoan();
            }
            else
            {
                string query = $"SELECT TenDangNhap, MatKhau, VaiTro, TrangThai FROM TaiKhoan WHERE TenDangNhap LIKE N'%{tenDangNhap}%'";
                dataHelper.LoadDataGridView(query, dgvTaiKhoan);
            }
            ResetForm(); // Xóa trắng các TextBox sau khi tìm kiếm
        }
        private void LoadTaiKhoan()
        {
            string query = "SELECT MaTK, TenDangNhap, MatKhau, VaiTro, TrangThai, MaNV FROM TaiKhoan";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(dataHelper.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                dgvTaiKhoan.AutoGenerateColumns = false; // Tắt tự động tạo cột
                dgvTaiKhoan.Columns.Clear(); // Xóa cột cũ

                // Định nghĩa cột mới
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaTK", HeaderText = "Mã Tài Khoản", DataPropertyName = "MaTK", Width = 120 });
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDangNhap", HeaderText = "Tên Đăng Nhập", DataPropertyName = "TenDangNhap", Width = 150 });
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "MatKhau", HeaderText = "Mật Khẩu", DataPropertyName = "MatKhau", Width = 150 });
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "VaiTro", HeaderText = "Vai Trò", DataPropertyName = "VaiTro", Width = 120 });
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", HeaderText = "Trạng Thái", DataPropertyName = "TrangThai", Width = 120 });
                dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaNV", HeaderText = "Mã Nhân Viên", DataPropertyName = "MaNV", Width = 120 });

                dgvTaiKhoan.DataSource = dt; // Gán dữ liệu

                dgvTaiKhoan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Điều chỉnh kích thước cột
                dgvTaiKhoan.ColumnHeadersHeight = 40; // Chiều cao tiêu đề
                dgvTaiKhoan.Columns["MaTK"].ReadOnly = true; // Ngăn chỉnh sửa cột
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            // Chỉ thêm dữ liệu vào ComboBox, không đặt giá trị mặc định
            cmbVaiTro.Items.AddRange(new string[] { "Admin", "Quản lý", "Nhân viên" });
            cmbTrangThai.Items.AddRange(new string[] { "Hoạt động", "Bị khóa" });

            // Không đặt SelectedIndex để tránh hiển thị mặc định
            cmbVaiTro.SelectedIndex = -1;
            cmbTrangThai.SelectedIndex = -1;

            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được quá 10 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Text = txtMaNhanVien.Text.Substring(0, 10); // Giới hạn ký tự
                txtMaNhanVien.SelectionStart = txtMaNhanVien.Text.Length; // Giữ con trỏ ở cuối
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                LoadTaiKhoan();
            }
            else
            {
                string query = $"SELECT TenDangNhap, MatKhau, VaiTro, TrangThai FROM TaiKhoan WHERE TenDangNhap LIKE N'%{tenDangNhap}%'";
                dataHelper.LoadDataGridView(query, dgvTaiKhoan);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void dgvTaiKhoan_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                txtMaTaiKhoan.Text = row.Cells["MaTK"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                cmbVaiTro.Text = row.Cells["VaiTro"].Value?.ToString();
                cmbTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtMaNhanVien.Text = row.Cells["MaNV"].Value?.ToString();
            }
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            frmTrangChu trangChu = new frmTrangChu();
            trangChu.Show();
            this.Hide();
        }

        private void btnKhoaMoKhoa_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Lấy trạng thái hiện tại bằng cách load toàn bộ thông tin tài khoản
                string query = $"SELECT TrangThai FROM TaiKhoan WHERE TenDangNhap = N'{tenDangNhap}'";
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, dataHelper.ConnectionString))
                {
                    adapter.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string trangThaiHienTai = dt.Rows[0]["TrangThai"].ToString();
                string trangThaiMoi = trangThaiHienTai == "Hoạt động" ? "Bị khóa" : "Hoạt động";

                // Thực hiện update
                string updateQuery = $"UPDATE TaiKhoan SET TrangThai = N'{trangThaiMoi}' WHERE TenDangNhap = N'{tenDangNhap}'";
                dataHelper.ExecuteSQL(updateQuery);

                // Cập nhật lại giao diện
                LoadTaiKhoan();
                cmbTrangThai.Text = trangThaiMoi;

                MessageBox.Show($"Đã {trangThaiMoi} tài khoản thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM TaiKhoan WHERE TenDangNhap = N'{tenDangNhap}'";
                dataHelper.ExecuteSQL(query);
                LoadTaiKhoan();
                ResetForm(); // Xóa trắng các TextBox sau khi xóa
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string vaiTro = cmbVaiTro.Text;
            string trangThai = cmbTrangThai.Text;

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"UPDATE TaiKhoan SET MatKhau = N'{matKhau}', VaiTro = N'{vaiTro}', TrangThai = N'{trangThai}' WHERE TenDangNhap = N'{tenDangNhap}'";
            dataHelper.ExecuteSQL(query);
            LoadTaiKhoan();
            ResetForm(); // Xóa trắng các TextBox sau khi sửa
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maTK = txtMaTaiKhoan.Text.Trim();
                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string maNV = txtMaNhanVien.Text.Trim();
                string vaiTro = cmbVaiTro.Text.Trim();
                string trangThai = cmbTrangThai.Text.Trim();

                if (string.IsNullOrEmpty(maTK) || string.IsNullOrEmpty(tenDangNhap) ||
                    string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(vaiTro) ||
                    string.IsNullOrEmpty(trangThai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataHelper.GetCount($"SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = N'{tenDangNhap}'") > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataHelper.GetCount($"SELECT COUNT(*) FROM TaiKhoan WHERE MaTK = N'{maTK}'") > 0)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataHelper.GetCount($"SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = N'{maNV}'") > 0)
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isNewEmployee = false;
                if (dataHelper.GetCount($"SELECT COUNT(*) FROM NhanVien WHERE MaNV = N'{maNV}'") == 0)
                {
                    dataHelper.ExecuteSQL($"INSERT INTO NhanVien (MaNV, TenNV) VALUES (N'{maNV}', N'Nhân viên mới')");
                    isNewEmployee = true;
                }

                string query = "INSERT INTO TaiKhoan (MaTK, TenDangNhap, MatKhau, VaiTro, TrangThai, MaNV) VALUES (@MaTK, @TenDangNhap, @MatKhau, @VaiTro, @TrangThai, @MaNV)";
                using (SqlConnection conn = new SqlConnection(dataHelper.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTK", maTK);
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", vaiTro);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadTaiKhoan();
                ResetForm();

                if (isNewEmployee)
                {
                    MessageBox.Show("Đây là một mã nhân viên mới. Bạn nên cập nhật thông tin chi tiết cho nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
