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
    public partial class frmBejelentkezes : Form
    {

        int probalkozasok = 3;
        string felhasznalonev = "Medve Adrián";
        string jelszo = "pass";
        public frmBejelentkezes()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            // user - user
            // max 3 próbálkozás
            // sikertelen akkor kilépés
            // figyelmeztetés úres adatmezőre
            // vagy nem jó felhasználónév vagy jelszó
            // ha sikeres akkor MessageBox("Siker")

            if (tbFelhasznalonev.Text.Length == 0 || tbJelszo.Text.Length == 0)
            {
                if (probalkozasok > 0)
                {
                    MessageBox.Show("Nem töltötted ki a mezőket!\nMár csak " + probalkozasok + " próbálkozás maradt!", "Hiba!");
                    probalkozasok--;
                } else
                {
                    MessageBox.Show("Nem töltötted ki a mezőket!\nKilépés az alkalmazásból!", "Hiba!");
                    Application.Exit();
                }
            } else if (tbFelhasznalonev.Text != felhasznalonev || tbJelszo.Text != jelszo)
            {
                if (probalkozasok > 0)
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó! \nMár csak " + probalkozasok + " próbálkozás maradt!", "Hiba!");
                    probalkozasok--;
                    tbFelhasznalonev.Text = "";
                    tbJelszo.Text = "";
                    tbFelhasznalonev.Focus();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó! \nKilépés az alkalmazásból!", "Hiba!");
                    Application.Exit();
                }
            } else
            {
                this.Hide();
                frmFo frmFo = new frmFo(tbFelhasznalonev.Text, rbAdmin.Checked);
                frmFo.Show();
            }
        }
    }
}
