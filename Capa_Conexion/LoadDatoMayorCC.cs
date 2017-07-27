using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion
{
    public class LoadDatoMayorCC
    {
        public DataTable LoadMayor(string instance, string dbname, string tbname, string clname)
        {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT MAX({clname}) FROM {dbname}.dbo.{tbname};";
            //oSQLC.Parameters.Add("@TbName", SqlDbType.VarChar).Value = tbname;
            //oSQLC.Parameters.Add("@column_name", SqlDbType.VarChar).Value = clname;
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
