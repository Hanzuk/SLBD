using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;

namespace Capa_Negocios {
    public class LoadTableCN {
        public List<Table> LoadTables(string instance, string dbname) {
            List<Table> listDB = new List<Table>();
            foreach (DataRow row in new LoadTableCC().LoadTables(instance, dbname).Rows) {
                listDB.Add(new Table {
                    Schema = row[0].ToString(),
                    Name = row[1].ToString(),
                    Type = row[2].ToString()
                });
            }
            return listDB;
        }
    }
}
