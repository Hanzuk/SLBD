using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class LoadDatoMayorCN
    {
        public List<string> LoadMayor(string instance, string dbname, string tbname, string clname)
        {
            List<string> listMayor = new List<string>();
            foreach (DataRow row in new LoadDatoMayorCC().LoadMayor(instance, dbname, tbname, clname).Rows)
            {
                listMayor.Add(row[0].ToString());
            }
            return listMayor;
        }
    }
}
