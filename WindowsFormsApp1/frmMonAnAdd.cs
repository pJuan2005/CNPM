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
    public partial class frmMonAnAdd : Form
    {
        public frmMonAnAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetMonAnData(string maMon, string tenMon, decimal gia)
        {
            this.txtMaMA.Text = maMon;
            this.txtTenMA.Text = tenMon;
            this.txtGiaMA.Text = gia.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy mã món từ DataGridView (nếu có)
            
            // Kiểm tra xem mã món đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM MonAn WHERE MaMon = @MaMon";
            SqlParameter[] checkParameters = 
            {
                new SqlParameter("@MaMon", txtMaMA.Text)
            };

            DatabaseHelper dbh = new DatabaseHelper();
            int count = Convert.ToInt32(dbh.ExecuteScalar(checkQuery, checkParameters));

            if (count > 0)
            {
                // Nếu đã tồn tại, thực hiện UPDATE
                string updateQuery = "UPDATE MonAn SET TenMon = @TenMon, Gia = @Gia WHERE MaMon = @MaMon";
                SqlParameter[] updateParameters = 
                {
                    new SqlParameter("@MaMon", txtMaMA.Text),
                    new SqlParameter("@TenMon", txtTenMA.Text),
                    new SqlParameter("@Gia", Convert.ToDecimal(txtGiaMA.Text)) // Chuyển sang số nếu cần
                };

                int rowsAffected = dbh.ExecuteNonQuery(updateQuery, updateParameters);

                if (rowsAffected > 0)
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Text = "Cập nhật thành công";
                    guna2MessageDialog1.Show();
                }
                else
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Text = "Cập nhật thất bại";
                    guna2MessageDialog1.Show();
                }
            }
            else
            {
                // Nếu chưa tồn tại, thực hiện INSERT
                string insertQuery = "INSERT INTO MonAn (MaMon, TenMon, Gia) VALUES (@MaMon, @TenMon, @Gia)";
                SqlParameter[] insertParameters =
                {
                    new SqlParameter("@MaMon", txtMaMA.Text),
                    new SqlParameter("@TenMon", txtTenMA.Text),
                    new SqlParameter("@Gia", Convert.ToDecimal(txtGiaMA.Text)) // Chuyển sang số nếu cần
                };

                int rowsAffected = dbh.ExecuteNonQuery(insertQuery, insertParameters);

                if (rowsAffected > 0)
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Text = "Lưu thành công";
                    guna2MessageDialog1.Show();
                }
                else
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Text = "Lưu thất bại";
                    guna2MessageDialog1.Show();
                }
            }
        }


    }
}
