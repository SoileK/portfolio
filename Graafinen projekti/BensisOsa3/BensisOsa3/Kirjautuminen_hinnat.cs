using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BensisOsa3
{
    public partial class Kirjautuminen_hinnat : Form
    {
        Hinnat hinnat = new Hinnat(); // määritellään toinen formi nimeltä hinnat
        //määritellään tiedoston tunnukset.txt sijainti
        string tunnukset = AppDomain.CurrentDomain.BaseDirectory + @"\tunnukset.txt";
        string kayttaja;
        string[] kayttajat;

        public Kirjautuminen_hinnat()
        {
            InitializeComponent();
        }

        private void LueTunnukset() //aliohjelma kirjautumisen tarkistukseen
        {
            //luetaan tunnukset tiedostosta
            using (StreamReader sr = new StreamReader(tunnukset))
            {
                kayttaja = sr.ReadLine();
                kayttajat = (kayttaja.Split(new char[] { ',' })); //tunnus ja salasna taulukkoon
            }
            string salasana = textBox2.Text; //salasanan syöte
            string suola = "HWer3aUhtsn84Hk2er034"; //salasanan suola
            salasana = suola + salasana + suola; //suolattu salasana

            //Syötteenä saadun salasanan md5tiivisteen laskeminen
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(salasana);
            data = md5provider.ComputeHash(data);
            string md5tiiviste = "";
            for (int i = 0; i < data.Length; i++)
            {
                md5tiiviste += data[i].ToString("x2").ToLower();
            }

            //Syötetyn tunnuksen ja md5tiivisteen vertaaminen tiedostoon tallennettuihin
            if (textBox1.Text == kayttajat[0] && md5tiiviste == kayttajat[1])
            {
                hinnat.Show(); //avaa formin hinnat
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tarkista käyttäjätunnus ja salasana");
            }
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LueTunnukset(); //kirjaudu-nappi kutsuu aliohjelmaa
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // peruuta-nappi sulkee formin ja tyhjentää kentät
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void Kirjautuminen_hinnat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // formin sulkeminen piilottaa formin ja palauttaa sen uudelleen avattavaksi
            e.Cancel = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter kuittaa kirjautumisen ja "pling" vaimennetaan
            {
                e.Handled = true;
                LueTunnukset();
            }
        }
    }
}
