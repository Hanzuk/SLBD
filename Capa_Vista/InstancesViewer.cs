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
using System.Threading;

namespace Capa_Vista {
    public partial class InstancesViewer : MetroFramework.Forms.MetroForm {
        public InstancesViewer() {
            InitializeComponent();
        }

        private async void btnLoadInstances_Click(object sender, EventArgs e) {
            CancellationTokenSource cts = new CancellationTokenSource();
            try {
                cts.CancelAfter(30000);
                panelSpinner.Visible = true;
                btnLoadInstances.Enabled = false;
                btnSetIntance.Enabled = false;
                btnCheckInstance.Enabled = false;
                cboInstances.DataSource = await new LoadInstancesCN().LoadInstances(cts.Token);
                tmSpinner.Start();
                if (cts.IsCancellationRequested) {
                    ErrorDialog.ShowDialog("Ha ocurrido un error al cargar las instancias.");
                    panelSpinner.Visible = false;
                    btnLoadInstances.Enabled = true;
                    btnSetIntance.Enabled = true;
                    btnCheckInstance.Enabled = true;
                    tmSpinner.Stop();
                }
            } catch (OperationCanceledException) {
                ErrorDialog.ShowDialog("Ha ocurrido un error al cargar las instancias.");
            } catch (Exception) {
                ErrorDialog.ShowDialog("Ha ocurrido un error al cargar las instancias.");
            }
        }

        private void btnCheckInstance_Click(object sender, EventArgs e) {
            if (checkInstances.Checked) {
                if (txtInstance.Text.Equals("")) {
                    WarningDialog.ShowDialog("Ingresa tu instancias antes de probar la conexión.");
                } else {
                    if (new LoadInstancesCN().TestConnection(txtInstance.Text)) {
                        SuccessDialog.ShowDialog("No hay ningún problema con la conexión.");
                    } else {
                        ErrorDialog.ShowDialog("Esta ocurriendo un error con la conexión.");
                    }
                }
            } else {
                if (cboInstances.Items.Count == 0) {
                    WarningDialog.ShowDialog("Carga las instancias antes de probar una conexión.");
                } else {
                    if (new LoadInstancesCN().TestConnection(cboInstances.SelectedValue.ToString())) {
                        SuccessDialog.ShowDialog("No hay ningún problema con la conexión.");
                    } else {
                        ErrorDialog.ShowDialog("Esta ocurriendo un error con la conexión.");
                    }
                }
            }
        }

        private void btnSetIntance_Click(object sender, EventArgs e) {
            if (checkInstances.Checked) {
                if (txtInstance.Text.Equals("")) {
                    WarningDialog.ShowDialog("Ingresa tu instancia antes de probar una conexión.");
                } else {
                    MainViewer MW = Application.OpenForms.OfType<MainViewer>().Where(x => x.Name == "MainViewer").SingleOrDefault<MainViewer>();
                    MW.InstanceName = txtInstance.Text;
                    MW.BtnLoadDB.Enabled = true;
                    this.Close();
                }
            } else {
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

        private void checkInstances_CheckedChanged(object sender, EventArgs e) {
            if (checkInstances.Checked) {
                txtInstance.Visible = true;
            } else {
                txtInstance.Visible = false;
            }
        }
    }
}
