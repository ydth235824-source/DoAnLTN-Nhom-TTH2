using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAnMonHoc
{
    class DataProvider
    {
        SqlConnection conn = new SqlConnection();
        public SqlConnection MoKetNoi()
        {            
            conn.ConnectionString = @"Data Source=(local);Initial Catalog=QLNV;Integrated Security=True";
            return conn;            
        }
    }
}
