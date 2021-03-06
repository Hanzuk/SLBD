﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista {
    public partial class WarningDialog : MetroFramework.Forms.MetroForm {
        public WarningDialog(string Message) {
            InitializeComponent();
            lbMessage.Text = Message;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        public static void ShowDialog(string Message) {
            WarningDialog WD = new WarningDialog(Message);
            WD.ShowDialog();
        }

        private void WarningDialog_Load(object sender, EventArgs e) {
            tmOpacity.Start();
        }

        private void tmOpacity_Tick(object sender, EventArgs e) {
            this.Opacity += .20;
            if (this.Opacity == 1) {
                tmOpacity.Stop();
            }
        }
    }
}
