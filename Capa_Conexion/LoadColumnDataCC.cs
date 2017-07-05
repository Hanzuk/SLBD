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
        public DataTable LoadTables(string dbname)
        {
            Connection oCN = new Connection();
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "";
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
