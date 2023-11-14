using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int pobeda = 0;
        int but9 = 0;
        int but10 = 0;
        int but12 = 0;
        int but13 = 0;
        int but15 = 0;
        int but22 = 0;
        int but18 = 0;
        int but21 = 0;
        int but28 = 0;
        int but30 = 0;
        int but38 = 0;
        int but46 = 0;
        int but40 = 0;
        int but34 = 0;
        int sum = 14;

        private void CheckWin()
        {
            if (sum == but9 + but10 + but12 + but13 + but15 + but22 + but18 + but21 + but28 + but30 + but38 + but46 + but40 + but34 + pobeda)
            {
                MessageBox.Show("Поздравляю, вы разгадали кроссворд ;)","Ура! Победа!");
                this.Close();
            }
        }

        private void kletka1_Click(object sender, EventArgs e)
        {
            if (kletka1.ForeColor != Color.Black)
            {
                kletka1.ForeColor = Color.Black;
                kletka1.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka1.ForeColor = Color.White;
                kletka1.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka2_Click(object sender, EventArgs e)
        {
            if (kletka2.ForeColor != Color.Black)
            {
                kletka2.ForeColor = Color.Black;
                kletka2.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka2.ForeColor = Color.White;
                kletka2.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka3_Click(object sender, EventArgs e)
        {
            if (kletka3.ForeColor != Color.Black)
            {
                kletka3.ForeColor = Color.Black;
                kletka3.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka3.ForeColor = Color.White;
                kletka3.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka4_Click(object sender, EventArgs e)
        {
            if (kletka4.ForeColor != Color.Black)
            {
                kletka4.ForeColor = Color.Black;
                kletka4.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka4.ForeColor = Color.White;
                kletka4.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka5_Click(object sender, EventArgs e)
        {
            if (kletka5.ForeColor != Color.Black)
            {
                kletka5.ForeColor = Color.Black;
                kletka5.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka5.ForeColor = Color.White;
                kletka5.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka6_Click(object sender, EventArgs e)
        {
            if (kletka6.ForeColor != Color.Black)
            {
                kletka6.ForeColor = Color.Black;
                kletka6.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka6.ForeColor = Color.White;
                kletka6.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka7_Click(object sender, EventArgs e)
        {
            if (kletka7.ForeColor != Color.Black)
            {
                kletka7.ForeColor = Color.Black;
                kletka7.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka7.ForeColor = Color.White;
                kletka7.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka8_Click(object sender, EventArgs e)
        {
            if (kletka8.ForeColor != Color.Black)
            {
                kletka8.ForeColor = Color.Black;
                kletka8.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka8.ForeColor = Color.White;
                kletka8.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka9_Click(object sender, EventArgs e)
        {
            if (kletka9.ForeColor != Color.Black)
            {
                kletka9.ForeColor = Color.Black;
                kletka9.BackColor = Color.Black;
                but9 = 1;
                CheckWin();
            }
            else
            {
                kletka9.ForeColor = Color.White;
                kletka9.BackColor = Color.White;
                but9 = 0;
                CheckWin();
            }
            
        }
        private void kletka10_Click(object sender, EventArgs e)
        {
            if (kletka10.ForeColor != Color.Black)
            {
                kletka10.ForeColor = Color.Black;
                kletka10.BackColor = Color.Black;
                but10 = 1;
                CheckWin();
            }
            else
            {
                kletka10.ForeColor = Color.White;
                kletka10.BackColor = Color.White;
                but10 = 0;
                CheckWin();
            }
        }
        private void kletka11_Click(object sender, EventArgs e)
        {
            if (kletka11.ForeColor != Color.Black)
            {
                kletka11.ForeColor = Color.Black;
                kletka11.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka11.ForeColor = Color.White;
                kletka11.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka12_Click(object sender, EventArgs e)
        {
            if (kletka12.ForeColor != Color.Black)
            {
                kletka12.ForeColor = Color.Black;
                kletka12.BackColor = Color.Black;
                but12 = 1;
                CheckWin();
            }
            else
            {
                kletka12.ForeColor = Color.White;
                kletka12.BackColor = Color.White;
                but12 = 0;
                CheckWin();
            }
        }

        private void kletka13_Click(object sender, EventArgs e)
        {
            if (kletka13.ForeColor != Color.Black)
            {
                kletka13.ForeColor = Color.Black;
                kletka13.BackColor = Color.Black;
                but13 = 1;  
                CheckWin();
            }
            else
            {
                kletka13.ForeColor = Color.White;
                kletka13.BackColor = Color.White;
                but13 = 0;  
                CheckWin();
            }
        }

        private void kletka14_Click(object sender, EventArgs e)
        {
            if (kletka14.ForeColor != Color.Black)
            {
                kletka14.ForeColor = Color.Black;
                kletka14.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka14.ForeColor = Color.White;
                kletka14.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka15_Click(object sender, EventArgs e)
        {
            if (kletka15.ForeColor != Color.Black)
            {
                kletka15.ForeColor = Color.Black;
                kletka15.BackColor = Color.Black;
                but15 = 1;
                CheckWin();
            }
            else
            {
                kletka15.ForeColor = Color.White;
                kletka15.BackColor = Color.White;
                but15 = 0;  
                CheckWin();
            }
        }
        private void kletka16_Click(object sender, EventArgs e)
        {
            if (kletka16.ForeColor != Color.Black)
            {
                kletka16.ForeColor = Color.Black;
                kletka16.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka16.ForeColor = Color.White;
                kletka16.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka17_Click(object sender, EventArgs e)
        {
            if (kletka17.ForeColor != Color.Black)
            {
                kletka17.ForeColor = Color.Black;
                kletka17.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka17.ForeColor = Color.White;
                kletka17.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka18_Click(object sender, EventArgs e)
        {
            if (kletka18.ForeColor != Color.Black)
            {
                kletka18.ForeColor = Color.Black;
                kletka18.BackColor = Color.Black;
                but18 = 1;
                CheckWin();
            }
            else
            {
                kletka18.ForeColor = Color.White;
                kletka18.BackColor = Color.White;
                but18 = 0;
                CheckWin();
            }
        }
        private void kletka19_Click(object sender, EventArgs e)
        {
            if (kletka19.ForeColor != Color.Black)
            {
                kletka19.ForeColor = Color.Black;
                kletka19.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka19.ForeColor = Color.White;
                kletka19.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka20_Click(object sender, EventArgs e)
        {
            if (kletka20.ForeColor != Color.Black)
            {
                kletka20.ForeColor = Color.Black;
                kletka20.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka20.ForeColor = Color.White;
                kletka20.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka21_Click(object sender, EventArgs e)
        {
            if (kletka21.ForeColor != Color.Black)
            {
                kletka21.ForeColor = Color.Black;
                kletka21.BackColor = Color.Black;
                but21 = 1;
                CheckWin();
            }
            else
            {
                kletka21.ForeColor = Color.White;
                kletka21.BackColor = Color.White;
                but21 = 0; 
                CheckWin();
            }
        }
        private void kletka22_Click(object sender, EventArgs e)
        {
            if (kletka22.ForeColor != Color.Black)
            {
                kletka22.ForeColor = Color.Black;
                kletka22.BackColor = Color.Black;
                but22 = 1;
                CheckWin();
            }
            else
            {
                kletka22.ForeColor = Color.White;
                kletka22.BackColor = Color.White;
                but22 = 0;
                CheckWin(); 
            }
        }
        private void kletka23_Click(object sender, EventArgs e)
        {
            if (kletka23.ForeColor != Color.Black)
            {
                kletka23.ForeColor = Color.Black;
                kletka23.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka23.ForeColor = Color.White;
                kletka23.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka24_Click(object sender, EventArgs e)
        {
            if (kletka24.ForeColor != Color.Black)
            {
                kletka24.ForeColor = Color.Black;
                kletka24.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka24.ForeColor = Color.White;
                kletka24.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka25_Click(object sender, EventArgs e)
        {
            if (kletka25.ForeColor != Color.Black)
            {
                kletka25.ForeColor = Color.Black;
                kletka25.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka25.ForeColor = Color.White;
                kletka25.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }
        private void kletka26_Click(object sender, EventArgs e)
        {
            if (kletka26.ForeColor != Color.Black)
            {
                kletka26.ForeColor = Color.Black;
                kletka26.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka26.ForeColor = Color.White;
                kletka26.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka27_Click(object sender, EventArgs e)
        {
            if (kletka27.ForeColor != Color.Black)
            {
                kletka27.ForeColor = Color.Black;
                kletka27.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka27.ForeColor = Color.White;
                kletka27.BackColor = Color.White;
                pobeda += 1;
            }
        }

        private void kletka28_Click(object sender, EventArgs e)
        {
            if (kletka28.ForeColor != Color.Black)
            {
                kletka28.ForeColor = Color.Black;
                kletka28.BackColor = Color.Black;
                but28 = 1;
                CheckWin();
            }
            else
            {
                kletka28.ForeColor = Color.White;
                kletka28.BackColor = Color.White;
                but28 = 0;
                CheckWin();
            }
        }

        private void kletka29_Click(object sender, EventArgs e)
        {
            if (kletka29.ForeColor != Color.Black)
            {
                kletka29.ForeColor = Color.Black;
                kletka29.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka29.ForeColor = Color.White;
                kletka29.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka30_Click(object sender, EventArgs e)
        {
            if (kletka30.ForeColor != Color.Black)
            {
                kletka30.ForeColor = Color.Black;
                kletka30.BackColor = Color.Black;
                but30 = 1;
                CheckWin();
            }
            else
            {
                kletka30.ForeColor = Color.White;
                kletka30.BackColor = Color.White;
                but30 = 0;
                CheckWin();
            }
        }

        private void kletka31_Click(object sender, EventArgs e)
        {
            if (kletka31.ForeColor != Color.Black)
            {
                kletka31.ForeColor = Color.Black;
                kletka31.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka31.ForeColor = Color.White;
                kletka31.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka32_Click(object sender, EventArgs e)
        {
            if (kletka32.ForeColor != Color.Black)
            {
                kletka32.ForeColor = Color.Black;
                kletka32.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka32.ForeColor = Color.White;
                kletka32.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka33_Click(object sender, EventArgs e)
        {
            if (kletka33.ForeColor != Color.Black)
            {
                kletka33.ForeColor = Color.Black;
                kletka33.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka33.ForeColor = Color.White;
                kletka33.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka34_Click(object sender, EventArgs e)
        {
            if (kletka34.ForeColor != Color.Black)
            {
                kletka34.ForeColor = Color.Black;
                kletka34.BackColor = Color.Black;
                but34 = 1;
                CheckWin();
            }
            else
            {
                kletka34.ForeColor = Color.White;
                kletka34.BackColor = Color.White;
                but34 = 0;
                CheckWin();
            }
        }

        private void kletka35_Click(object sender, EventArgs e)
        {
            if (kletka35.ForeColor != Color.Black)
            {
                kletka35.ForeColor = Color.Black;
                kletka35.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka35.ForeColor = Color.White;
                kletka35.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka36_Click(object sender, EventArgs e)
        {
            if (kletka36.ForeColor != Color.Black)
            {
                kletka36.ForeColor = Color.Black;
                kletka36.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka36.ForeColor = Color.White;
                kletka36.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka37_Click(object sender, EventArgs e)
        {
            if (kletka37.ForeColor != Color.Black)
            {
                kletka37.ForeColor = Color.Black;
                kletka37.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka37.ForeColor = Color.White;
                kletka37.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka38_Click(object sender, EventArgs e)
        {
            if (kletka38.ForeColor != Color.Black)
            {
                kletka38.ForeColor = Color.Black;
                kletka38.BackColor = Color.Black;
                but38 = 1;
                CheckWin();
            }
            else
            {
                kletka38.ForeColor = Color.White;
                kletka38.BackColor = Color.White;
                but38 = 0;
                CheckWin();
            }
        }

        private void kletka39_Click(object sender, EventArgs e)
        {
            if (kletka39.ForeColor != Color.Black)
            {
                kletka39.ForeColor = Color.Black;
                kletka39.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka39.ForeColor = Color.White;
                kletka39.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka40_Click(object sender, EventArgs e)
        {
            if (kletka40.ForeColor != Color.Black)
            {
                kletka40.ForeColor = Color.Black;
                kletka40.BackColor = Color.Black;
                but40 = 1;
                CheckWin();
            }
            else
            {
                kletka40.ForeColor = Color.White;
                kletka40.BackColor = Color.White;
                but40 = 0;
                CheckWin();
            }
        }

        private void kletka41_Click(object sender, EventArgs e)
        {
            if (kletka41.ForeColor != Color.Black)
            {
                kletka41.ForeColor = Color.Black;
                kletka41.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka41.ForeColor = Color.White;
                kletka41.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka42_Click(object sender, EventArgs e)
        {
            if (kletka42.ForeColor != Color.Black)
            {
                kletka42.ForeColor = Color.Black;
                kletka42.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka42.ForeColor = Color.White;
                kletka42.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka43_Click(object sender, EventArgs e)
        {
            if (kletka43.ForeColor != Color.Black)
            {
                kletka43.ForeColor = Color.Black;
                kletka43.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka43.ForeColor = Color.White;
                kletka43.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka44_Click(object sender, EventArgs e)
        {
            if (kletka44.ForeColor != Color.Black)
            {
                kletka44.ForeColor = Color.Black;
                kletka44.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka44.ForeColor = Color.White;
                kletka44.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka45_Click(object sender, EventArgs e)
        {
            if (kletka45.ForeColor != Color.Black)
            {
                kletka45.ForeColor = Color.Black;
                kletka45.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka45.ForeColor = Color.White;
                kletka45.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka46_Click(object sender, EventArgs e)
        {
            if (kletka46.ForeColor != Color.Black)
            {
                kletka46.ForeColor = Color.Black;
                kletka46.BackColor = Color.Black;
                but46 = 1;
                CheckWin();
            }
            else
            {
                kletka46.ForeColor = Color.White;
                kletka46.BackColor = Color.White;
                but46 = 0;
                CheckWin();
            }
        }

        private void kletka47_Click(object sender, EventArgs e)
        {
            if (kletka47.ForeColor != Color.Black)
            {
                kletka47.ForeColor = Color.Black;
                kletka47.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka47.ForeColor = Color.White;
                kletka47.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka48_Click(object sender, EventArgs e)
        {
            if (kletka48.ForeColor != Color.Black)
            {
                kletka48.ForeColor = Color.Black;
                kletka48.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka48.ForeColor = Color.White;
                kletka48.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka49_Click(object sender, EventArgs e)
        {
            if (kletka49.ForeColor != Color.Black)
            {
                kletka49.ForeColor = Color.Black;
                kletka49.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka49.ForeColor = Color.White;
                kletka49.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka50_Click(object sender, EventArgs e)
        {
            if (kletka50.ForeColor != Color.Black)
            {
                kletka50.ForeColor = Color.Black;
                kletka50.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka50.ForeColor = Color.White;
                kletka50.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka51_Click(object sender, EventArgs e)
        {
            if (kletka51.ForeColor != Color.Black)
            {
                kletka51.ForeColor = Color.Black;
                kletka51.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka51.ForeColor = Color.White;
                kletka51.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka52_Click(object sender, EventArgs e)
        {
            if (kletka52.ForeColor != Color.Black)
            {
                kletka52.ForeColor = Color.Black;
                kletka52.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka52.ForeColor = Color.White;
                kletka52.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka53_Click(object sender, EventArgs e)
        {
            if (kletka53.ForeColor != Color.Black)
            {
                kletka53.ForeColor = Color.Black;
                kletka53.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka53.ForeColor = Color.White;
                kletka53.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka54_Click(object sender, EventArgs e)
        {
            if (kletka54.ForeColor != Color.Black)
            {
                kletka54.ForeColor = Color.Black;
                kletka54.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka54.ForeColor = Color.White;
                kletka54.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka55_Click(object sender, EventArgs e)
        {
            if (kletka55.ForeColor != Color.Black)
            {
                kletka55.ForeColor = Color.Black;
                kletka55.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka55.ForeColor = Color.White;
                kletka55.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

        private void kletka56_Click(object sender, EventArgs e)
        {
            if (kletka56.ForeColor != Color.Black)
            {
                kletka56.ForeColor = Color.Black;
                kletka56.BackColor = Color.Black;
                pobeda -= 1;
                CheckWin();
            }
            else
            {
                kletka56.ForeColor = Color.White;
                kletka56.BackColor = Color.White;
                pobeda += 1;
                CheckWin();
            }
        }

    }
}
