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
    public partial class MillerRabin : Form
    {
        public MillerRabin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_steps.Text = string.Empty;

            BigInteger p;

            if (!BigInteger.TryParse(textBox_p.Text, out p))
            {
                MessageBox.Show("Введите число, которое будет проверяться на простоту");
                return;
            }

            int n_rounds;

            if (!int.TryParse(textBox_n_rounds.Text, out n_rounds))
            {
                //MessageBox.Show((p.ToByteArray().Length*8).ToString());
                n_rounds = (int)(Math.Ceiling(BigInteger.Log10(p)/BigInteger.Log10(2))); //  Рекомендуется брать количество раундов (свидетелей простоты) равное величине логарифма n по основанию 2
                textBox_n_rounds.Text = n_rounds.ToString();
            }


            if (p < 2 || p % 2 == 0)
            {
                if (p == 2)
                {
                    textBox_result.Text = "Простое";
                    return;
                }
                else
                {
                    textBox_steps.AppendText("Число чётное, либо равно 1\n");
                    textBox_result.Text = "Составное";
                    return;
                }
            }

            textBox_steps.AppendText("представим p − 1 в виде (2^s)·d (d-нечетно), производим последовательные деления p - 1 на 2\n");
            BigInteger d = p - 1;

            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            textBox_steps.AppendText(string.Format("{0} − 1 = (2^{1})·{2}\n", p, s, d));


            for (int i = 0; i < n_rounds; i++)
            {
                textBox_steps.AppendText(string.Format("Выберем случайное целое число в отрезке[2, p − 1]\n"));
                // выберем случайное целое число a в отрезке [2, p − 1]
                BigInteger a;
                do
                {
                    a = RSA.randomBigIntLessOrEqualLength(p.ToByteArray().Length);
                    textBox_steps.AppendText(string.Format("Сгенерировано случайное число: {0}\n", a));
                    //Console.WriteLine("Попытка подобрать а: {0}", a, Color.Plum);
                }
                while (a < 2 || a > p - 1);

                //Console.WriteLine("a = {0}", a, Color.Pink);
                textBox_steps.AppendText(string.Format("Подобрано случайное число: {0}, большее или равное 2 и меньшее или равное p - 1\n", a));

                BigInteger x = RSA.fastModPow(a, d, p); // x = a^d (mod p)

                textBox_steps.AppendText(string.Format("x = a^d (mod p): {0}\n", x));


                if (x == 1 || x == p - 1)
                {                   
                    textBox_steps.AppendText(string.Format("Получен свидетель простоты по первому условию (a^d = ±1 mod p)\n", x));
                    continue; // + свидетель простоты по первому условию (a в степени d = плюс/минус мод p)
                }
                for (int r = 1; r < s; r++)
                {
                    x = RSA.fastModPow(x, 2, p); // x = a^(2^r*d) (mod p)

                    if (x == 1)
                    {

                        textBox_steps.AppendText(string.Format("a^2(mod p) == 1. Испытание квадратным корнем не пройдено!\n" +
                            "Так как x равно 1 на этом шаге и имело на предыдущем шаге другое значение, чем  ±1 (причина, почему мы не остановились на предыдущем шаге)\n", x));
                        textBox_result.Text = "Составное";
                        return;
                    }
                    if (x == p - 1)
                    {                       
                        textBox_steps.AppendText(string.Format("Получен свидетель простоты по второму условию a^(2^r*d) = -1 (mod p)\n", x));
                        break; // + свидетель простоты по второму условию a^(2^r*d) = -1 (mod p)
                    }
                }

                if (x != p - 1)
                {
                    textBox_steps.AppendText(string.Format("Второе условие не соблюдено: a^(2^r*d) != -1 (mod p). Число является составным\n", x));
                    textBox_result.Text = "Составное";
                    return;
                    // + св. непростоты по 2 условию
                }
            }


            textBox_result.Text = "Простое";



        }

        private void textBox_result_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void MillerRabin_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_G_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_n_rounds.Text = string.Empty;
        }

        private void textBox_result_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_random_one_number_Click(object sender, EventArgs e)
        {
            int length;

            if (!int.TryParse(textBox_length_in_bit.Text, out length))
            {
                MessageBox.Show("Введите длину числа");
                return;
            }

            BigInteger p = RSA.randomBigIntOfThisLength(length);

            if (p < 0)
                p = -p;

            textBox_p.Text = p.ToString();

            button1_Click(sender, e);
        }

        private void button_start_many_iteration_Click(object sender, EventArgs e)
        {
            int length;

            if (!int.TryParse(textBox_length_in_bit.Text, out length))
            {
                MessageBox.Show("Введите длину числа");
                return;
            }

            var p = RSA.generatePrimeNumber(length);

            textBox_p.Text = p.ToString();

            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var link = String.Format("https://www.wolframalpha.com/input/?i=isprime%28{0}%29", textBox_p.Text);

            System.Diagnostics.Process.Start(link);
        }
    }
}
