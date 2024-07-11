using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TerziOlcuOtomasyonu
{
    class sql
    {
        public SqlConnection baglanti()
        {

            SqlConnection sqlbaglanti = new SqlConnection(@"Data Source=HACKER\SQLEXPRESS;Initial Catalog=terzitb;Integrated Security=True");
            sqlbaglanti.Open();
            return sqlbaglanti;

        }
    }
}
