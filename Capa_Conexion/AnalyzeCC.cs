using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class AnalyzeCC {
        public DataTable LoadDatoMayor(string instanceName, string dbname, string tbname, string schema, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT MAX({clname}) FROM {dbname}.{schema}.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable LoadDatoMenor(string instanceName, string dbname, string tbname, string schema, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT MIN({clname}) FROM {dbname}.{schema}.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable LoadTotalDatos(string instanceName, string dbname, string tbname, string schema, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT COUNT({clname}) FROM {dbname}.{schema}.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }


        public DataTable PorcentajeDatoNumero(string instanceName, string dbname, string tbname, string schema, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT COUNT({clname}) FROM {dbname}.{schema}.{tbname} WHERE ISNUMERIC({clname}) = 1;";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable PorcentajeDatoLetra(string instanceName, string dbname, string tbname, string schema, string clname)
        {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT COUNT({clname}) FROM {dbname}.{schema}.{tbname} WHERE {clname} not like '%[0-9]%';";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable TipoDato(string instanceName, string dbname, string tbname,string schema, string clname)
        {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT DATA_TYPE FROM {dbname}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TbName;";
            oSQLC.Parameters.Add("@TbName", SqlDbType.VarChar).Value = tbname;
            return oCN.ExecuteQuery(oSQLC);
        }

    }
}
