using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class LoadInstancesCN {
        public Task<List<string>> LoadInstances(CancellationToken ct) {
            return Task.Run(() => {
                List<string> ListIntances = new List<string>();
                foreach (DataRow row in new LoadInstancesCC().LoadInstances().Rows) {
                    string serverName;
                    string instanceName = row["InstanceName"].ToString();
                    if (!string.IsNullOrEmpty(instanceName)) {
                        serverName = row["ServerName"] + "\\" + row["InstanceName"];
                    } else {
                        serverName = row["ServerName"].ToString();
                    }
                    ListIntances.Add(serverName);
                    //string connectionString = row["ServerName"] + "\\" + row["InstanceName"];
                    //ListIntances.Add(connectionString);
                }
                return ListIntances;
            });
        }

        public bool TestConnection(string instance) {
            return new Connection(instance).TestConnection();
        }
    }
}
