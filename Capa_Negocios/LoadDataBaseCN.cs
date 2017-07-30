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
        public List<Database> LoadDataBases(string instance) {
            List<Database> listDB = new List<Database>();
            foreach (DataRow row in new LoadDataBaseCC().LoadDataBases(instance).Rows) {
                listDB.Add(new Database {
                    Name = row[0].ToString(),
                    Size = row[1].ToString(),
                    Owner = row[2].ToString(),
                    Created = row[4].ToString()
                });
            }
            return listDB;
        }
    }
}
