using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;

namespace Capa_Negocios {
    public class LoadTableCN {
        public DataTable LoadTables(string dbname) {
            LoadTableCC oLTCC = new LoadTableCC();
            return oLTCC.LoadTables(dbname);
        }
    }
}
