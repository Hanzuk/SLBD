using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;

namespace Capa_Negocios {
    public class LoadTableCN {
        public List<string> LoadTables(string dbname) {
            List<string> listables = new List<string>();
            foreach (DataRow row in new LoadTableCC().LoadTables(dbname).Rows) {
                listables.Add(row[0].ToString());
            }
            return listables;
        }
    }
}
