using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace black_jack_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        Random rndm = new Random();
        int counter = 0;
        int total = 0;
        int computerscore=0;
        int playerscore=0;

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            counter++;
            if (counter == 1)
            {
                int a1, a2;
                a1 = rndm.Next(1, 11);
                a2 = rndm.Next(1, 11);
                total = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = total.ToString();
            }
            if (counter == 2)
            {
                int a3;
                a3 = rndm.Next(1, 11);

                label3.Text = a3.ToString();
                total = total + a3;
                label10.Text = total.ToString();
                
            }
            if (counter == 3)
            {
                int a4;
                a4 = rndm.Next(1, 11);

                label4.Text = a4.ToString();
                total = total + a4;
                label10.Text = total.ToString();
            }
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a1, a2;
            a1 = rndm.Next(1,11);
            a2 = rndm.Next(1, 11);

            label5.Text = a1.ToString();
            label6.Text = a2.ToString();
            total = a1 + a2;
            label11.Text = total.ToString();
            {
                if (total < 16)
                {
                    int a3;
                    a3 = rndm.Next(1, 11);
                    label7.Text = a3.ToString();
                    total = total + a3;
                    label11.Text = total.ToString();
                }
                else
                {
                    label7.Text = "label7";
                }
                if (total < 16)
                {
                    int a4;
                    a4 = rndm.Next(1, 11);
                    label8.Text = a4.ToString();
                    total = total + a4;
                    label11.Text = total.ToString();
                }
                else
                {
                    label8.Text = "label8";
                }
            }
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pctotal, playertotal;
            pctotal = Convert.ToInt32(label11.Text);
            playertotal = Convert.ToInt32(label10.Text);
            if (playertotal > pctotal && playertotal <= 21)
            {
                playerscore = playerscore + 10;
                label21.Text = playerscore.ToString();
            }
            if (pctotal > playertotal && pctotal <= 21)
            {
                computerscore = computerscore + 10;
                label20.Text = computerscore.ToString();
            }
            if (pctotal > 21 && playertotal > 21)
            {
                MessageBox.Show ("GREAT VALUES REACHED GAME OVER");
            }
        }
    }
}
