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
            this.cboInstances = new MetroFramework.Controls.MetroComboBox();
            this.btnLoadInstances = new System.Windows.Forms.Button();
            this.btnCheckInstance = new System.Windows.Forms.Button();
            this.btnSetIntance = new System.Windows.Forms.Button();
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
            this.cboInstances.Size = new System.Drawing.Size(334, 35);
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
            this.btnLoadInstances.Location = new System.Drawing.Point(513, 114);
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
            this.btnCheckInstance.Location = new System.Drawing.Point(400, 284);
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
            this.btnSetIntance.Location = new System.Drawing.Point(167, 284);
            this.btnSetIntance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetIntance.Name = "btnSetIntance";
            this.btnSetIntance.Size = new System.Drawing.Size(213, 50);
            this.btnSetIntance.TabIndex = 61;
            this.btnSetIntance.Text = "Usar instancia";
            this.btnSetIntance.UseVisualStyleBackColor = false;
            this.btnSetIntance.Click += new System.EventHandler(this.btnSetIntance_Click);
            // 
            // InstancesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 418);
            this.Controls.Add(this.btnSetIntance);
            this.Controls.Add(this.btnCheckInstance);
            this.Controls.Add(this.btnLoadInstances);
            this.Controls.Add(this.cboInstances);
            this.Name = "InstancesViewer";
            this.Padding = new System.Windows.Forms.Padding(50, 110, 50, 80);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Selecciona una instancia de SQL";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboInstances;
        private System.Windows.Forms.Button btnLoadInstances;
        private System.Windows.Forms.Button btnCheckInstance;
        private System.Windows.Forms.Button btnSetIntance;
    }
}