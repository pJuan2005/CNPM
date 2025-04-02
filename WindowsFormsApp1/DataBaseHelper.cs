using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DatabaseHelper
    {
        private static readonly string connString = "Data Source=TUNG\\SQLEXPRESS;Initial Catalog=RM_CNPM;Integrated Security=True;TrustServerCertificate=True";
        private readonly SqlConnection connection;

        public DatabaseHelper()
        {
            connection = new SqlConnection(connString);
        }

        public SqlConnection GetSqlConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                int rowsAffected = cmd.ExecuteNonQuery();
                CloseConnection();
                return rowsAffected;
            }
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CloseConnection();
                    return dt;
                }
            }
        }
        public DataTable GetNhanVienList()
        {
            string query = "SELECT MaNV, TenNV FROM NhanVien";
            return ExecuteQuery(query);
        }

        public DataTable GetKhachHangList()
        {
            string query = "SELECT MaKH, TenKH FROM KhachHang";
            return ExecuteQuery(query);
        }

        public DataTable GetBanAnList()
        {
            string query = "SELECT MaBan, SoBan FROM BanAn WHERE TrangThai <> N'Đã đặt'";
            return ExecuteQuery(query);
        }
        public DataTable GetTrangThaiList()
        {
            string query = "SELECT TrangThai FROM DonHang";
            return ExecuteQuery(query);
        }
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    connection.Open();
                    return command.ExecuteScalar(); // Thực thi câu lệnh và trả về giá trị đầu tiên
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

    }
}