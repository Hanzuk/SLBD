using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Conexion;

namespace Capa_Negocios
{
    class LoadColumnDataCN
    {
        public List<string> LoadColumns(string instance, string dbname, string tbname)
        {
            List<string> listColumns = new List<string>();
            foreach (DataRow row in new LoadColumnDataCC().LoadColumnData(instance, dbname, tbname).Rows)
            {
                listColumns.Add(row[0].ToString());
            }
            return listColumns;
        }
    }
}
