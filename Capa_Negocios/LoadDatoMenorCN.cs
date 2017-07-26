using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class LoadDatoMenorCN
    {
        public List<string> LoadMenor(string instance, string dbname, string tbname, string clname)
        {
            List<string> listMenor = new List<string>();
            foreach (DataRow row in new LoadDatoMenorCC().LoadMenor(instance, dbname, tbname, clname).Rows)
            {
                listMenor.Add(row[0].ToString());
            }
            return listMenor;
        }
    }
}
