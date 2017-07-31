namespace Capa_Vista {
    partial class InstancesViewer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstancesViewer));
            this.cboInstances = new MetroFramework.Controls.MetroComboBox();
            this.btnLoadInstances = new System.Windows.Forms.Button();
            this.btnCheckInstance = new System.Windows.Forms.Button();
            this.btnSetIntance = new System.Windows.Forms.Button();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.tmSpinner = new System.Windows.Forms.Timer(this.components);
            this.panelSpinner = new System.Windows.Forms.Panel();
            this.lbLoader = new System.Windows.Forms.Label();
            this.txtInstance = new MetroFramework.Controls.MetroTextBox();
            this.checkInstances = new MetroFramework.Controls.MetroCheckBox();
            this.panelSpinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboInstances
            // 
            this.cboInstances.BackColor = System.Drawing.Color.Transparent;
            this.cboInstances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInstances.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboInstances.ForeColor = System.Drawing.Color.White;
            this.cboInstances.FormattingEnabled = true;
            this.cboInstances.ItemHeight = 29;
            this.cboInstances.Location = new System.Drawing.Point(54, 120);
            this.cboInstances.Margin = new System.Windows.Forms.Padding(4);
            this.cboInstances.Name = "cboInstances";
            this.cboInstances.PromptText = "Instancias disponibles";
            this.cboInstances.Size = new System.Drawing.Size(464, 35);
            this.cboInstances.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboInstances.TabIndex = 44;
            this.cboInstances.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboInstances.UseSelectable = true;
            // 
            // btnLoadInstances
            // 
            this.btnLoadInstances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnLoadInstances.FlatAppearance.BorderSize = 0;
            this.btnLoadInstances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnLoadInstances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadInstances.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadInstances.ForeColor = System.Drawing.Color.White;
            this.btnLoadInstances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadInstances.Location = new System.Drawing.Point(617, 114);
            this.btnLoadInstances.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadInstances.Name = "btnLoadInstances";
            this.btnLoadInstances.Size = new System.Drawing.Size(213, 50);
            this.btnLoadInstances.TabIndex = 59;
            this.btnLoadInstances.Text = "Cargar instancias";
            this.btnLoadInstances.UseVisualStyleBackColor = false;
            this.btnLoadInstances.Click += new System.EventHandler(this.btnLoadInstances_Click);
            // 
            // btnCheckInstance
            // 
            this.btnCheckInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnCheckInstance.FlatAppearance.BorderSize = 0;
            this.btnCheckInstance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnCheckInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInstance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInstance.ForeColor = System.Drawing.Color.White;
            this.btnCheckInstance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckInstance.Location = new System.Drawing.Point(452, 449);
            this.btnCheckInstance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckInstance.Name = "btnCheckInstance";
            this.btnCheckInstance.Size = new System.Drawing.Size(213, 50);
            this.btnCheckInstance.TabIndex = 60;
            this.btnCheckInstance.Text = "Verificar conexión";
            this.btnCheckInstance.UseVisualStyleBackColor = false;
            this.btnCheckInstance.Click += new System.EventHandler(this.btnCheckInstance_Click);
            // 
            // btnSetIntance
            // 
            this.btnSetIntance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(45)))), ((int)(((byte)(128)))));
            this.btnSetIntance.FlatAppearance.BorderSize = 0;
            this.btnSetIntance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.btnSetIntance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetIntance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetIntance.ForeColor = System.Drawing.Color.White;
            this.btnSetIntance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetIntance.Location = new System.Drawing.Point(219, 449);
            this.btnSetIntance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetIntance.Name = "btnSetIntance";
            this.btnSetIntance.Size = new System.Drawing.Size(213, 50);
            this.btnSetIntance.TabIndex = 61;
            this.btnSetIntance.Text = "Usar instancia";
            this.btnSetIntance.UseVisualStyleBackColor = false;
            this.btnSetIntance.Click += new System.EventHandler(this.btnSetIntance_Click);
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(83, 19);
            this.Spinner.Maximum = 100;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(50, 50);
            this.Spinner.Speed = 0.5F;
            this.Spinner.Style = MetroFramework.MetroColorStyle.Pink;
            this.Spinner.TabIndex = 62;
            this.Spinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Spinner.UseSelectable = true;
            // 
            // tmSpinner
            // 
            this.tmSpinner.Enabled = true;
            this.tmSpinner.Interval = 10;
            this.tmSpinner.Tick += new System.EventHandler(this.tmSpinner_Tick);
            // 
            // panelSpinner
            // 
            this.panelSpinner.Controls.Add(this.lbLoader);
            this.panelSpinner.Controls.Add(this.Spinner);
            this.panelSpinner.Location = new System.Drawing.Point(334, 289);
            this.panelSpinner.Name = "panelSpinner";
            this.panelSpinner.Size = new System.Drawing.Size(216, 125);
            this.panelSpinner.TabIndex = 63;
            this.panelSpinner.Visible = false;
            // 
            // lbLoader
            // 
            this.lbLoader.AutoSize = true;
            this.lbLoader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoader.ForeColor = System.Drawing.Color.White;
            this.lbLoader.Location = new System.Drawing.Point(11, 82);
            this.lbLoader.Name = "lbLoader";
            this.lbLoader.Size = new System.Drawing.Size(0, 25);
            this.lbLoader.TabIndex = 63;
            // 
            // txtInstance
            // 
            // 
            // 
            // 
            this.txtInstance.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstance.CustomButton.Image = null;
            this.txtInstance.CustomButton.Location = new System.Drawing.Point(430, 1);
            this.txtInstance.CustomButton.Name = "";
            this.txtInstance.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtInstance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstance.CustomButton.TabIndex = 1;
            this.txtInstance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstance.CustomButton.UseSelectable = true;
            this.txtInstance.CustomButton.Visible = false;
            this.txtInstance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInstance.Lines = new string[0];
            this.txtInstance.Location = new System.Drawing.Point(54, 233);
            this.txtInstance.MaxLength = 32767;
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.PasswordChar = '\0';
            this.txtInstance.PromptText = "Ingresa tu instancia aquí";
            this.txtInstance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstance.SelectedText = "";
            this.txtInstance.SelectionLength = 0;
            this.txtInstance.SelectionStart = 0;
            this.txtInstance.ShortcutsEnabled = true;
            this.txtInstance.Size = new System.Drawing.Size(464, 35);
            this.txtInstance.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInstance.TabIndex = 64;
            this.txtInstance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInstance.UseSelectable = true;
            this.txtInstance.Visible = false;
            this.txtInstance.WaterMark = "Ingresa tu instancia aquí";
            this.txtInstance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkInstances
            // 
            this.checkInstances.AutoSize = true;
            this.checkInstances.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkInstances.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkInstances.Location = new System.Drawing.Point(54, 185);
            this.checkInstances.Name = "checkInstances";
            this.checkInstances.Size = new System.Drawing.Size(198, 20);
            this.checkInstances.Style = MetroFramework.MetroColorStyle.Purple;
            this.checkInstances.TabIndex = 65;
            this.checkInstances.Text = "¿Las instancias no cargan?";
            this.checkInstances.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkInstances.UseSelectable = true;
            this.checkInstances.CheckedChanged += new System.EventHandler(this.checkInstances_CheckedChanged);
            // 
            // InstancesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 563);
            this.Controls.Add(this.checkInstances);
            this.Controls.Add(this.txtInstance);
            this.Controls.Add(this.panelSpinner);
            this.Controls.Add(this.btnSetIntance);
            this.Controls.Add(this.btnCheckInstance);
            this.Controls.Add(this.btnLoadInstances);
            this.Controls.Add(this.cboInstances);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstancesViewer";
            this.Padding = new System.Windows.Forms.Padding(50, 110, 50, 60);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Selecciona una instancia de SQL";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSpinner.ResumeLayout(false);
            this.panelSpinner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboInstances;
        private System.Windows.Forms.Button btnLoadInstances;
        private System.Windows.Forms.Button btnCheckInstance;
        private System.Windows.Forms.Button btnSetIntance;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private System.Windows.Forms.Timer tmSpinner;
        private System.Windows.Forms.Panel panelSpinner;
        private System.Windows.Forms.Label lbLoader;
        private MetroFramework.Controls.MetroTextBox txtInstance;
        private MetroFramework.Controls.MetroCheckBox checkInstances;
    }
}