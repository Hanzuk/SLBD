using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class LoadInstancesCC {
        public DataTable LoadInstances() {
            return new Connection(null).LoadInstances();
        }
    }
}
