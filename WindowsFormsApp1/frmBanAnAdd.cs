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
    public partial class frmBanAnAdd : Form
    {
        public frmBanAnAdd()
        {
            InitializeComponent();
        }
        DatabaseHelper dbh = new DatabaseHelper();
   
        private void LoadData()
        {
            string query = "SELECT * FROM BanAn";
            dbh.ExecuteQuery(query);
        }
        public void SetBanAnData(string maMon, string tenMon, string tt)
        {
            this.txtMaBA.Text = maMon;
            this.txtTenBA.Text = tenMon;
            this.cboTrangThai.Text = tt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string checkQuery = "SELECT COUNT(*) FROM BanAn WHERE MaBan = @MaBA";
            SqlParameter[] checkParameters =
            {
                new SqlParameter("@MaBA", txtMaBA.Text)
            };

            int count = Convert.ToInt32(dbh.ExecuteScalar(checkQuery, checkParameters));

            if (count > 0)
            {
                
                string updateQuery = "UPDATE BanAn SET SoBan = @TenBA, TrangThai = @TrangThai WHERE MaBan = @MaBA";
                SqlParameter[] updateParameters =
                {
                    new SqlParameter("@MaBA", txtMaBA.Text),
                    new SqlParameter("@TenBA", txtTenBA.Text),
                    new SqlParameter("@TrangThai", cboTrangThai.Text)
                };

                if (dbh.ExecuteNonQuery(updateQuery, updateParameters) > 0)
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Show("Cập nhật thành công!");
                    guna2MessageDialog1.Caption = "Thông báo";
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                }
                else
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Show("Cập nhật thất bại!");
                    guna2MessageDialog1.Caption = "Lỗi";
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                }
            }
            else
            {
                
                string insertQuery = "INSERT INTO BanAn VALUES(@MaBA, @TenBA, @TrangThai)";
                SqlParameter[] insertParameters =
                {
                    new SqlParameter("@MaBA", txtMaBA.Text),
                    new SqlParameter("@TenBA", txtTenBA.Text),
                    new SqlParameter("@TrangThai", cboTrangThai.Text)
                };

                if (dbh.ExecuteNonQuery(insertQuery, insertParameters) > 0)
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Show("Thêm thành công!");
                    guna2MessageDialog1.Caption = "Thông báo";
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                }
                else
                {
                    guna2MessageDialog1.Parent = this;
                    guna2MessageDialog1.Show("Thêm thất bại!");
                    guna2MessageDialog1.Caption = "Lỗi";
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                }
            }

            
            LoadData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanAnAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
