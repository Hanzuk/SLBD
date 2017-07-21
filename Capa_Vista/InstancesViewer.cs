using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Vista {
    public partial class InstancesViewer : MetroFramework.Forms.MetroForm {
        public InstancesViewer() {
            InitializeComponent();
        }

        private void btnLoadInstances_Click(object sender, EventArgs e) {
            cboInstances.DataSource = new LoadInstancesCN().LoadInstances();
        }

        private void btnCheckInstance_Click(object sender, EventArgs e) {
            if (cboInstances.Items.Count == 0) {
                WarningDialog.ShowDialog("Carga las instancias antes de probar una conexión.");
            } else {
                if (new LoadInstancesCN().TestConnection(cboInstances.SelectedValue.ToString())) {
                    SuccessDialog.ShowDialog("No hay ningún problema con la conexión.");
                } else {
                    MessageBox.Show("Conexion fallida.");
                }
            }
        }

        private void btnSetIntance_Click(object sender, EventArgs e) {
            if (cboInstances.Items.Count == 0) {
                WarningDialog.ShowDialog("Carga las instancias antes de probar una conexión.");
            } else {
                //Busca el Formulario principal
                MainViewer MW = Application.OpenForms.OfType<MainViewer>().Where(x => x.Name == "MainViewer").SingleOrDefault<MainViewer>();
                MW.InstanceName = cboInstances.SelectedValue.ToString();
                MW.BtnLoadDB.Enabled = true;
                this.Close();
            }
        }
    }
}
