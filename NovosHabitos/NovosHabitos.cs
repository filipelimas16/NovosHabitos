using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovosHabitos
{
    public partial class NovosHabitos : Form
    {
        int somaA = 0;
        int somaB = 0;
        int somaC = 0;
        int somaD = 0;

        public NovosHabitos()
        {
            InitializeComponent();
        }

        //linha A
        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.Text = "V";

            if (btnA1.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA1.Enabled = false;
            btnA1.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.Text = "V";

            if (btnA2.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA2.Enabled = false;
            btnA2.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.Text = "V";

            if (btnA3.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA3.Enabled = false;
            btnA3.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.Text = "V";

            if (btnA4.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA4.Enabled = false;
            btnA4.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.Text = "V";

            if (btnA5.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA5.Enabled = false;
            btnA5.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            btnA6.Text = "V";

            if (btnA6.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA6.Enabled = false;
            btnA6.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            btnA7.Text = "V";

            if (btnA7.Text == "V")
            {
                somaA = somaA + 1;
            }

            btnA7.Enabled = false;
            btnA7.BackgroundImage = Properties.Resources.check;
            finalA();
        }

        public void finalA()
        {
            if (somaA <= 2)
            {
                lblA.Text = "Ruim!!";
                pictureBox1.Image = Properties.Resources.triste;
            }
            if (somaA == 3 || somaA == 4)
            {
                lblA.Text = "Regular!!";
                pictureBox1.Image = Properties.Resources.normal;
            }
            if (somaA >= 5)
            {
                lblA.Text = "Excelente!!";
                pictureBox1.Image = Properties.Resources.feliz;
            }
            else
            {
                
            }
        }

        //linha B
        private void btnB1_Click(object sender, EventArgs e)
        {
            btnB1.Text = "V";

            if (btnB1.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB1.Enabled = false;
            btnB1.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.Text = "V";

            if (btnB2.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB2.Enabled = false;
            btnB2.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.Text = "V";

            if (btnB3.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB3.Enabled = false;
            btnB3.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            btnB4.Text = "V";

            if (btnB4.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB4.Enabled = false;
            btnB4.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            btnB5.Text = "V";

            if (btnB5.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB5.Enabled = false;
            btnB5.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            btnB6.Text = "V";

            if (btnB6.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB6.Enabled = false;
            btnB6.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            btnB7.Text = "V";

            if (btnB7.Text == "V")
            {
                somaB = somaB + 1;
            }

            btnB7.Enabled = false;
            btnB7.BackgroundImage = Properties.Resources.check;
            finalB();
        }

        public void finalB()
        {
            if (somaB <= 2)
            {
                lblB.Text = "Ruim!!";
                pictureBox2.Image = Properties.Resources.triste;

            }
            if (somaB == 3 || somaB == 4)
            {
                lblB.Text = "Regular!!";
                pictureBox2.Image = Properties.Resources.duvida;

            }
            if (somaB >= 5)
            {
                lblB.Text = "Excelente!!";
                pictureBox2.Image = Properties.Resources.feliz;

            }
            else
            {

            }
        }

        //linha C
        private void btnC1_Click(object sender, EventArgs e)
        {
            btnC1.Text = "V";

            if (btnC1.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC1.Enabled = false;
            btnC1.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            btnC2.Text = "V";

            if (btnC2.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC2.Enabled = false;
            btnC2.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            btnC3.Text = "V";

            if (btnC3.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC3.Enabled = false;
            btnC3.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            btnC4.Text = "V";

            if (btnC4.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC4.Enabled = false;
            btnC4.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            btnC5.Text = "V";

            if (btnC5.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC5.Enabled = false;
            btnC5.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            btnC6.Text = "V";

            if (btnC6.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC6.Enabled = false;
            btnC6.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            btnC7.Text = "V";

            if (btnC7.Text == "V")
            {
                somaC = somaC + 1;
            }

            btnC7.Enabled = false;
            btnC7.BackgroundImage = Properties.Resources.check;
            finalC();
        }

        public void finalC()
        {
            if (somaC <= 2)
            {
                lblC.Text = "Ruim!!";
                pictureBox3.Image = Properties.Resources.triste;
            }
            if (somaC == 3 || somaC == 4)
            {
                lblC.Text = "Regular!!";
                pictureBox3.Image = Properties.Resources.duvida;
            }
            if (somaC >= 5)
            {
                lblC.Text = "Excelente!!";
                pictureBox3.Image = Properties.Resources.feliz;
            }
            else
            {

            }
        }

        //linha D
        private void btnD1_Click(object sender, EventArgs e)
        {
            btnD1.Text = "V";

            if (btnD1.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD1.Enabled = false;
            btnD1.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            btnD2.Text = "V";

            if (btnD2.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD2.Enabled = false;
            btnD2.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            btnD3.Text = "V";

            if (btnD3.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD3.Enabled = false;
            btnD3.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            btnD4.Text = "V";

            if (btnD4.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD4.Enabled = false;
            btnD4.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            btnD5.Text = "V";

            if (btnD5.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD5.Enabled = false;
            btnD5.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            btnD6.Text = "V";

            if (btnD6.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD6.Enabled = false;
            btnD6.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            btnD7.Text = "V";

            if (btnD7.Text == "V")
            {
                somaD = somaD + 1;
            }

            btnD7.Enabled = false;
            btnD7.BackgroundImage = Properties.Resources.check;
            finalD();
        }

        public void finalD()
        {
            if (somaD <= 2)
            {
                lblD.Text = "Ruim!!";
                pictureBox4.Image = Properties.Resources.triste;
            }
            if (somaD == 3 || somaD == 4)
            {
                lblD.Text = "Regular!!";
                pictureBox4.Image = Properties.Resources.duvida;
            }
            if (somaD >= 5)
            {
                lblD.Text = "Excelente!!";
                pictureBox4.Image = Properties.Resources.feliz;
                
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NovosHabitos_Load(object sender, EventArgs e)
        {

        }
    }
}
