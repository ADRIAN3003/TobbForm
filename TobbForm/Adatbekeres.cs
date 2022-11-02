using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobbForm
{
    public partial class frmAdat : Form
    {
        frmFo frm;
        public frmAdat(frmFo frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (tbAdat.Text != "")
            {
                frm.Adat = tbAdat.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Meg kell adni adatot!");
            }
        }
    }
}
