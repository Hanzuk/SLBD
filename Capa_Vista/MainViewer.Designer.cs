using System.Windows.Forms;

namespace Capa_Vista {
    partial class MainViewer {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewer));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSearchInstances = new System.Windows.Forms.Button();
            this.pResultado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnalyzeColumn = new System.Windows.Forms.Button();
            this.listbColumns = new System.Windows.Forms.ListBox();
            this.btnLoadColumns = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbTotalTables = new System.Windows.Forms.Label();
            this.btnLoadTables = new System.Windows.Forms.Button();
            this.cboTables = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.lbCreated = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.cboDBList = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.pResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(204, 43);
            this.metroTabControl1.Location = new System.Drawing.Point(45, 100);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1280, 657);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnSearchInstances);
            this.metroTabPage1.Controls.Add(this.pResultado);
            this.metroTabPage1.Controls.Add(this.btnAnalyzeColumn);
            this.metroTabPage1.Controls.Add(this.listbColumns);
            this.metroTabPage1.Controls.Add(this.btnLoadColumns);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.pictureBox3);
            this.metroTabPage1.Controls.Add(this.lbTotalTables);
            this.metroTabPage1.Controls.Add(this.btnLoadTables);
            this.metroTabPage1.Controls.Add(this.cboTables);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.btnLoadDB);
            this.metroTabPage1.Controls.Add(this.lbCreated);
            this.metroTabPage1.Controls.Add(this.lbSize);
            this.metroTabPage1.Controls.Add(this.lbOwner);
            this.metroTabPage1.Controls.Add(this.cboDBList);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.ForeColor = System.Drawing.Color.White;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 9;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1272, 606);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Analizar base de datos";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnSearchInstances
            // 
            this.btnSearchInstances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchInstances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnSearchInstances.FlatAppearance.BorderSize = 0;
            this.btnSearchInstances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnSearchInstances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInstances.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInstances.ForeColor = System.Drawing.Color.White;
            this.btnSearchInstances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInstances.Location = new System.Drawing.Point(1037, 22);
            this.btnSearchInstances.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInstances.Name = "btnSearchInstances";
            this.btnSearchInstances.Size = new System.Drawing.Size(230, 51);
            this.btnSearchInstances.TabIndex = 60;
            this.btnSearchInstances.Text = "Buscar o cambiar instancia";
            this.btnSearchInstances.UseVisualStyleBackColor = false;
            this.btnSearchInstances.Click += new System.EventHandler(this.btnSearchInstances_Click);
            // 
            // pResultado
            // 
            this.pResultado.BackColor = System.Drawing.Color.Transparent;
            this.pResultado.Controls.Add(this.label6);
            this.pResultado.Controls.Add(this.label5);
            this.pResultado.Controls.Add(this.label7);
            this.pResultado.Controls.Add(this.label9);
            this.pResultado.Controls.Add(this.label8);
            this.pResultado.Location = new System.Drawing.Point(586, 351);
            this.pResultado.Margin = new System.Windows.Forms.Padding(4);
            this.pResultado.Name = "pResultado";
            this.pResultado.Size = new System.Drawing.Size(681, 242);
            this.pResultado.TabIndex = 59;
            this.pResultado.Paint += new System.Windows.Forms.PaintEventHandler(this.pResultado_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre de la columna:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Columna analizada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(10, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de dato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(10, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Is Null:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(10, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Máximo caracteres permitidos:";
            // 
            // btnAnalyzeColumn
            // 
            this.btnAnalyzeColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnAnalyzeColumn.Enabled = false;
            this.btnAnalyzeColumn.FlatAppearance.BorderSize = 0;
            this.btnAnalyzeColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnAnalyzeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyzeColumn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyzeColumn.ForeColor = System.Drawing.Color.White;
            this.btnAnalyzeColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyzeColumn.Location = new System.Drawing.Point(734, 255);
            this.btnAnalyzeColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyzeColumn.Name = "btnAnalyzeColumn";
            this.btnAnalyzeColumn.Size = new System.Drawing.Size(180, 51);
            this.btnAnalyzeColumn.TabIndex = 58;
            this.btnAnalyzeColumn.Text = "Analizar columna";
            this.btnAnalyzeColumn.UseVisualStyleBackColor = false;
            this.btnAnalyzeColumn.Click += new System.EventHandler(this.btnAnalyzeColumn_Click);
            // 
            // listbColumns
            // 
            this.listbColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listbColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbColumns.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbColumns.ForeColor = System.Drawing.Color.Silver;
            this.listbColumns.FormattingEnabled = true;
            this.listbColumns.ItemHeight = 20;
            this.listbColumns.Location = new System.Drawing.Point(4, 399);
            this.listbColumns.Margin = new System.Windows.Forms.Padding(4);
            this.listbColumns.Name = "listbColumns";
            this.listbColumns.Size = new System.Drawing.Size(371, 200);
            this.listbColumns.TabIndex = 57;
            this.listbColumns.Visible = false;
            this.listbColumns.SelectedIndexChanged += new System.EventHandler(this.listbColumns_SelectedIndexChanged);
            // 
            // btnLoadColumns
            // 
            this.btnLoadColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnLoadColumns.Enabled = false;
            this.btnLoadColumns.FlatAppearance.BorderSize = 0;
            this.btnLoadColumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnLoadColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadColumns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadColumns.ForeColor = System.Drawing.Color.White;
            this.btnLoadColumns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadColumns.Location = new System.Drawing.Point(4, 325);
            this.btnLoadColumns.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadColumns.Name = "btnLoadColumns";
            this.btnLoadColumns.Size = new System.Drawing.Size(372, 51);
            this.btnLoadColumns.TabIndex = 56;
            this.btnLoadColumns.Text = "Buscar columnas";
            this.btnLoadColumns.UseVisualStyleBackColor = false;
            this.btnLoadColumns.Click += new System.EventHandler(this.btnLoadColumns_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(68, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Columnas de la tabla";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Capa_Vista.Properties.Resources.column;
            this.pictureBox3.Location = new System.Drawing.Point(4, 260);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // lbTotalTables
            // 
            this.lbTotalTables.AutoSize = true;
            this.lbTotalTables.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalTables.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTables.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTotalTables.Location = new System.Drawing.Point(678, 158);
            this.lbTotalTables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalTables.Name = "lbTotalTables";
            this.lbTotalTables.Size = new System.Drawing.Size(0, 19);
            this.lbTotalTables.TabIndex = 53;
            // 
            // btnLoadTables
            // 
            this.btnLoadTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnLoadTables.Enabled = false;
            this.btnLoadTables.FlatAppearance.BorderSize = 0;
            this.btnLoadTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnLoadTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTables.ForeColor = System.Drawing.Color.White;
            this.btnLoadTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadTables.Location = new System.Drawing.Point(1037, 135);
            this.btnLoadTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTables.Name = "btnLoadTables";
            this.btnLoadTables.Size = new System.Drawing.Size(230, 51);
            this.btnLoadTables.TabIndex = 52;
            this.btnLoadTables.Text = "Buscar tablas";
            this.btnLoadTables.UseVisualStyleBackColor = false;
            this.btnLoadTables.Click += new System.EventHandler(this.btnLoadTables_Click);
            // 
            // cboTables
            // 
            this.cboTables.BackColor = System.Drawing.Color.Transparent;
            this.cboTables.Enabled = false;
            this.cboTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTables.ForeColor = System.Drawing.Color.White;
            this.cboTables.FormattingEnabled = true;
            this.cboTables.ItemHeight = 23;
            this.cboTables.Location = new System.Drawing.Point(259, 150);
            this.cboTables.Margin = new System.Windows.Forms.Padding(4);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(405, 29);
            this.cboTables.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboTables.TabIndex = 51;
            this.cboTables.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboTables.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(68, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tablas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Capa_Vista.Properties.Resources.table_grid;
            this.pictureBox2.Location = new System.Drawing.Point(4, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(4, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 2);
            this.panel1.TabIndex = 48;
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnLoadDB.Enabled = false;
            this.btnLoadDB.FlatAppearance.BorderSize = 0;
            this.btnLoadDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnLoadDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDB.ForeColor = System.Drawing.Color.White;
            this.btnLoadDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDB.Location = new System.Drawing.Point(773, 22);
            this.btnLoadDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(230, 51);
            this.btnLoadDB.TabIndex = 47;
            this.btnLoadDB.Text = "Cargar bases de datos";
            this.btnLoadDB.UseVisualStyleBackColor = false;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.BackColor = System.Drawing.Color.Transparent;
            this.lbCreated.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCreated.Location = new System.Drawing.Point(442, 84);
            this.lbCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(0, 19);
            this.lbCreated.TabIndex = 46;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSize.Location = new System.Drawing.Point(294, 84);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 19);
            this.lbSize.TabIndex = 45;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.BackColor = System.Drawing.Color.Transparent;
            this.lbOwner.Font = new System.Drawing.Font("Segoe UI Semilight", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwner.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbOwner.Location = new System.Drawing.Point(68, 84);
            this.lbOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(0, 19);
            this.lbOwner.TabIndex = 44;
            // 
            // cboDBList
            // 
            this.cboDBList.BackColor = System.Drawing.Color.Transparent;
            this.cboDBList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDBList.ForeColor = System.Drawing.Color.White;
            this.cboDBList.FormattingEnabled = true;
            this.cboDBList.ItemHeight = 23;
            this.cboDBList.Location = new System.Drawing.Point(259, 37);
            this.cboDBList.Margin = new System.Windows.Forms.Padding(4);
            this.cboDBList.Name = "cboDBList";
            this.cboDBList.Size = new System.Drawing.Size(405, 29);
            this.cboDBList.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboDBList.TabIndex = 43;
            this.cboDBList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboDBList.UseSelectable = true;
            this.cboDBList.SelectedValueChanged += new System.EventHandler(this.cboDBList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Bases de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Capa_Vista.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(4, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 9;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1272, 606);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reportes";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // MainViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainViewer";
            this.Padding = new System.Windows.Forms.Padding(45, 100, 45, 15);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Sistema Lector de Bases de Datos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.pResultado.ResumeLayout(false);
            this.pResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel pResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnalyzeColumn;
        private System.Windows.Forms.ListBox listbColumns;
        private System.Windows.Forms.Button btnLoadColumns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbTotalTables;
        private System.Windows.Forms.Button btnLoadTables;
        private MetroFramework.Controls.MetroComboBox cboTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbOwner;
        private MetroFramework.Controls.MetroComboBox cboDBList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchInstances;

        public Button BtnLoadDB { get => btnLoadDB; set => btnLoadDB = value; }
    }
}

