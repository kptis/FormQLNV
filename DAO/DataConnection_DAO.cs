using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class DataConnection_DAO
     {
          string conn;
          public DataConnection_DAO()
          {
               conn = System.Configuration.ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

          }
          public SqlConnection getConnect()
          {
               return new SqlConnection(conn);
          }

}
}
