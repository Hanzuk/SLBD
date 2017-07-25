using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion
{
    public class LoadColumnDataCC
    {
        public DataTable LoadColumnData(string instance, string dbname, string tbname)
        {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "SELECT COLUMN_NAME, "+"DATA_TYPE, "+"CHARACTER_MAXIMUM_LENGTH, "+"IS_NULLABLE ,"+" FROM" + dbname + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TbName;";
            oSQLC.Parameters.Add("@TbName", SqlDbType.VarChar).Value = tbname;
            SqlDataReader sqlDr = oSQLC.ExecuteReader();
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
