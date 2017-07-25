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
        public DataTable LoadColumnData(string instance, string dbname, string tbname, string clname)
        {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "SELECT MAX(@column_name),MIN(@column_name),Count(@column_name) FROM " + dbname + "WHERE TABLE_NAME = @TbName AND COLUMN_NAME = '@column_name';";
            oSQLC.Parameters.Add("@TbName", SqlDbType.VarChar).Value = tbname;
            oSQLC.Parameters.Add("@column_name", SqlDbType.VarChar).Value = clname;
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
