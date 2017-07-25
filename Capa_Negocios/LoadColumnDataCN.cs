using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;
using System.Data;

namespace Capa_Negocios{
    public class LoadColumnDataCN {
        public List<string> LoadColumnData(string instance, string dbname, string tbname, string clname){
            List<string> LoadColumnData = new List<string>();
            foreach (DataRow row in new LoadColumnDataCC().LoadColumnData(instance, dbname, tbname, clname).Rows){
                LoadColumnData.Add(row[0].ToString());
            }
            return LoadColumnData;
        }
    }
}
