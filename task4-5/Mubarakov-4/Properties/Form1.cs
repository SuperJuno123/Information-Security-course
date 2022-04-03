using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mubarakov_4
{
    public partial class Form1 : Form
    {

        static UnicodeEncoding byteConverter = new UnicodeEncoding();


        static BigInteger p;
        static BigInteger q;
        static BigInteger n;
        static BigInteger e;
        static BigInteger d;
        static Tuple<BigInteger, BigInteger> openKey;
        static Tuple<BigInteger, BigInteger> closedKey;
        static byte[] input;
        static byte[] encrypted;
        static byte[] decrypted;


        public Form1()
        {
            var rsa = new RSA();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int length_in_bits;

            if (!int.TryParse(textBoxDimensity.Text, out length_in_bits))
            {
                MessageBox.Show("Укажите размерность n");
                return;
            }

            p = RSA.generatePrimeNumber(length_in_bits);
            textBox_p.Text = p.ToString();
            label10.Text = p.ToString().Length.ToString();

            q = RSA.generatePrimeNumber(length_in_bits);
            textBox_q.Text = q.ToString();
            label11.Text = q.ToString().Length.ToString();

            n = p * q;
            textBox_n.Text = n.ToString();
            label12.Text = n.ToString().Length.ToString();

            BigInteger fi = (p - 1) * (q - 1);
            textBox_fi_n.Text = fi.ToString();
            label13.Text = fi.ToString().Length.ToString();


            (openKey, closedKey) = RSA.generateKey(p, q);
            var _e = openKey.Item2;
            textBox_e.Text = _e.ToString();
            label14.Text = _e.ToString().Length.ToString();

            d = closedKey.Item2;
            textBox_d.Text = d.ToString();
            label15.Text = d.ToString().Length.ToString();

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (openKey == null)
            {
                buttonGenerate_Click(sender, e);
            }

            string inputStr = textBoxOriginal.Text;

            string encryptedStr = RSA.Encrypt(inputStr, openKey);

            textBoxEncrypted.Text = encryptedStr;


        }

        private void textBoxDimensity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (closedKey == null)
            {
                buttonGenerate_Click(sender, e);
            }

            string decryptedStr = RSA.Decrypt(textBoxEncrypted.Text, closedKey);

            textBoxDecrypted.Text = decryptedStr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new EEA();
            m.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new FastPow();
            m.Show();

        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new MillerRabin();
            m.Show();
        }
    }
}
