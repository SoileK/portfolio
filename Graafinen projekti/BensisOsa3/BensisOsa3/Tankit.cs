using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace BensisOsa3
{    
    public partial class Tankit : Form
    {
        //määritellään tankit-tiedoston sijainti
        string tankit = AppDomain.CurrentDomain.BaseDirectory + @"\tankit.txt";
        //määritellään tilaukset-tiedoston sijainti
        string tilaukset = AppDomain.CurrentDomain.BaseDirectory + @"\tilaukset.txt";
        string taso;
        string[] tasot;
        int lisays;
            
        public Tankit()
        {
            InitializeComponent();
            label8.Text = Convert.ToString(DateTime.Now);
            TarkistaTankit(); //kutsutaan aliohjelmaa
        }
  
        private void Button1_Click(object sender, EventArgs e) //tilataan lisää polttoainetta
        {
            //virheilmoitus, jos combobox valinta ei ole listalla
            if (comboBox1.SelectedIndex != 0 && comboBox1.SelectedIndex !=1 && comboBox1.SelectedIndex != 2)
            {
                MessageBox.Show("Tarkista polttoainelaji");
                //nollataan tilauskentät
                comboBox1.Text = null;
                textBox4.Text = null;
            }
            else
            { 
            //kysytään tiltaanko varmasti
            DialogResult result = MessageBox.Show("Tilataanko "+comboBox1.SelectedItem.ToString()+" "+textBox4.Text+" Litraa?","TILAUKSEN VAHVISTUS", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (StreamReader sr = new StreamReader(tankit)) //luetaan tankit-tiedosto
                    {
                        taso = sr.ReadLine();
                        tasot = (taso.Split(new char[] { ',' }));
                    }

                    int lisays = Convert.ToInt32(textBox4.Text);

                    //lasketaan uusi määrä tankille jota täytetään
                    if (comboBox1.SelectedIndex == 0)
                    {
                        int ysiviis = Convert.ToInt32(tasot[0]);
                        tasot[0] = Convert.ToString((ysiviis + lisays));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int ysikasi = Convert.ToInt32(tasot[1]);
                        tasot[1] = Convert.ToString((ysikasi + lisays));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int diesel = Convert.ToInt32(tasot[2]);
                        tasot[2] = Convert.ToString((diesel + lisays));
                    }    

                    //kutsutaan aliohjelmia
                    PaivitaTankit(); 
                    TallennaTilaukset();
                    TarkistaTankit();
                    //nollataan tilauskentät
                    comboBox1.Text = null;
                    textBox4.Text = null;
                }
            }           
        }

        //aliohjema, jolla luetaan tankkien tilanne näytölle
        private void TarkistaTankit()
        {
            using (StreamReader sr = new StreamReader(tankit)) //luetaan tiedosto
            {
                taso = sr.ReadLine();
                tasot = (taso.Split(new char[] { ',' }));
            }

            //päivitetään tankkien tilanne tekstimuodossa
            label4.Text = tasot[0] + " /1000 litraa";
            label5.Text = tasot[1] + " /1000 litraa";
            label6.Text = tasot[2] + " /1000 litraa";

            int ysiviis = Convert.ToInt32(tasot[0]);

            //try-catch mahtuuko uusi määärä tankkiin
            try
            {
                trackBar1.Value = ysiviis;
            }
            catch
            {
                //tehdään jos ei mahdu
                label4.Text = "YLITÄYTTÖ";
                label4.ForeColor = Color.Red;
                trackBar1.Value = 1001;
                MessageBox.Show("Tankki tulvi yli, soita 112!");
            }

            //päivitetään tankkien tilanne ruudulle
            if (ysiviis > 1000) //muutokset jos ysiviis yli 1000
            {
                trackBar1.BackColor = Color.Red;
                textBox1.Text = "95E10 tankki tulvinut";
                textBox1.ForeColor = Color.Red;
            }
            else if (ysiviis >= 500) //muutokset jos ysiviis 500-1000
            {
                trackBar1.BackColor = Color.Green;
                textBox1.Text = null;
                label4.ForeColor = Color.Black;
            }
            else if (ysiviis >= 200) //muutokset jos ysiviis 200-499
            {
                trackBar1.BackColor = Color.Yellow;
                textBox1.Text = null;
                label4.ForeColor = Color.Black;
            }
            else //muutokset jos ysiviis enintään 199
            {
                trackBar1.BackColor = Color.Red;
                textBox1.Text = "95E10 taso alhainen";
                textBox1.ForeColor = Color.Red;
                label4.ForeColor = Color.Black;
            }

            //samat päivitykset ysikasille
         
            int ysikasi = Convert.ToInt32(tasot[1]);

            try
            {
                trackBar2.Value = ysikasi;
            }
            catch
            {
                label5.Text = "YLITÄYTTÖ";
                label5.ForeColor = Color.Red;
                trackBar2.Value = 1001;
                MessageBox.Show("Tankki tulvi yli, soita 112!");

            }

            if (ysikasi > 1000)
            {
                trackBar2.BackColor = Color.Red;
                textBox2.Text = "98E5 tankki tulvinut";
                textBox2.ForeColor = Color.Red;
            }
            else if (ysikasi >= 500)
            {
                trackBar2.BackColor = Color.Green;
                textBox2.Text = null;
                label5.ForeColor = Color.Black;
            }
            else if (ysikasi >= 200)
            {
                trackBar2.BackColor = Color.Yellow;
                textBox2.Text = null;
                label5.ForeColor = Color.Black;
            }
            else
            {
                trackBar2.BackColor = Color.Red;
                textBox2.Text = "98E5 taso alhainen";
                textBox2.ForeColor = Color.Red;
            }

            //samat päivitykset dieselille

            int diesel = Convert.ToInt32(tasot[2]);

            try
            {
                trackBar3.Value = diesel;
            }
            catch
            {
                label6.Text = "YLITÄYTTÖ";
                label6.ForeColor = Color.Red;
                trackBar3.Value = 1001;
                MessageBox.Show("Tankki tulvi yli, soita 112!");
            }

            if (diesel > 1000)
            {
                trackBar3.BackColor = Color.Red;
                textBox3.Text = "Diesel tankki tulvinut";
                textBox3.ForeColor = Color.Red;
            } 
            else if (diesel >= 500)
            {
                trackBar3.BackColor = Color.Green;
                textBox3.Text = null;
                label6.ForeColor = Color.Black;
            }
            else if (diesel >= 200)
            {
                trackBar3.BackColor = Color.Yellow;
                textBox3.Text = null;
                label6.ForeColor = Color.Black;
            }
            else
            {
                trackBar3.BackColor = Color.Red;
                textBox3.Text = "Dieselin taso alhainen";
                textBox3.ForeColor = Color.Red;
                label6.ForeColor = Color.Black;
            }
        }

        private void PaivitaTankit()
        {
            //päivitetään tankkien sisältä tiedostoon vanhojen tietojen päälle
            using (StreamWriter sw = new StreamWriter(tankit))
            {
                sw.Write(Convert.ToString(tasot[0] + "," + tasot[1] + "," + tasot[2]));
            }
        }

        private void TallennaTilaukset()
        {
            //kirjoitetaan tilaus tiedostoon
            lisays = Convert.ToInt32(textBox4.Text);
            using (StreamWriter sw = new StreamWriter(tilaukset, true))
            {
                sw.WriteLine("Tilattu " + DateTime.Now + " " + comboBox1.SelectedItem.ToString() + " " + lisays + " Litraa");
            }
        }

        private void KirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //palataan päävalikkoon, jos vastaus on kyllä
            DialogResult result = MessageBox.Show("Kirjaudutaanko ulos?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        //Formin sulkeminen vapauttaa formin uudelleen avattavaksi
        private void Tankit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
