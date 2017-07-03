using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class LoadTableCC {
        public DataTable LoadTables(string dbname) {
            Connection oCN = new Connection();
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "SELECT TABLE_NAME FROM " + dbname + ".INFORMATION_SCHEMA.TABLES;";
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
