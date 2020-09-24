using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BensisOsa3
{
    public partial class Paavalikko : Form
    {
        Kirjautuminen kirjautuminen = new Kirjautuminen(); // määritellään formi kirjautuminen
        Kirjautuminen_hinnat kirjautuminen_Hinnat = new Kirjautuminen_hinnat();

        public Paavalikko()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(DateTime.Now);
        }

        private void TankitToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            kirjautuminen.Show(); //avataan formi kirjautuminen
        }

        private void SammutaOhjelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sammutetaan ohjelma jos message boxiin vastataan kyllä
            DialogResult result = MessageBox.Show("Sammutetaanko ohjelma?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }

        private void HinnastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kirjautuminen_Hinnat.Show();
        }
    }
}

