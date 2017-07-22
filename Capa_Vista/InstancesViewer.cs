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

        private async void btnLoadInstances_Click(object sender, EventArgs e) {
            LoadInstancesCN oLICN = new LoadInstancesCN();
            panelSpinner.Visible = true;
            btnLoadInstances.Enabled = false;
            btnSetIntance.Enabled = false;
            btnCheckInstance.Enabled = false;
            cboInstances.DataSource = await oLICN.LoadInstances();
            tmSpinner.Start();
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

        int expansion = 1;
        private void tmSpinner_Tick(object sender, EventArgs e) {
            if (cboInstances.Items.Count > 0) {
                tmSpinner.Stop();
                panelSpinner.Visible = false;
                btnLoadInstances.Enabled = true;
                btnSetIntance.Enabled = true;
                btnCheckInstance.Enabled = true;
            } else {
                if (Spinner.Value == 100) {
                    expansion = -1;
                    Spinner.Speed = 1.9F;
                } else if (Spinner.Value == 10) {
                    expansion = +1;
                    Spinner.Speed = 0.5F;
                }
                Spinner.Value += expansion;
            }
        }
    }
}
