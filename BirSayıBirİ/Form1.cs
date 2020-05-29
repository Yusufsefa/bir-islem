using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirSayıBirİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            try
            {
                hesapla();
            }
            catch
            {
                MessageBox.Show("First, don't leave the boxes empty");
            }
        }

        private void hesapla()
        {
            int sayi1 = Convert.ToInt32(textBox1.Text.ToString());
            int sayi2 = Convert.ToInt32(textBox2.Text.ToString());
            int sayi3 = Convert.ToInt32(textBox3.Text.ToString());
            int sayi4 = Convert.ToInt32(textBox4.Text.ToString());
            int sayi5 = Convert.ToInt32(textBox5.Text.ToString());
            int sayi6 = Convert.ToInt32(textBox6.Text.ToString());

            int[] sayilar1 = { sayi1, sayi2, sayi3, sayi4, sayi5, sayi6 };

            List<int> list = new List<int>(new[] { sayi1, sayi2, sayi3, sayi4, sayi5,sayi6 });

            int target = Convert.ToInt32(textBox7.Text.ToString());

            CountDown game = new CountDown();

            if (game.findSolution(sayilar1,sayilar1.Length,target))
            {
                label12.Text = game.printSolution();
                textBox9.Text = game.PrintResult().ToString();

                int point = 0;

                if(target > game.PrintResult())
                {
                    point = target - game.PrintResult();

                    if (point == 0)
                    {
                        textBox10.Text = "10 point";
                    }
                    else if (point == 1)
                    {
                        textBox10.Text = "9 point";
                    }
                    else if (point == 2)
                    {
                        textBox10.Text = "8 point";
                    }
                    else if (point == 3)
                    {
                        textBox10.Text = "7 point";
                    }
                    else if (point == 4)
                    {
                        textBox10.Text = "6 point";
                    }
                    else if (point == 5)
                    {
                        textBox10.Text = "5 point";
                    }
                    else if (point == 6)
                    {
                        textBox10.Text = "4 point";
                    }
                    else if (point == 7)
                    {
                        textBox10.Text = "3 point";
                    }
                    else if (point == 8)
                    {
                        textBox10.Text = "2 point";
                    }
                    else if (point == 9)
                    {
                        textBox10.Text = "1 point";
                    }
                }
                else
                {
                    point = game.PrintResult() - target;

                    if (point == 0)
                    {
                        textBox10.Text = "10 point";
                    }
                    else if (point == 1)
                    {
                        textBox10.Text = "9 point";
                    }
                    else if (point == 2)
                    {
                        textBox10.Text = "8 point";
                    }
                    else if (point == 3)
                    {
                        textBox10.Text = "7 point";
                    }
                    else if (point == 4)
                    {
                        textBox10.Text = "6 point";
                    }
                    else if (point == 5)
                    {
                        textBox10.Text = "5 point";
                    }
                    else if (point == 6)
                    {
                        textBox10.Text = "4 point";
                    }
                    else if (point == 7)
                    {
                        textBox10.Text = "3 point";
                    }
                    else if (point == 8)
                    {
                        textBox10.Text = "2 point";
                    }
                    else if (point == 9)
                    {
                        textBox10.Text = "1 point";
                    }

                }

            }

        }

        private void rastgeleSayiUret()
        {
            int[] rndSayilar = RndNumber.getInstance().getRastgeleSayilar();

            textBox1.Text = rndSayilar[0].ToString();
            textBox2.Text = rndSayilar[1].ToString();
            textBox3.Text = rndSayilar[2].ToString();
            textBox4.Text = rndSayilar[3].ToString();
            textBox5.Text = rndSayilar[4].ToString();
            textBox6.Text = rndSayilar[5].ToString();
            textBox7.Text = RndNumber.getInstance().getHedefSayi().ToString();
        }

        private void Rnd_Btn(object sender, EventArgs e)
        {
            label12.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            rastgeleSayiUret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            label12.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;

            radioButton1.Checked = true;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label12.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }
    }
}
