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
using System.Data.SqlClient;

namespace Capa_Vista
{
    public partial class MainViewer : MetroFramework.Forms.MetroForm
    {

        public string InstanceName { get; set; }
        public int con = 0;
        public MainViewer() {
            InitializeComponent();
        }

        List<Database> listDB = new List<Database>();
        List<Table> listTB = new List<Table>();
        List<Reporte> Detalle = new List<Reporte>();
        
        private void btnLoadDB_Click(object sender, EventArgs e) {
            listDB = new LoadDataBaseCN().LoadDataBases(InstanceName);
            cboDBList.DisplayMember = "Name";
            cboDBList.ValueMember = "Name";
            cboDBList.DataSource = listDB;
            btnLoadDB.Visible = false;
            btnLoadTables.Enabled = true;
            foreach (Database item in listDB) {
                if (item.Name == cboDBList.SelectedValue.ToString()) {
                    lbOwner.Text = $"Owner:   {item.Owner}";
                    lbSize.Text = $"Size:{item.Size}";
                    lbCreated.Text = $"Created:   {item.Created}";
                }
            }
        }

        private void btnLoadTables_Click(object sender, EventArgs e) {
            listTB = new LoadTableCN().LoadTables(InstanceName, cboDBList.SelectedValue.ToString());
            if (listTB.Count > 0) {
                cboTables.DisplayMember = "Name";
                cboTables.ValueMember = "Name";
                cboTables.DataSource = listTB;
                cboTables.Enabled = true;
                btnLoadTables.Enabled = false;
                btnLoadColumns.Enabled = true;
                lbTotalTables.Text = "Total de tablas encontradas: " + listTB.Count.ToString();
                foreach (Table item in listTB) {
                    if (item.Name.Equals(cboTables.SelectedValue.ToString())) {
                        lbTableSchema.Text = $"Table Schema:   {item.Schema}";
                        lbTableType.Text = $"Table Type:   {item.Type}";
                    }
                }
            } else {
                ErrorDialog.ShowDialog("¡No existen tablas para esta Base de Datos!");
            }
        }

        private void btnLoadColumns_Click(object sender, EventArgs e) {
            List<string> listColumns = new LoadColumnCN().LoadColumns(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString());
            listbColumns.DataSource = listColumns;
            listbColumns.Visible = true;
        }

        private void cboDBList_SelectedValueChanged(object sender, EventArgs e) {
            foreach (Database item in listDB) {
                if (cboDBList.Items.Count > 0) {
                    if (item.Name == cboDBList.SelectedValue.ToString()) {
                        lbOwner.Text = $"Owner:   {item.Owner}";
                        lbSize.Text = $"Size:{item.Size}";
                        lbCreated.Text = $"Created:   {item.Created}";
                    }
                }
            }
            //Para limpiar el ComboBox que carga las tablas.
            cboTables.DataSource = null;
            cboTables.Enabled = false;
            cboTables.Items.Clear();

            //Limpia el Label que carga el total de tablas, el schema y el tipo.
            lbTotalTables.Text = "";
            lbTableSchema.Text = "";
            lbTableType.Text = "";

            //Oculta y limpia el ListBox que carga las columnas.
            listbColumns.Visible = false;
            listbColumns.DataSource = null;
            listbColumns.Items.Clear();

            //Dasabilita los botones de cargar tablas y columnas.
            btnLoadTables.Enabled = true;
            btnLoadColumns.Enabled = false;
        }

        private void cboTables_SelectedValueChanged(object sender, EventArgs e) {
            if (cboTables.SelectedValue != null) {
                foreach (Table item in listTB) {
                    if (cboTables.Items.Count > 0) {
                        if (item.Name == cboTables.SelectedValue.ToString()) {
                            lbTableSchema.Text = $"Table Schema:   {item.Schema}";
                            lbTableType.Text = $"Table Type:   {item.Type}";                          
                        }
                    }
                }
            }
        }

        private void btnAnalyzeColumn_Click(object sender, EventArgs e) {
            AnalyzeCN oACN = new AnalyzeCN();
            DatoMayor(oACN);
            DatoMenor(oACN);
            TotalDatos(oACN);
            Porcentaje(oACN);
            PorcentajeLetra(oACN);
            GuardarDetalle();
        }

        public void DatoMayor(AnalyzeCN objectACN) {
            string schema = "";
            foreach (Table item in listTB) {
                if (item.Name.Equals(cboTables.SelectedValue.ToString())) {
                    schema = item.Schema;
                }
            }
            lbDatoMayor.Text = objectACN.LoadDatoMayor(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(), schema, listbColumns.SelectedValue.ToString());
        }

        public void DatoMenor(AnalyzeCN objectACN) {
            string schema = "";
            foreach (Table item in listTB) {
                if (item.Name.Equals(cboTables.SelectedValue.ToString())) {
                    schema = item.Schema;
                }
            }
            lbDatoMenor.Text = objectACN.LoadDatoMenor(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(), schema, listbColumns.SelectedValue.ToString());
        }

        public void TotalDatos(AnalyzeCN objectACN) {
            string schema = "";
            foreach (Table item in listTB) {
                if (item.Name.Equals(cboTables.SelectedValue.ToString())) {
                    schema = item.Schema;
                }
            }
            lbTotalDatos.Text = objectACN.LoadTotalDatos(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(), schema, listbColumns.SelectedValue.ToString());
        }

        public void Porcentaje(AnalyzeCN objectACN)
        {
            string schema = "";
            int num;
            int total;
            int resultado;
            string nuevoelemento;
            foreach (Table item in listTB) {
                if (item.Name.Equals(cboTables.SelectedValue.ToString())) {
                    schema = item.Schema;
                }
            }
            lbPorcentaje.Text = objectACN.PorcentajeDatoNumero(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(), schema, listbColumns.SelectedValue.ToString());
            num = int.Parse(lbPorcentaje.Text);
            total = int.Parse(lbTotalDatos.Text);
            resultado = num * 100 / total;
            nuevoelemento = resultado.ToString() + '%';
            lbpornum.Text = nuevoelemento;
        }

        public void PorcentajeLetra(AnalyzeCN objectACN)
        {
            string schema = "";
            int num;
            int total;
            int resultado;
            string nuevoelemento;
            foreach (Table item in listTB)
            {
                if (item.Name.Equals(cboTables.SelectedValue.ToString()))
                {
                    schema = item.Schema;
                }
            }
            lbLetras.Text = objectACN.PorcentajeDatoletra(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(), schema, listbColumns.SelectedValue.ToString());
            num = int.Parse(lbLetras.Text);
            total = int.Parse(lbTotalDatos.Text);
            resultado = num * 100 / total;
            nuevoelemento = resultado.ToString() + '%';
            lbporlet.Text = nuevoelemento;
        }

        private void btnSearchInstances_Click(object sender, EventArgs e) {
            //Valida si el formulario ya esta abierto.
            Form existe = Application.OpenForms.OfType<Form>().Where(x => x.Name == "InstancesViewer").SingleOrDefault<Form>();
            if (existe != null) {
                existe.BringToFront();
            } else {
                InstancesViewer IW = new InstancesViewer();
                IW.Show();
            }
        }

        private void TipoDato(AnalyzeCN objectACN) {
            string schema = "";
            foreach (Table item in listTB)
            {
                if (item.Name.Equals(cboTables.SelectedValue.ToString()))
                {
                    schema = item.Schema;
                }
            }
            //lbTotalDatos.Text = objectACN.TipoDatos(instance, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString(),listbColumns.SelectedValue.ToString());
        }


        private void listbColumns_SelectedIndexChanged(object sender, EventArgs e){
            btnAnalyzeColumn.Enabled = true;
        }

        public void GuardarDetalle()
        {
            if (!Detalle.Any(x => x.CLName == listbColumns.SelectedValue.ToString())) {
                Detalle.Add(new Reporte {
                    DBName = cboDBList.SelectedValue.ToString(),
                    TBName = cboTables.SelectedValue.ToString(),
                    CLName = listbColumns.SelectedValue.ToString()
                });
            }
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            libTAnalizada.DataSource = Detalle.Select(x => x.TBName).Distinct().ToList();
        }

        private void libTAnalizada_SelectedValueChanged(object sender, EventArgs e) {
            dgvDetalles.DataSource = Detalle.Where(x => x.TBName == libTAnalizada.SelectedValue.ToString()).ToList();
        }
    }
}

    
