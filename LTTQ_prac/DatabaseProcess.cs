using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_prac
{
    internal class DatabaseProcess
    {
        string connectionString =
        "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\UTC-ITK64\\LTTQ\\LuyenTap\\LTTQ_prac\\LTTQ_prac\\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public void KetNoiCSDL()
        {
            conn = new SqlConnection(connectionString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void DongKetNoiCSDL()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();

            conn.Dispose();
        }
        public DataTable DocBang(string sql)
        {
            DataTable dt = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            DongKetNoiCSDL();
            return dt;
        }

        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
    }
}
