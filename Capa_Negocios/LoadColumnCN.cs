using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;
using System.Data;

namespace Capa_Negocios {
    public class LoadColumnCN {
        public DataTable LoadColumns(string dbname, string tbname) {
            LoadColumnCC oLCCC = new LoadColumnCC();
            return oLCCC.LoadColumns(dbname, tbname);
        }
    }
}
