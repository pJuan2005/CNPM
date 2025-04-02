using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ChiTietDonHang
    {
        public string MaDonHang { get; set; } // Mã đơn hàng
        public string MaBan { get; set; } // Mã bàn
        public string MonAnID { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
