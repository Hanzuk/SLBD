using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;

namespace Capa_Negocios
{
    public class LoadDataBaseCN
    {
        public DataTable LoadDataBases() {
            LoadDataBaseCC oLDBCC = new LoadDataBaseCC();
            return oLDBCC.LoadDataBases();
        }
    }
}
