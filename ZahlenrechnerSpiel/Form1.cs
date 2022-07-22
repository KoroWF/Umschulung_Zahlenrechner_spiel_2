using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahlenrechnerSpiel
{
    public partial class Form1 : Form
    {
        int versuche = 0;
        int zahl1 = 0;
        int zahl2 = 0;
        int richtig = 0;
        int falsch = 0;
        int summe = 0;


        public Form1()
        {
            InitializeComponent();


            //erstelle randomzahl und gebe diese bei Textfeld Summe aus!
            Random rnd = new Random();
            int random = rnd.Next(2, 16);
            tbversuche.Text = versuche.ToString();
            tbsumme.Text = random.ToString();
            tbrichtig.Text = richtig.ToString();
            tbfalsch.Text = falsch.ToString();
            tbz1.Text = zahl1.ToString();
            tbz2.Text = zahl2.ToString();
            tbrichtig.BackColor = Color.LightGray;
            tbfalsch.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(zahl1 != 0)
            {
                zahl2 = 1;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 1;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 2;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 2;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 3;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 3;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 4;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 4;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 5;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 5;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 6;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 6;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 =7;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 =7;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 8;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 8;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (zahl1 != 0)
            {
                zahl2 = 9;
                tbz2.Text = zahl2.ToString();
            }
            else
            {
                zahl1 = 9;
                tbz1.Text = zahl1.ToString();
                tbrichtig.BackColor = Color.LightGray;
                tbfalsch.BackColor = Color.LightGray;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            versuche = 0;
            zahl1 = 0;
            zahl2 = 0;
            richtig = 0;
            falsch = 0;
            summe = 0;


            tbversuche.Text = "0";
            tbrichtig.Text = "0";
            tbfalsch.Text = "0";
            tbz1.Text = "0";
            tbz2.Text = "0";

            Random rnd = new Random();
            int random = rnd.Next(2, 16);
            tbsumme.Text = random.ToString();

            tbrichtig.BackColor = Color.LightGray;
            tbfalsch.BackColor = Color.LightGray;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (tbrichtig.Text == "10")
            {
                DialogResult baum = MessageBox.Show("DU HAST GEWONNEN YIPPIEE *.*", "Neu Starten?", MessageBoxButtons.OK);
                if (baum == DialogResult.OK)
                {
                    versuche = 0;
                    zahl1 = 0;
                    zahl2 = 0;
                    richtig = 0;
                    falsch = 0;
                    summe = 0;


                    tbversuche.Text = "0";
                    tbrichtig.Text = "0";
                    tbfalsch.Text = "0";
                    tbz1.Text = "0";
                    tbz2.Text = "0";

                    Random rnd = new Random();
                    int random = rnd.Next(2, 16);
                    tbsumme.Text = random.ToString();

                    tbrichtig.BackColor = Color.LightGray;
                    tbfalsch.BackColor = Color.LightGray;
                }
            }
            else if (versuche < 5)
            {
                if (tbz2.Text != "0")
                {
                    summe = zahl1 + zahl2;
                }


                int.TryParse(tbsumme.Text, out int Summe1);

                if (tbz2.Text != "0")
                {
                    if (summe == Summe1)
                    {
                        richtig++;
                        tbrichtig.Text = richtig.ToString();
                        tbrichtig.BackColor = Color.Green;
                    }
                    else if (summe != Summe1)
                    {
                        falsch++;
                        versuche++;

                        tbversuche.Text = versuche.ToString();
                        tbfalsch.Text = falsch.ToString();
                        tbfalsch.BackColor = Color.Red;
                    }
                }

                zahl1 = 0;
                zahl2 = 0;

                tbz1.Text = "0";
                tbz2.Text = "0";

                Random rnd = new Random();
                int random = rnd.Next(2, 19);
                tbsumme.Text = random.ToString();
            }
            else
            {
                DialogResult baum = MessageBox.Show("Du hast alle versuche verbraucht! Q.Q", "Neu Starten?", MessageBoxButtons.OK);
                if (baum == DialogResult.OK)
                {
                    versuche = 0;
                    zahl1 = 0;
                    zahl2 = 0;
                    richtig = 0;
                    falsch = 0;
                    summe = 0;


                    tbversuche.Text = "0";
                    tbrichtig.Text = "0";
                    tbfalsch.Text = "0";
                    tbz1.Text = "0";
                    tbz2.Text = "0";

                    Random rnd = new Random();
                    int random = rnd.Next(2, 16);
                    tbsumme.Text = random.ToString();

                    tbrichtig.BackColor = Color.LightGray;
                    tbfalsch.BackColor = Color.LightGray;
                }
            }
        }
    }
}
