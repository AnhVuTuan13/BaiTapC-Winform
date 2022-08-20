using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_Product
{
    public class DAL_de2
    {
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-FTN2SRP;Initial Catalog=DE2;Integrated Security=True");
        }
        public DataTable gettable(string srtsql)
        {
            SqlConnection conn = getconnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(srtsql, conn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dt.Dispose();
            conn.Close();
            return tb;
        }
        public void ExecuteNonQuery(string srtsql)
        {
            SqlConnection conn = getconnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(srtsql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public string xuatten(string srtsql)
        {
            string kq = "";
            SqlConnection conn = getconnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(srtsql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                kq = dt["TenHang"].ToString();
            }
            return kq;
        }
    }
}
