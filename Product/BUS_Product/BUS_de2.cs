using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Product;
namespace BUS_Product
{
    public  class BUS_de2
    {
        DAL_de2 dal = new DAL_de2();

        public DataTable showdgv()
        {
              string srtsql = "select  Mahang,Tenhang, nhasanxuat,ngaynhapkho,soluongcon from Product";
           
            return dal.gettable(srtsql);
        }
        public DataTable showcb()
        {
            string srtsql = "select *from Category";
            return dal.gettable(srtsql);
        }
        public void InsertSql(string mah,string tenh,string nsx, string ngaynhap, string sl,string macl)
        {
            string srtsql = "Insert into Product values ('" + mah + "',N'" + tenh + "',N'" +nsx+ "','" + ngaynhap + "','" + sl +"','"+macl+ "')";
            dal.ExecuteNonQuery(srtsql);
        }
        public void DeleteSql(string mah)
        {
            string srtsql = "Delete Product Where Mahang='" + mah + "'";
            dal.ExecuteNonQuery(srtsql);
        }
        public bool checkhang(string mah)
        {
            string srtsql= "select *from Product Where Mahang='" + mah + "'";
            DataTable tb = new DataTable();
            tb = dal.gettable(srtsql);
            if (tb.Rows.Count == 0)
                return true;
            else
                return false;
        }
        public string ten(string Ma)
        {
            string Maout = "select Tenchungloai from Category where Machungloai='" + Ma + "'";
            return dal.xuatten(Maout);
        }
    }
}
