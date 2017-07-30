using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class LoadTableCC {
        public DataTable LoadTables(string instance, string dbname) {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE FROM {dbname}.INFORMATION_SCHEMA.TABLES ORDER BY TABLE_SCHEMA ASC;";
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
