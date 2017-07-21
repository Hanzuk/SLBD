using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class LoadColumnCC {
        public DataTable LoadColumns(string instance, string dbname, string tbname) {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "SELECT COLUMN_NAME FROM " + dbname + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TbName;";
            oSQLC.Parameters.Add("@TbName", SqlDbType.VarChar).Value = tbname;
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
