using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public static class Helper {
        public static string CnnStr(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
