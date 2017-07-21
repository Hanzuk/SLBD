using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;
using System.Data;

namespace Capa_Negocios {
    public class LoadColumnCN {
        public List<string> LoadColumns(string instance, string dbname, string tbname) {
            List<string> listColumns = new List<string>();
            foreach (DataRow row in new LoadColumnCC().LoadColumns(instance, dbname, tbname).Rows) {
                listColumns.Add(row[0].ToString());
            }
            return listColumns;
        }
    }
}
