using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach2
{
    internal class Ketnoi
    {
        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TGDRMFOH;Initial Catalog=QuanLyNhaSach1;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
