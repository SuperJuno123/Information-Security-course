using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mubarakov_4
{
    public partial class EEA : Form
    {
        static BigInteger a;
        static BigInteger b;

        public EEA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_ai.Text = "";
            textBox_ai_next.Text = "";
            textBox_ai_prev.Text = "";
            textBox_xi.Text = "";
            textBox_xi_prev.Text = "";
            textBox_yi.Text = "";
            textBox_yi_prev.Text = "";
            textBox_step.Text = "";
            textBox_q.Text = "";


            BigInteger a = new BigInteger();


            if (!BigInteger.TryParse(textBox_a.Text, out a))
            {
                MessageBox.Show("Введите число a");
                return;
            }            

            BigInteger b = new BigInteger();

            if (!BigInteger.TryParse(textBox_b.Text, out b))
            {
                MessageBox.Show("Введите число b");
                return;
            }

            if (b > a)
            {
                RSA.swap(ref a, ref b);
            }

            int step = 1;
            BigInteger a0 = a, b0 = b, x0 = 1, y0 = 0, x1 = 0, y1 = 1;



            while (b != 0)
            {
                textBox_step.AppendText(step.ToString() + "\n\n");
                textBox_xi_prev.AppendText(x0.ToString() + "\n\n");
                textBox_yi_prev.AppendText(y0.ToString() + "\n\n");
                textBox_xi.AppendText(x1.ToString() + "\n\n");
                textBox_yi.AppendText(y1.ToString() + "\n\n");
                textBox_ai_prev.AppendText(a.ToString() + "\n\n");
                textBox_ai.AppendText(b.ToString() + "\n\n");

                BigInteger remainder = 0;
                BigInteger quotient = BigInteger.DivRem(a, b, out remainder);
                //https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger.divide?view=netcore-3.1

                a = b;
                b = remainder;

                textBox_ai_next.AppendText(b.ToString() + "\n\n");
                textBox_q.AppendText(quotient.ToString() + "\n\n");

                var x0_buff = x0;
                x0 = x1;
                x1 = x0_buff - quotient * x1;


                var y0_buff = y0;
                y0 = y1;
                y1 = y0_buff - quotient * y1;

                step++;
            }

            if (!BigInteger.TryParse(textBox_a.Text, out a))
            {
                MessageBox.Show("Введите число a");
                return;
            }


            if (!BigInteger.TryParse(textBox_b.Text, out b))
            {
                MessageBox.Show("Введите число b");
                return;
            }

            var result = RSA.extendedEuclideanAlgorithm(a, b);

            var x = result.Item1;
            var y = result.Item2;
            var GCD = result.Item3;


            textBox_result_x.Text = x.ToString();
            textBox_result_y.Text = y.ToString();
            textBox_result_G.Text = GCD.ToString();

            textBox_result_a.Text = a.ToString();
            textBox_result_b.Text = b.ToString();

        }

        private void textBox_result_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void EEA_Load(object sender, EventArgs e)
        {

        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_step_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_G_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_yi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_xi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_yi_prev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_xi_prev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ai_next_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ai_prev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
