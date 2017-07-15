using System;
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
    }
}
