using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DataHelper
{
    private readonly string connectionString = @"Data Source=LAPTOP-0KCG2R9N\MAYCHUAN;Initial Catalog=RM_CNPM;Integrated Security=True";

    public string ConnectionString
    {
        get { return connectionString; }
    }

    // Phương thức Load dữ liệu vào DataGridView
    public void LoadDataGridView(string query, DataGridView dataGridView)
    {
        try
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Phương thức thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
    public void ExecuteSQL(string query)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thực thi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Phương thức lấy số lượng bản ghi (dùng cho COUNT, SUM, MAX, MIN, v.v.)
    public int GetCount(string query)
    {
        int count = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    count = result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return count;
    }
    public int GetCountWithParams(string query, string username, string password)
    {
        int count = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", username);
                    cmd.Parameters.AddWithValue("@MatKhau", password);

                    object result = cmd.ExecuteScalar();
                    count = result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi kiểm tra tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return count;
    }

}
