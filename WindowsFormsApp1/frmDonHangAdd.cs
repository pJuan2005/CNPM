using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmDonHangAdd : Form
    {
        public frmDonHangAdd()
        {
            InitializeComponent();
        }

        private double tongtien = 0;
        private DatabaseHelper dbh = new DatabaseHelper();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO DonHang (MaDonHang, MaKH, MaNV, MaBan, ThoiGianDat, TrangThai, TongTien) " +
                           "VALUES (@MaDH, @MaKH, @MaNV, @MaBA, @ThoiGianDat, @TrangThai, @TongTien)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaDH", txtMaDH.Text),
                new SqlParameter("@MaKH", cbMaKH.Text),
                new SqlParameter("@MaNV", cbMaNV.Text),
                new SqlParameter("@MaBA", cbMaBan.Text),
                new SqlParameter("@ThoiGianDat", dtThoiGian.Value),
                new SqlParameter("@TrangThai", cboTrangThai.Text),
                new SqlParameter("@TongTien", tongtien)
            };

            int result = dbh.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                
                SaveChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Lưu đơn hàng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChiTietDonHang()
        {
           
            foreach (var monAn in danhSachMonAn) 
            {
                string query = "INSERT INTO ChiTietDonHang (MaDonHang, MaMon, SoLuong, DonGia, ThanhTien) " +
                               "VALUES (@MaDH, @MaMon, @SoLuong, @DonGia, @ThanhTien)";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaDH", txtMaDH.Text),
                    new SqlParameter("@MaMon", monAn.MaMon),
                    new SqlParameter("@SoLuong", monAn.SoLuong),
                    new SqlParameter("@DonGia", monAn.GiaMon),
                    new SqlParameter("@ThanhTien", monAn.ThanhTien)
                };

                int result = dbh.ExecuteNonQuery(query, parameters);
                if (result <= 0)
                {
                    MessageBox.Show("Lưu chi tiết đơn hàng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

           
            Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
            guna2MessageDialog.Caption = "Thông báo";
            guna2MessageDialog.Text = "Đơn hàng đã lưu thành công!";
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Information;
            guna2MessageDialog.Parent = this;
            guna2MessageDialog.Show();
        }

        
        private List<MonAn> danhSachMonAn = new List<MonAn>();

        private void btnChonMonAn_Click(object sender, EventArgs e)
        {
            frmMonAn frmma = new frmMonAn();
            if (frmma.ShowDialog() == DialogResult.OK)
            {
                if (frmma.dgvMonAn.CurrentRow != null)
                {
                    double giaMonAn = Convert.ToDouble(frmma.dgvMonAn.CurrentRow.Cells["dgcGia"].Value);
                    int soLuong = (int)frmma.nudSoLuong.Value;

                   
                    tongtien += giaMonAn * soLuong;
                    lblTongTien.Text = Convert.ToString(tongtien);

                 
                    danhSachMonAn.Add(new MonAn
                    {
                        MaMon = frmma.dgvMonAn.CurrentRow.Cells["dgcMaMA"].Value.ToString(),
                        TenMon = frmma.dgvMonAn.CurrentRow.Cells["dgcTen"].Value.ToString(),
                        GiaMon = giaMonAn,
                        SoLuong = soLuong,
                        ThanhTien = giaMonAn * soLuong
                    });

                    MessageBox.Show($"Món ăn đã chọn, tổng tiền hiện tại: {tongtien}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadNhanVien()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetNhanVienList();

            if (dt.Rows.Count > 0)
            {
                cbMaNV.DataSource = dt;
                
                cbMaNV.ValueMember = "MaNV";    
                cbMaNV.SelectedIndex = -1;      
            }
        }

        private void LoadKhachHang()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetKhachHangList();

            if (dt.Rows.Count > 0)
            {
                cbMaKH.DataSource = dt;
                cbMaKH.ValueMember = "MaKH";    
                cbMaKH.SelectedIndex = -1;     
            }
        }

        private void LoadBanAn()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetBanAnList();

            if (dt.Rows.Count > 0)
            {
                cbMaBan.DataSource = dt;
                cbMaBan.ValueMember = "MaBan";   
                cbMaBan.SelectedIndex = -1;
            }
        }
        

        private void frmDonHangAdd_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadKhachHang();
            LoadBanAn();
           
        }
    }

    // Lớp MonAn để lưu trữ thông tin món ăn đã chọn
    public class MonAn
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public double GiaMon { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
    }
}
