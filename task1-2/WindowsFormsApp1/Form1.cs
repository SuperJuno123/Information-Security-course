using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string currentMode = "visioner";

        static List<char> englishAlphabet = new List<char>("abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray());

        static List<char> russianAlphabet = new List<char>("абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789".ToCharArray());

        static List<char> digitsAlphabet = new List<char>("0123456789".ToCharArray());

        List<char> currentAlphabet = englishAlphabet;


        public Form1()
        {
            InitializeComponent();
            textBoxInfo.Text += "Текущий алфавит: английский" + Environment.NewLine;
        }

        private bool CheckInputTextBox(TextBox textBox)
        {
            string text = textBox.Text;

            foreach (char symbol in text)
            {
                if (symbol == ' ')
                    continue;
                //textBoxInfo.Text += symbol;
                if (!currentAlphabet.Contains(symbol))
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
            textBoxInput.Text = textBoxInput.Text.ToLower();

            if (currentMode == "caesar")
            {
                if (!CheckInputTextBox(textBoxInput))
                {
                    MessageBox.Show("Выбранный алфавит символов и ваш текст не совпадают!");
                    return;
                }


                textBoxInput.Text = textBoxInput.Text.ToLower();
                BigInteger key = new BigInteger();


                if (!BigInteger.TryParse(textBox1.Text, out key))
                {
                    MessageBox.Show("Введите ключ");
                    return;
                }
                textBoxOutput.Text = CeasarEncrypt(textBoxInput.Text, key);
            }
            else
            {
                if (!CheckInputTextBox(textBox1) || !CheckInputTextBox(textBoxInput))
                {
                    MessageBox.Show("Либо ключ, либо текст не соответствуют выбранному алфавиту");
                    return;
                }

                string inputKey = textBox1.Text;

                string key = CreateKey(inputKey, textBoxInput.Text.Length);

                //textBox1.Text = key;
                textBoxInfo.Text += "Ключевая строка имеет вид: " + key + Environment.NewLine;
                textBoxOutput.Text = VisionerEncrypt(textBoxInput.Text, key);

            }
        }

        string CreateKey(string keyword, int lenght)
        {
            int remainder;
            int quotient = Math.DivRem(lenght, keyword.Length, out remainder);
            return string.Concat(Enumerable.Repeat(keyword, quotient)) + keyword.Substring(0, remainder);
        }


        private string CeasarEncrypt(string text, BigInteger key)
        {
            //            /// y = (x + k) mod n
            //            x = (y - k) mod n
            //где x — символ открытого текста, y — символ шифрованного текста, n — мощность алфавита, а k — ключ.

            StringBuilder newText = new StringBuilder();

            foreach (char symbol in text)
            {
                if (symbol == ' ')
                {
                    newText.Append(symbol);
                    continue;
                }

                var y = (currentAlphabet.IndexOf(symbol) + key) % currentAlphabet.Count;

                if (y < 0)
                    y += currentAlphabet.Count;
                newText.Append(currentAlphabet[(int)y]);
            }

            return newText.ToString();
        }


        private string CeasarDecrypt(string text, BigInteger key)
        {
            StringBuilder newText = new StringBuilder();

            foreach (char symbol in text)
            {
                if (symbol == ' ')
                {
                    newText.Append(symbol);
                    continue;
                }

                var y = (currentAlphabet.IndexOf(symbol) - key) % currentAlphabet.Count;

                if (y < 0)
                    y += currentAlphabet.Count;
                newText.Append(currentAlphabet[(int)y]);
            }

            return newText.ToString();
        }

        private void buttonChooseMode_Click(object sender, EventArgs e)
        {
            var secondForm = new Form2();
            secondForm.ShowDialog();

            if (secondForm.DialogResult == DialogResult.OK)
            {
                currentMode = secondForm.ReturnData();
                this.Text = currentMode;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentAlphabet = englishAlphabet;
            this.textBoxInfo.Text += "Вы изменили алфавит на английский" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            currentAlphabet = russianAlphabet;
            this.textBoxInfo.Text += "Вы изменили алфавит на русский" + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            currentAlphabet = digitsAlphabet;
            this.textBoxInfo.Text += "Вы изменили алфавит на цифры" + Environment.NewLine;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (!CheckInputTextBox(textBoxOutput))
            {
                MessageBox.Show("Текст, который вы пытаетесь дешифровать, не соответствует выбранному алфавиту!");
                return;
            }

            if (currentMode == "caesar")
            {

                BigInteger key = new BigInteger();

                if (!BigInteger.TryParse(textBox1.Text, out key))
                {
                    MessageBox.Show("Введите ключ");
                    return;
                }
                textBoxDecrypredOriginalText.Text = CeasarDecrypt(textBoxOutput.Text, key);
            }
            else
            {
                if (!CheckInputTextBox(textBox1))
                {
                    MessageBox.Show("Ключ, которым вы пытаетесь дешифровать сообщение, не соответствует текущему алфавиту!");
                    return;
                }

                string key = textBox1.Text;
                string text = textBoxOutput.Text;

                if (key.Length != text.Length)
                {
                    key = CreateKey(key, textBoxInput.Text.Length);
                    //textBox1.Text = key;
                    //textBoxInfo.Text += "Ключевая строка имеет вид: " + key + Environment.NewLine;
                }

                textBoxDecrypredOriginalText.Text = VisionerDecrypt(text, key);
            }
        }

        string VisionerDecrypt(string text, string key)
        {
            if (text.Length != key.Length)
            {
                MessageBox.Show("Произошла ошибка в генерации ключа");
                return "";
            }

            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    newText.Append(' ');
                    continue;
                }
                var m_j = (currentAlphabet.IndexOf(text[i]) + currentAlphabet.Count - currentAlphabet.IndexOf(key[i])) % currentAlphabet.Count;
                newText.Append(currentAlphabet[m_j]);
            }

            return newText.ToString();
        }

        string VisionerEncrypt(string text, string key)
        {
            if (text.Length != key.Length)
            {
                MessageBox.Show("Произошла ошибка в генерации ключа");
                return "";
            }

            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    newText.Append(' ');
                    continue;
                }
                var c_j = (currentAlphabet.IndexOf(text[i]) + currentAlphabet.IndexOf(key[i])) % currentAlphabet.Count;
                newText.Append(currentAlphabet[c_j]);
            }

            return newText.ToString();
        }
    }
}
