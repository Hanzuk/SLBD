﻿using System;
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
        SqlConnection objConnection;

        public Connection(string instance) {
            objConnection = new SqlConnection($"Data Source={instance};Initial Catalog=master;Integrated Security=True");
            //objConnection = new SqlConnection(Helper.CnnStr("Raiden"));
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
            } catch (Exception e) {
                throw e;
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
                return null;
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
