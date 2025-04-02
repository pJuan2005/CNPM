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

namespace WindowsFormsApp1
{
    public partial class frmChiTietDonHang : Form
    {
        private string maDonHang;
        public frmChiTietDonHang(string maDonHang)
        {
            InitializeComponent();
            this.maDonHang = maDonHang;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietDonHang_Load(object sender, EventArgs e)
        {
            dgvChiTietDonHang.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgvChiTietDonHang.Columns["dgcMaDH"].DataPropertyName = "MaDonHang";
            dgvChiTietDonHang.Columns["dgcMaMA"].DataPropertyName = "MaMon";
            dgvChiTietDonHang.Columns["dgcSoLuong"].DataPropertyName = "SoLuong";
            dgvChiTietDonHang.Columns["dgcDonGia"].DataPropertyName = "DonGia";
            dgvChiTietDonHang.Columns["dgcThanhTien"].DataPropertyName = "ThanhTien";
            LoadChiTietDonHang();

        }
        


        private void LoadChiTietDonHang()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT MaDonHang, MaMon, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang WHERE MaDonHang = @MaDonHang";

            SqlParameter[] parameters = { new SqlParameter("@MaDonHang", maDonHang) };

            DataTable dt = db.ExecuteQuery(query, parameters);

            dgvChiTietDonHang.DataSource = dt;
        }
    }
}
