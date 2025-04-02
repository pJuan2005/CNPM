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
    public partial class frmNhanVien : Form
    {
        private DataHelper dataHelper;


        public frmNhanVien()
        {
            InitializeComponent();
            dataHelper = new DataHelper();
            SetupComboBoxChucVu();
            LoadData();
            SetupDataGridView();
        }

        private void SetupComboBoxChucVu()
        {
            // Xóa các item hiện có (nếu có)
            cmbChucVu.Items.Clear();

            // Thêm 2 lựa chọn cố định
            cmbChucVu.Items.Add("Quản lý");
            cmbChucVu.Items.Add("Nhân viên");

            // Thiết lập chế độ chỉ được chọn, không được nhập
            cmbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetupDataGridView()
        {
            // Đầu tiên, tải dữ liệu từ SQL vào DataGridView
            // (SetupDataGridView sẽ được gọi sau khi đã LoadData)

            // Thiết lập kiểu hiển thị của hàng tiêu đề
            dgvDanhSachNhanVien.ColumnHeadersHeight = 40;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.5F, FontStyle.Bold);
            dgvDanhSachNhanVien.EnableHeadersVisualStyles = false;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Thiết lập các thuộc tính của DataGridView
            dgvDanhSachNhanVien.AllowUserToResizeColumns = false;
            dgvDanhSachNhanVien.AllowUserToAddRows = false;
            dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            dgvDanhSachNhanVien.AllowUserToResizeRows = false;
            dgvDanhSachNhanVien.ReadOnly = true;

            // Thiết lập chế độ chọn dòng
            dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.MultiSelect = false;

            // Cấu hình hiển thị cột và format
            if (dgvDanhSachNhanVien.Columns.Contains("MaNV"))
            {
                dgvDanhSachNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dgvDanhSachNhanVien.Columns["MaNV"].Width = 100;
            }

            if (dgvDanhSachNhanVien.Columns.Contains("TenNV"))
            {
                dgvDanhSachNhanVien.Columns["TenNV"].HeaderText = "Họ và tên";
                dgvDanhSachNhanVien.Columns["TenNV"].Width = 200;
            }

            if (dgvDanhSachNhanVien.Columns.Contains("DiaChi"))
            {
                dgvDanhSachNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvDanhSachNhanVien.Columns["DiaChi"].Width = 300;
            }

            // Ẩn các cột không cần hiển thị
            if (dgvDanhSachNhanVien.Columns.Contains("SoDienThoai"))
                dgvDanhSachNhanVien.Columns["SoDienThoai"].Visible = false;

            if (dgvDanhSachNhanVien.Columns.Contains("Email"))
                dgvDanhSachNhanVien.Columns["Email"].Visible = false;

            if (dgvDanhSachNhanVien.Columns.Contains("PhongBan"))
                dgvDanhSachNhanVien.Columns["PhongBan"].Visible = false;

            if (dgvDanhSachNhanVien.Columns.Contains("ChucVu"))
                dgvDanhSachNhanVien.Columns["ChucVu"].Visible = false;

            // Thiết lập chế độ điều chỉnh kích thước cột
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            string query = @"SELECT nv.MaNV, nv.TenNV, nv.DiaChi, 
                               ctnv.SoDienThoai, ctnv.Email, ctnv.PhongBan, ctnv.ChucVu
                        FROM NhanVien nv
                        LEFT JOIN ChiTietNhanVien ctnv ON nv.MaNV = ctnv.MaNV";
            dataHelper.LoadDataGridView(query, dgvDanhSachNhanVien);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmTrangChu trangchu = new frmTrangChu();
            trangchu.Show();
            this.Hide();
        }

        private void dgvDanhSachNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.CurrentRow != null)
            {
                DataGridViewRow row = dgvDanhSachNhanVien.CurrentRow;

                // Lấy thông tin chi tiết từ database
                string query = $@"SELECT ctnv.SoDienThoai, ctnv.Email, ctnv.PhongBan, ctnv.ChucVu
                            FROM ChiTietNhanVien ctnv
                            WHERE ctnv.MaNV = '{row.Cells["MaNV"].Value.ToString()}'";

                using (SqlConnection conn = new SqlConnection(dataHelper.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Điền thông tin vào các textbox
                                txtMaNhanVien.Text = row.Cells["MaNV"].Value.ToString();
                                txtTenNhanVien.Text = row.Cells["TenNV"].Value.ToString();
                                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                                txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtPhongBan.Text = reader["PhongBan"].ToString();
                                cmbChucVu.Text = reader["ChucVu"].ToString();
                            }
                            else
                            {
                                // Nếu không có thông tin chi tiết, chỉ điền thông tin cơ bản
                                txtMaNhanVien.Text = row.Cells["MaNV"].Value.ToString();
                                txtTenNhanVien.Text = row.Cells["TenNV"].Value.ToString();
                                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                                txtSoDienThoai.Clear();
                                txtEmail.Clear();
                                txtPhongBan.Clear();
                                cmbChucVu.SelectedIndex = -1;
                            }
                        }
                    }
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm vào bảng NhanVien
                string queryNhanVien = $@"INSERT INTO NhanVien (MaNV, TenNV, DiaChi) 
                                    VALUES ('{txtMaNhanVien.Text}', N'{txtTenNhanVien.Text}', 
                                    N'{txtDiaChi.Text}')";
                dataHelper.ExecuteSQL(queryNhanVien);

                // Thêm vào bảng ChiTietNhanVien nếu có thông tin chi tiết
                if (!string.IsNullOrEmpty(txtSoDienThoai.Text) || !string.IsNullOrEmpty(txtEmail.Text) ||
                    !string.IsNullOrEmpty(txtPhongBan.Text) || !string.IsNullOrEmpty(cmbChucVu.Text))
                {
                    string queryChiTiet = $@"INSERT INTO ChiTietNhanVien (MaNV, SoDienThoai, Email, PhongBan, ChucVu) 
                                       VALUES ('{txtMaNhanVien.Text}', '{txtSoDienThoai.Text}', 
                                       '{txtEmail.Text}', N'{txtPhongBan.Text}', N'{cmbChucVu.Text}')";
                    dataHelper.ExecuteSQL(queryChiTiet);
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật bảng NhanVien
                string queryNhanVien = $@"UPDATE NhanVien 
                                    SET TenNV = N'{txtTenNhanVien.Text}', 
                                        DiaChi = N'{txtDiaChi.Text}'
                                    WHERE MaNV = '{txtMaNhanVien.Text}'";
                dataHelper.ExecuteSQL(queryNhanVien);

                // Kiểm tra xem đã có thông tin chi tiết chưa
                string checkQuery = $"SELECT COUNT(*) FROM ChiTietNhanVien WHERE MaNV = '{txtMaNhanVien.Text}'";
                int exists = dataHelper.GetCount(checkQuery);

                if (exists > 0)
                {
                    // Cập nhật thông tin chi tiết nếu đã tồn tại
                    string queryChiTiet = $@"UPDATE ChiTietNhanVien 
                                       SET SoDienThoai = '{txtSoDienThoai.Text}',
                                           Email = '{txtEmail.Text}',
                                           PhongBan = N'{txtPhongBan.Text}',
                                           ChucVu = N'{cmbChucVu.Text}'
                                       WHERE MaNV = '{txtMaNhanVien.Text}'";
                    dataHelper.ExecuteSQL(queryChiTiet);
                }
                else
                {
                    // Thêm mới thông tin chi tiết nếu chưa tồn tại
                    string queryChiTiet = $@"INSERT INTO ChiTietNhanVien (MaNV, SoDienThoai, Email, PhongBan, ChucVu) 
                                       VALUES ('{txtMaNhanVien.Text}', '{txtSoDienThoai.Text}', 
                                       '{txtEmail.Text}', N'{txtPhongBan.Text}', N'{cmbChucVu.Text}')";
                    dataHelper.ExecuteSQL(queryChiTiet);
                }

                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa từ bảng ChiTietNhanVien trước (nếu có)
                    string queryChiTiet = $"DELETE FROM ChiTietNhanVien WHERE MaNV = '{txtMaNhanVien.Text}'";
                    dataHelper.ExecuteSQL(queryChiTiet);

                    // Xóa từ bảng NhanVien
                    string queryNhanVien = $"DELETE FROM NhanVien WHERE MaNV = '{txtMaNhanVien.Text}'";
                    dataHelper.ExecuteSQL(queryNhanVien);

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtPhongBan.Clear();
            cmbChucVu.SelectedIndex = -1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
