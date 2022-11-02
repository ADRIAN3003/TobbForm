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
    public partial class frmFo : Form
    {
        string felhasznalo;
        bool admin;

        public string Adat { get; set; }

        public frmFo(string felhasznalo, bool admin)
        {
            InitializeComponent();
            this.felhasznalo = felhasznalo;
            this.admin = admin;
            this.Text += $" - {felhasznalo}";

            if (admin)
            {
                this.BackColor = Color.Green;
            } else
            {
                mAdatbekeres.Enabled = false;
            }
        }

        private void mKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mAdatbekeres_Click(object sender, EventArgs e)
        {
            frmAdat frmAdat = new frmAdat(this);
            frmAdat.ShowDialog();
            lblSzoveg.Text = Adat;
        }
    }
}
