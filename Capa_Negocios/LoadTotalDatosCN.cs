using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class LoadTotalDatosCN
    {
        public List<string> LoadTotal(string instance, string dbname, string tbname, string clname)
        {
            List<string> listTotal = new List<string>();
            foreach (DataRow row in new LoadTotalDatosCC().LoadTotal(instance, dbname, tbname, clname).Rows)
            {
                listTotal.Add(row[0].ToString());
            }
            return listTotal;
        }
    }
}
