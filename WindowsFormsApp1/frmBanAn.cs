using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBanAn : Form
    {
        public frmBanAn()
        {
            InitializeComponent();
        }

        DatabaseHelper dbh = new DatabaseHelper();
        private bool isDeleting = false;

        public void LoadData()
        {
            string query = "SELECT * FROM BanAn";
            
            dgBanAn.DataSource = dbh.ExecuteQuery(query);
        }

        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            frmBanAnAdd frmnv = new frmBanAnAdd();
            frmnv.ShowDialog();

          
            LoadData();
        }

        private void dgBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columnName = dgBanAn.Columns[e.ColumnIndex].Name;

            if (columnName == "dgcEdit")
            {
                
                string maMon = dgBanAn.CurrentRow.Cells["dgcMaBA"].Value.ToString();
                string tenMon = dgBanAn.CurrentRow.Cells["dgcTen"].Value.ToString();
                string tt = dgBanAn.CurrentRow.Cells["dgcTrangThai"].Value.ToString();

               
                frmBanAnAdd fbaa = new frmBanAnAdd();
                fbaa.SetBanAnData(maMon, tenMon, tt);
                fbaa.ShowDialog();
                LoadData();
            }
            else if (columnName == "dgcDelete")
            {
                    DeleteBanAn();
                    LoadData();
               
            }
        }

        private void DeleteBanAn()
        {
            if (dgBanAn.CurrentRow == null) return;

            string maBan = dgBanAn.CurrentRow.Cells["dgcMaBA"].Value.ToString();
            string query = "DELETE FROM BanAn WHERE MaBan = @MaBA";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaBA", maBan)
            };

            if (dbh.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string SelectedBanID { get; private set; }

        private void btnChonBan_Click(object sender, EventArgs e)
        {
            if (dgBanAn.SelectedRows.Count > 0)
            {
                SelectedBanID = dgBanAn.SelectedRows[0].Cells["dgcMaBA"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmBanAn_Load(object sender, EventArgs e)
        {
            dgBanAn.AllowUserToAddRows = false;
            dgBanAn.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgBanAn.Columns["dgcMaBA"].DataPropertyName = "MaBan";
            dgBanAn.Columns["dgcTen"].DataPropertyName = "SoBan";
            dgBanAn.Columns["dgcTrangThai"].DataPropertyName = "TrangThai";
            LoadData();
        }
    }
}
