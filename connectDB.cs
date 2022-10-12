using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PrivateSchoolWF
{
    public class connectDB
    {
        static string sqlcon_str = "server=localhost; port=3306; Uid=root; password=''; database=private_school; SslMode=none; ConvertZeroDatetime=True";
        MySqlConnection mysqlCon = new MySqlConnection(sqlcon_str);

        public void openCon()
        {
            if (mysqlCon.State == System.Data.ConnectionState.Closed)
            {
                mysqlCon.Open();
            }
        }

        public void closeCon()
        {
            if (mysqlCon.State == System.Data.ConnectionState.Open)
            {
                mysqlCon.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return mysqlCon;
        }
    }
}
