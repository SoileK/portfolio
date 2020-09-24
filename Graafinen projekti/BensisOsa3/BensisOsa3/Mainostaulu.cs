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
    public partial class Mainostaulu : Form
    {
        public Mainostaulu()
        {
            InitializeComponent();
        }

        private void Mainostaulu_Load(object sender, EventArgs e)
        {
            label4.Text = Hinnat.SetValueForText1;
            label5.Text = Hinnat.SetValueForText2;
            label6.Text = Hinnat.SetValueForText3;
            label7.Text = Hinnat.SetValueForText4;
        }

        private void Mainostaulu_FormClosing(object sender, FormClosingEventArgs e)
        {
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            this.Hide(); // formin sulkeminen piilottaa formin ja palauttaa sen uudelleen avattavaksi
            e.Cancel = true;
        }
    }
}
