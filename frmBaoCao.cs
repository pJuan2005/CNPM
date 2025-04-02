    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmBaoCao : Form
    {
        private DataHelper dataHelper = new DataHelper(); // Sử dụng lớp DataHelper để thao tác CSDL

        public frmBaoCao()
        {
            InitializeComponent();

        }

        private void dtpTu_ValueChanged(object sender, EventArgs e)
        {
            if (radDSNV.Checked)
            {
                MessageBox.Show("Báo cáo Danh Sách Nhân Viên không cần chọn thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dtpDen_ValueChanged(object sender, EventArgs e)
        {
            if (radDSNV.Checked)
            {
                MessageBox.Show("Báo cáo Danh Sách Nhân Viên không cần chọn thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }





        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn loại báo cáo chưa
            if (!radDT.Checked && !radDSNV.Checked && !radSLDH.Checked && !radSLKH.Checked)
            {
                MessageBox.Show("Bạn phải chọn loại báo cáo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu chưa chọn loại báo cáo
            }

            // Xóa dữ liệu cũ trong DataGridView để làm sạch trước khi tải dữ liệu mới
            dgvBaoCao.DataSource = null;
            dgvBaoCao.Rows.Clear();
            dgvBaoCao.Columns.Clear();

            int tuThang = dtpTu.Value.Month;
            int tuNam = dtpTu.Value.Year;
            int denThang = dtpDen.Value.Month;
            int denNam = dtpDen.Value.Year;

            string query = "";
            SqlParameter[] parameters = new SqlParameter[0]; // Khởi tạo mặc định để tránh lỗi

            // Kiểm tra loại báo cáo
            if (radDT.Checked) // Báo cáo Doanh Thu
            {
                if (radThang.Checked) // Báo cáo doanh thu theo tháng
                {
                    query = @"
                         WITH TotalMonth AS (
                            SELECT YEAR(NgayLap) AS Nam, MONTH(NgayLap) AS Thang, SUM(TongTien) AS TongTienThang
                            FROM HoaDon
                            WHERE (YEAR(NgayLap) BETWEEN @TuNam AND @DenNam)
                            AND (MONTH(NgayLap) BETWEEN @TuThang AND @DenThang)
                            GROUP BY YEAR(NgayLap), MONTH(NgayLap)
                        )
                        SELECT hd.MaHD, hd.NgayLap, hd.TongTien, tm.TongTienThang
                        FROM HoaDon hd
                        JOIN TotalMonth tm
                        ON YEAR(hd.NgayLap) = tm.Nam AND MONTH(hd.NgayLap) = tm.Thang
                        WHERE (YEAR(hd.NgayLap) BETWEEN @TuNam AND @DenNam)
                        AND (MONTH(hd.NgayLap) BETWEEN @TuThang AND @DenThang)";

                    parameters = new SqlParameter[] {
                            new SqlParameter("@TuNam", tuNam),
                            new SqlParameter("@DenNam", denNam),
                            new SqlParameter("@TuThang", tuThang),
                            new SqlParameter("@DenThang", denThang)
                        };
                }
                else if (radNam.Checked) // Báo cáo doanh thu theo năm
                {
                    query = @"
                         WITH TotalYear AS (
                                SELECT YEAR(NgayLap) AS Nam, SUM(TongTien) AS TongTienNam
                                FROM HoaDon
                                WHERE YEAR(NgayLap) BETWEEN @TuNam AND @DenNam
                                GROUP BY YEAR(NgayLap)
                         )
                        SELECT hd.MaHD, hd.NgayLap, hd.TongTien, ty.TongTienNam
                        FROM HoaDon hd
                        JOIN TotalYear ty
                        ON YEAR(hd.NgayLap) = ty.Nam
                        WHERE YEAR(hd.NgayLap) BETWEEN @TuNam AND @DenNam";

                    parameters = new SqlParameter[] {
                            new SqlParameter("@TuNam", tuNam),
                            new SqlParameter("@DenNam", denNam)
                        };
                }

                try
                {
                    // Lấy dữ liệu từ SQL
                    DataTable dtBaoCao = dataHelper.GetData(query, parameters);

                    // Tạo và thêm các cột thủ công vào DataGridView
                    dgvBaoCao.Columns.Add("MaHD", "Mã Hóa Đơn");
                    dgvBaoCao.Columns.Add("NgayLap", "Ngày Lập");
                    dgvBaoCao.Columns.Add("TongTien", "Tổng Tiền");
                    dgvBaoCao.Columns.Add("TongTienThang", "Tổng Tiền Cả Tháng/Năm");

                    // Đặt chiều cao cho hàng tiêu đề cột
                    dgvBaoCao.ColumnHeadersHeight = 30;

                    // Đổ dữ liệu từ DataTable vào DataGridView
                    foreach (DataRow row in dtBaoCao.Rows)
                    {
                        dgvBaoCao.Rows.Add(
                            row["MaHD"],
                            Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy"),
                            Convert.ToDecimal(row["TongTien"]).ToString("N0"),
                            Convert.ToDecimal(row["TongTienThang"] ?? row["TongTienNam"]).ToString("N0")
                        );
                    }

                    // Tùy chỉnh định dạng cột
                    dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Định dạng số tiền
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu báo cáo doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            else if (radSLDH.Checked) // Báo cáo Số Lượng Đơn Hàng
            {
                if (radThang.Checked) // Báo cáo số lượng đơn hàng theo tháng
                {
                    query = @"
                        WITH TotalOrders AS (
                            SELECT YEAR(ThoiGianDat) AS Nam, MONTH(ThoiGianDat) AS Thang, COUNT(*) AS TongSoDon
                            FROM DonHang
                            WHERE (YEAR(ThoiGianDat) BETWEEN @TuNam AND @DenNam)
                            AND (MONTH(ThoiGianDat) BETWEEN @TuThang AND @DenThang)
                            AND TrangThai = N'Đã hoàn thành'
                            GROUP BY YEAR(ThoiGianDat), MONTH(ThoiGianDat)
                            )
                        SELECT dh.MaDonHang, dh.ThoiGianDat, kh.TenKH, dh.TongTien, totalOrders.TongSoDon
                        FROM DonHang dh
                        JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                        JOIN TotalOrders totalOrders
                        ON YEAR(dh.ThoiGianDat) = totalOrders.Nam AND MONTH(dh.ThoiGianDat) = totalOrders.Thang
                        WHERE (YEAR(dh.ThoiGianDat) BETWEEN @TuNam AND @DenNam)
                        AND (MONTH(dh.ThoiGianDat) BETWEEN @TuThang AND @DenThang)
                        AND dh.TrangThai = N'Đã hoàn thành'";

                    parameters = new SqlParameter[] {
                            new SqlParameter("@TuNam", tuNam),
                            new SqlParameter("@DenNam", denNam),
                            new SqlParameter("@TuThang", tuThang),
                            new SqlParameter("@DenThang", denThang)
                         };
                }
                else if (radNam.Checked) // Báo cáo số lượng đơn hàng theo năm
                {
                    query = @"
                        WITH TotalOrders AS (
                            SELECT YEAR(ThoiGianDat) AS Nam, COUNT(*) AS TongSoDon
                            FROM DonHang
                            WHERE YEAR(ThoiGianDat) BETWEEN @TuNam AND @DenNam
                            AND TrangThai = N'Đã hoàn thành'
                            GROUP BY YEAR(ThoiGianDat)
                        )
                        SELECT dh.MaDonHang, dh.ThoiGianDat, kh.TenKH, dh.TongTien, totalOrders.TongSoDon
                        FROM DonHang dh
                        JOIN KhachHang kh ON dh.MaKH = kh.MaKH
                        JOIN TotalOrders totalOrders
                        ON YEAR(dh.ThoiGianDat) = totalOrders.Nam
                        WHERE YEAR(dh.ThoiGianDat) BETWEEN @TuNam AND @DenNam
                        AND dh.TrangThai = N'Đã hoàn thành'";

                    parameters = new SqlParameter[] {
                            new SqlParameter("@TuNam", tuNam),
                            new SqlParameter("@DenNam", denNam)
                        };
                }

                try
                {
                    // Lấy dữ liệu từ SQL
                    DataTable dtBaoCao = dataHelper.GetData(query, parameters);

                    // Tạo và thêm các cột thủ công vào DataGridView
                    dgvBaoCao.Columns.Add("MaDonHang", "Mã Đơn Hàng");
                    dgvBaoCao.Columns.Add("ThoiGianDat", "Thời Gian Đặt");
                    dgvBaoCao.Columns.Add("TenKH", "Tên Khách Hàng");
                    dgvBaoCao.Columns.Add("TongTien", "Tổng Tiền");
                    dgvBaoCao.Columns.Add("TongSoDon", "Tổng Số Lượng Đơn Hàng");

                    // Đặt chiều cao cho hàng tiêu đề cột
                    dgvBaoCao.ColumnHeadersHeight = 30;

                    // Đổ dữ liệu từ DataTable vào DataGridView
                    foreach (DataRow row in dtBaoCao.Rows)
                    {
                        dgvBaoCao.Rows.Add(
                            row["MaDonHang"],
                            Convert.ToDateTime(row["ThoiGianDat"]).ToString("dd/MM/yyyy HH:mm"),
                            row["TenKH"],
                            Convert.ToDecimal(row["TongTien"]).ToString("N0"),
                            row["TongSoDon"]
                        );
                    }

                    // Tùy chỉnh định dạng cột
                    dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Format = "N0"; // Định dạng số tiền
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu báo cáo số lượng đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (radDSNV.Checked) // Báo cáo Danh Sách Nhân Viên
            {
                query = @"SELECT NV.MaNV, NV.TenNV, NV.DiaChi, CTNV.SoDienThoai, CTNV.ChucVu
              FROM NhanVien NV
              INNER JOIN ChiTietNhanVien CTNV ON NV.MaNV = CTNV.MaNV";

                try
                {
                    // Lấy dữ liệu từ SQL
                    DataTable dtBaoCao = dataHelper.GetData(query);

                    // Xóa các cột cũ trước khi thêm mới
                    dgvBaoCao.Columns.Clear();

                    // Tạo và thêm các cột thủ công vào Guna2DataGridView
                    dgvBaoCao.Columns.Add("MaNV", "Mã Nhân Viên");
                    dgvBaoCao.Columns.Add("TenNV", "Tên Nhân Viên");
                    dgvBaoCao.Columns.Add("DiaChi", "Địa Chỉ");
                    dgvBaoCao.Columns.Add("SoDienThoai", "Số Điện Thoại");
                    dgvBaoCao.Columns.Add("ChucVu", "Chức Vụ");

                    // Đặt chiều cao cho hàng tiêu đề cột
                    dgvBaoCao.ColumnHeadersHeight = 30;

                    // Đổ dữ liệu từ DataTable vào Guna2DataGridView
                    foreach (DataRow row in dtBaoCao.Rows)
                    {
                        dgvBaoCao.Rows.Add(
                            row["MaNV"],
                            row["TenNV"],
                            row["DiaChi"],
                            row["SoDienThoai"],
                            row["ChucVu"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            else if (radSLKH.Checked)// Báo cáo Danh Sách Khách Hàng
            {
                query = @"
                    WITH CompletedOrders AS (
                        SELECT MaKH, COUNT(*) AS SoDonHoanThanh
                        FROM DonHang
                        WHERE TrangThai = N'Đã hoàn thành'
                        GROUP BY MaKH
                    )
                    SELECT kh.MaKH, kh.TenKH, kh.SDT, kh.Email, kh.LoaiKH, co.SoDonHoanThanh
                    FROM KhachHang kh
                    JOIN CompletedOrders co ON kh.MaKH = co.MaKH";

                try
                {
                    // Lấy dữ liệu từ SQL
                    DataTable dtBaoCao = dataHelper.GetData(query);

                    // Tạo và thêm các cột thủ công vào DataGridView
                    dgvBaoCao.Columns.Add("MaKH", "Mã Khách Hàng");
                    dgvBaoCao.Columns.Add("TenKH", "Tên Khách Hàng");
                    dgvBaoCao.Columns.Add("SDT", "Số Điện Thoại");
                    dgvBaoCao.Columns.Add("Email", "Email");
                    dgvBaoCao.Columns.Add("LoaiKH", "Loại Khách Hàng");
                    dgvBaoCao.Columns.Add("SoDonHoanThanh", "Số Đơn Hoàn Thành");

                    // Đặt chiều cao cho hàng tiêu đề cột
                    dgvBaoCao.ColumnHeadersHeight = 30;

                    // Đổ dữ liệu từ DataTable vào DataGridView
                    foreach (DataRow row in dtBaoCao.Rows)
                    {
                        dgvBaoCao.Rows.Add(
                            row["MaKH"],
                            row["TenKH"],
                            row["SDT"],
                            row["Email"],
                            row["LoaiKH"],
                            row["SoDonHoanThanh"]);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void btnDongTrang_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radDSNV.Checked)
            {
                MessageBox.Show("Báo cáo Danh Sách Nhân Viên không cần chọn theo Tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radThang.Checked = false; // Bỏ chọn radio
                return;

            }

            // Hiển thị tháng và năm, ẩn ngày
            dtpTu.Format = DateTimePickerFormat.Custom;
            dtpTu.CustomFormat = "MM/yyyy"; // Chỉ hiển thị tháng và năm


            dtpDen.Format = DateTimePickerFormat.Custom;
            dtpDen.CustomFormat = "MM/yyyy"; // Chỉ hiển thị tháng và năm
        }


        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

            if (radDSNV.Checked)
            {
                MessageBox.Show("Báo cáo Danh Sách Nhân Viên không cần chọn theo Năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radNam.Checked = false; // Bỏ chọn radio
                return;
            }

            // Hiển thị năm, ẩn ngày và tháng
            dtpTu.Format = DateTimePickerFormat.Custom;
            dtpTu.CustomFormat = "yyyy"; // Chỉ hiển thị năm


            dtpDen.Format = DateTimePickerFormat.Custom;
            dtpDen.CustomFormat = "yyyy"; // Chỉ hiển thị năm
        }
    }

}




