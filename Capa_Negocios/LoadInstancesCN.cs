using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class LoadInstancesCN {
        public Task<List<string>> LoadInstances() {
            return Task.Run(() => {
                List<string> ListIntances = new List<string>();
                foreach (DataRow row in new LoadInstancesCC().LoadInstances().Rows) {
                    string connectionString = row["ServerName"] + "\\" + row["InstanceName"];
                    ListIntances.Add(connectionString);
                }
                return ListIntances;
            });
        }

        public bool TestConnection(string instance) {
            return new Connection(instance).TestConnection();
        }
    }
}
