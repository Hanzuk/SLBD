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
    public partial class SuccessDialog : MetroFramework.Forms.MetroForm {
        public SuccessDialog(string Message) {
            InitializeComponent();
            lbMessage.Text = Message;
        }

        private void btnClose_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        public static void ShowDialog(string Message) {
            SuccessDialog SC = new SuccessDialog(Message);
            SC.ShowDialog();
        }

        private void SuccessDialog_Load(object sender, EventArgs e) {
            tmOpacity.Start();
        }

        private void tmOpacity_Tick_1(object sender, EventArgs e) {
            this.Opacity += .20;
            if (this.Opacity == 1) {
                tmOpacity.Stop();
            }
        }
    }
}
