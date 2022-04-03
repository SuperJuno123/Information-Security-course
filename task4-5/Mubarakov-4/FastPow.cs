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
    public partial class FastPow : Form
    {
        public FastPow()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            textBox_ai.Text = "";
            textBox_bi.Text = "";
            textBox_step.Text = "";

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

            textBox_b_binary.Text = string.Join(" ", b.ToByteArray().Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));


            int step = 1;

            BigInteger result = 1;
            BigInteger ai = a;
            //первый бит - самый правый
            while (b > 0)
            {
                textBox_ai.AppendText(ai.ToString() + "\n\n");
                textBox_step.AppendText(step.ToString() + "\n\n");
                textBox_bi.AppendText(((b & 1).ToString() + "\n\n"));
                if ((b & 1) == 1)
                {
                    result *= ai;
                }
                ai *= ai;
                b >>= 1; // тоже самое что b = b >> 1; 
                step++;
            }

            textBox_result.Text = result.ToString();

        }

        private void FastPow_Load(object sender, EventArgs e)
        {

        }

        private void button_FastModPow_Click(object sender, EventArgs e)
        {
            textBox_ai.Text = "";
            textBox_bi.Text = "";
            textBox_step.Text = "";
            textBox_ai_mod.Text = "";

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

            BigInteger modulus = new BigInteger();

            if (!BigInteger.TryParse(textBox_modulus.Text, out modulus))
            {
                MessageBox.Show("Введите модуль");
                return;
            }


            textBox_b_binary.Text = string.Join(" ", b.ToByteArray().Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));


            int step = 1;

            BigInteger result = 1;
            BigInteger ai = a;
            //первый бит - самый правый
            while (b > 0)
            {
                textBox_ai_mod.AppendText(ai.ToString() + "\n\n");
                textBox_step.AppendText(step.ToString() + "\n\n");
                textBox_bi.AppendText(((b & 1).ToString() + "\n\n"));
                if ((b & 1) == 1)
                {
                    result = result * ai  % modulus;
                }
                ai = ai * ai;
                textBox_ai.AppendText(ai.ToString() + "\n\n");
                ai = ai % modulus;
                b >>= 1; // тоже самое что b = b >> 1;
                step++;
            }

            textBox_result.Text = result.ToString();
        }
    }
}
