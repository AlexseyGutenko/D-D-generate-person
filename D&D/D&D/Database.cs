using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
namespace D_D
{
    internal class DataBase
    {
        SqlConnection SqlConnection=new SqlConnection(@"Data Source=DESKTOP-ASMODEUS13;Initial Catalog=test;Integrated Security=True");
        public void OpenConection()
        {
            if (SqlConnection.State==System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void CloseConection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() { return SqlConnection; }
    }
}
