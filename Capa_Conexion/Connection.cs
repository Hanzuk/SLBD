using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion
{
    public class Connection
    {
        SqlConnection objConnection = new SqlConnection(Helper.CnnStr("Raiden"));

        public Connection(string instance) {
            objConnection = new SqlConnection($"Data Source={instance};Integrated Security=True");
        }

        private bool OpenConnection() {
            try {
                objConnection.Open();
                return true;
            } catch (Exception) {
                return false;
                throw;
            }
        }

        private bool CloseConnection() {
            try {
                if (objConnection.State == ConnectionState.Closed) {
                    return true;
                }
                objConnection.Close();
                return true;
            } catch (Exception) {
                throw;
            } finally {
                objConnection.Close();
            }
        }

        public DataTable ExecuteQuery(SqlCommand oSQLC) {
            try {
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);
                oSQLC.Connection = objConnection;
                if (OpenConnection()) {
                    oSQLDA.Fill(oDT);
                }
                CloseConnection();
                return oDT;
            } catch (SqlException e) {
                throw e;
            }
        }

        public bool TestConnection() {
            if (OpenConnection()) {
                CloseConnection();
                return true;
            } else {
                CloseConnection();
                return false;
            }
        }

        public DataTable LoadInstances() {
            return SqlDataSourceEnumerator.Instance.GetDataSources();
        }
    }
}
