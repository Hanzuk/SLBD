using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class AnalyzeCN {
        public string LoadDatoMayor(string instanceName, string dbname, string tbname, string schema, string clname) {
            string datoMayor = "";
            foreach (DataRow row in new AnalyzeCC().LoadDatoMayor(instanceName, dbname, tbname, schema, clname).Rows) {
                datoMayor = row[0].ToString();
            }
            return datoMayor;
        }

        public string LoadDatoMenor(string instanceName, string dbname, string tbname, string schema, string clname) {
            string datoMenor = "";
            foreach (DataRow row in new AnalyzeCC().LoadDatoMenor(instanceName, dbname, tbname, schema, clname).Rows) {
                datoMenor = row[0].ToString();
            }
            return datoMenor;
        }

        public string LoadTotalDatos(string instanceName, string dbname, string tbname, string schema, string clname) {
            string totalDatos = "";
            foreach (DataRow row in new AnalyzeCC().LoadTotalDatos(instanceName, dbname, tbname, schema, clname).Rows) {
                totalDatos = row[0].ToString();
            }
            return totalDatos;
        }

        public string PorcentajeDatoNumero(string instanceName, string dbname, string tbname, string schema, string clname)
        {
            string porcentaje = "";
            foreach (DataRow row in new AnalyzeCC().PorcentajeDatoNumero(instanceName, dbname, tbname, schema, clname).Rows)
            {
                porcentaje = row[0].ToString();
            }
            return porcentaje;
        }
    }
}
