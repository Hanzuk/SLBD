﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class LoadDataBaseCC {
        public DataTable LoadDataBases(string instance) {
            Connection oCN = new Connection(instance);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.StoredProcedure;
            oSQLC.CommandText = "sp_helpdb";
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}
