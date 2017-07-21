﻿using System;
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
    public partial class MainViewer : MetroFramework.Forms.MetroForm {

        public string InstanceName { get; set; }
        public MainViewer(string instanceName) {
            InitializeComponent();
            InstanceName = instanceName;
        }

        DataTable oDTDB;
        private void btnLoadDB_Click(object sender, EventArgs e) {
            oDTDB = new LoadDataBaseCN().LoadDataBases(InstanceName);
            cboDBList.DisplayMember = "name";
            cboDBList.ValueMember = "name";
            cboDBList.DataSource = oDTDB;
            btnLoadDB.Visible = false;
            btnLoadTables.Enabled = true;
            foreach (DataRow row in oDTDB.Rows) {
                if (row[0].ToString() == cboDBList.SelectedValue.ToString()) {
                    lbOwner.Text = "Owner:   " + row[2].ToString();
                    lbSize.Text = "Size:" + row[1].ToString();
                    lbCreated.Text = "Created:   " + row[4].ToString();
                }
            }
        }

        private void btnLoadTables_Click(object sender, EventArgs e) {
            List<string> listable = new LoadTableCN().LoadTables(InstanceName, cboDBList.SelectedValue.ToString());
            if (listable.Count > 0) {
                cboTables.DataSource = listable;
                cboTables.Enabled = true;
                lbTotalTables.Text = "Total de tablas encontradas: " + listable.Count.ToString();
                btnLoadTables.Enabled = false;
                btnLoadColumns.Enabled = true;
            } else {
                WarningDialog.ShowDialog("¡No existen tablas para esta Base de Datos!");
            }
        }

        private void btnLoadColumns_Click(object sender, EventArgs e) {
            List<string> listColumns = new LoadColumnCN().LoadColumns(InstanceName, cboDBList.SelectedValue.ToString(), cboTables.SelectedValue.ToString());
            listbColumns.DataSource = listColumns;
            listbColumns.Visible = true;
        }

        private void cboDBList_SelectedValueChanged(object sender, EventArgs e) {
            foreach (DataRow row in oDTDB.Rows) {
                if (cboDBList.Items.Count > 0) {
                    if (row[0].ToString() == cboDBList.SelectedValue.ToString()) {
                        lbOwner.Text = "Owner:   " + row[2].ToString();
                        lbSize.Text = "Size:" + row[1].ToString();
                        lbCreated.Text = "Created:   " + row[4].ToString();
                    }
                }
            }
            //Para limpiar el ComboBox que carga las tablas.
            cboTables.DataSource = null;
            cboTables.Enabled = false;
            cboTables.Items.Clear();

            //Limpia el Label que carga el total de tablas.
            lbTotalTables.Text = "";

            //Oculta y limpia el ListBox que carga las columnas.
            listbColumns.Visible = false;
            listbColumns.DataSource = null;
            listbColumns.Items.Clear();

            //Dasabilita los botones de cargar tablas y columnas.
            btnLoadTables.Enabled = true;
            btnLoadColumns.Enabled = false;
        }

        private void btnAnalyzeColumn_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchInstances_Click(object sender, EventArgs e) {
            Form existe = Application.OpenForms.OfType<Form>().Where(x => x.Name == "InstancesViewer").SingleOrDefault<Form>();
            if (existe != null) {
                existe.Show();
            }
        }

        private void MainViewer_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
