using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BensisOsa3
{
    public partial class Hinnat : Form
    {
        Mainostaulu mainostaulu = new Mainostaulu(); // määritellään toinen formi nimeltä tankit
        string hinnat = AppDomain.CurrentDomain.BaseDirectory + @"\hinnat.txt";
        string[] hinta;
        string hintaysiviis;
        string hintaysikasi;
        string hintadiesel;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public Hinnat()
        {
            InitializeComponent();
            LueHinnat();
        }

        private void LueHinnat()
        {
            using (StreamReader sr = new StreamReader(hinnat)) //luetaan tiedosto
            {
                hinnat = sr.ReadLine();
                hinta = (hinnat.Split(new char[] { ',' }));

                //näytetään hinnat
                label4.Text = hinta[0];
                label5.Text = hinta[1];
                label6.Text = hinta[2];
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hintaysiviis = textBox1.Text;
            hintaysikasi = textBox2.Text;
            hintadiesel = textBox3.Text;

            PaivitaHinnat();
            LueHinnat();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void PaivitaHinnat()
        {
            //päivitetään hinnat tiedostoon vanhojen tietojen päälle
            using (StreamWriter sw = new StreamWriter(hinnat))
            {
                sw.Write(hintaysiviis + "," + hintaysikasi + "," + hintadiesel);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // LueHinnat();
            SetValueForText1 = label4.Text;
            SetValueForText2 = label5.Text;
            SetValueForText3 = label6.Text;
            SetValueForText4 = textBox4.Text;
            mainostaulu.Show();
            textBox4.Text = null;
        }

        private void Hinnat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // formin sulkeminen piilottaa formin ja palauttaa sen uudelleen avattavaksi
            e.Cancel = true;
        }

        private void Hinnat_Load(object sender, EventArgs e)
        {

        }
    }
}
