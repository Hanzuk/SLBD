using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class AnalyzeCN {
        public List<string> LoadDatoMayor(string instanceName, string dbname, string tbname, string clname) {
            List<string> listMayor = new List<string>();
            foreach (DataRow row in new AnalyzeCC().LoadDatoMayor(instanceName, dbname, tbname, clname).Rows) {
                listMayor.Add(row[0].ToString());
            }
            return listMayor;
        }

        public List<string> LoadDatoMenor(string instanceName, string dbname, string tbname, string clname) {
            List<string> listMayor = new List<string>();
            foreach (DataRow row in new AnalyzeCC().LoadDatoMenor(instanceName, dbname, tbname, clname).Rows) {
                listMayor.Add(row[0].ToString());
            }
            return listMayor;
        }

        public List<string> LoadTotalDatos(string instanceName, string dbname, string tbname, string clname) {
            List<string> listTotal = new List<string>();
            foreach (DataRow row in new LoadTotalDatosCC().LoadTotal(instanceName, dbname, tbname, clname).Rows) {
                listTotal.Add(row[0].ToString());
            }
            return listTotal;
        }
    }
}
