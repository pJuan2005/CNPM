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
    public partial class frmDangNhap : Form
    {
        private DataHelper dataHelper = new DataHelper(); // Sử dụng lớp DataHelper

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus(); // Tự động focus vào ô nhập tên đăng nhập
            txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tài khoản tồn tại
            string queryCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            int count = dataHelper.GetCountWithParams(queryCheck, tenDangNhap, matKhau);

            if (count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trạng thái tài khoản
            string queryStatus = "SELECT TrangThai FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(queryStatus, dataHelper.ConnectionString))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                string trangThai = dt.Rows[0]["TrangThai"].ToString();

                if (trangThai == "Bị khóa")
                {
                    MessageBox.Show("Tài khoản đã bị khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChu trangChu = new frmTrangChu();
                trangChu.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
