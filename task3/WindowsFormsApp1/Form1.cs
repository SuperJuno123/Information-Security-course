using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<char> alphabet = new List<char>(" !@#$%^&*()_-+=`~\\|/'\"{}:;<>.,[]0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray());

        static public string inputText;
        static public byte[] byte_inputText;

        static public string encryptedText;
        static public byte[] byte_encryptedText;

        static public string decryptedText;
        static public byte[] byte_decryptedText;


        Encoding currendEncoding = Encoding.GetEncoding("windows-1251");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxInputText.Text == "")
            {
                MessageBox.Show("Введите текст");
                return;
            }
            textBoxInputTextBinary.Text = OrdinalToBinary(textBoxInputText.Text);
        }

        private string OrdinalToBinary(string text)
        {
            var bytes = StringToByteArray(text);

            StringBuilder result = new StringBuilder();

            foreach (var _byte in bytes)
            {
                // Сначала переводим каждый байтик в строку (дв. вид), потом добиваем слева нуликами

                result.Append(Convert.ToString(_byte, 2).PadLeft(8, '0') + " ");
            }


            return result.ToString();
        }

        private string BinaryToOrdinal(string text)
        {
            text = text.Replace(" ", "");

            if (text.Length % 8 != 0)
            {
                MessageBox.Show("Двоичный код неверен. Проверьте количество символов. Каждые 8 символов соответствуют одному байту");
                return "";
            }

            byte[] bytes = new byte[text.Length];
            for (int i = 0; i < text.Length; i += 8)
            {
                try
                {
                    bytes[(int)i / 8] = Convert.ToByte(text.Substring(i, 8), 2);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Вы ввели символы не из двоичного алфавита");
                    return "";
                }


            }
            return ByteArrayToString(bytes);
        }

        private byte[] StringToByteArray(string str)
        {
            var encoding = Encoding.Unicode;
            return encoding.GetBytes(str);
        }

        private int[] StringToIntArray(string str)
        {
            int[] array = new int[str.Length];
            int i = 0;
            foreach (var symbol in str)
            {
                array[i] = alphabet.IndexOf(symbol);
                i++;
            }
            return array;
        }


        private string ByteArrayToString(byte[] data)
        {
            return Encoding.Unicode.GetString(data).Replace("\0", "");
        }

        private string IntArrayToString(int[] data)
        {
            StringBuilder str = new StringBuilder();

            foreach (var elem in data)
            {
                str.Append(alphabet[elem]);
            }
            return str.ToString();
        }

        private void buttonKeyEncrypt_Click(object sender, EventArgs e)
        {
            string key;

            if (textBoxInputText.Text == "")
            {
                if (textBoxInputTextBinary.Text == "")
                {
                    MessageBox.Show("Введите текст в бинарном либо обычном виде");
                    return;
                }
                else
                {
                    inputText = BinaryToOrdinal(textBoxInputTextBinary.Text);
                    textBoxInputText.Text = inputText;
                }
            }
            else
            {
                inputText = textBoxInputText.Text;
                textBoxInputTextBinary.Text = OrdinalToBinary(textBoxInputText.Text);
            }

            if (textBoxKey.Text == "")
            {
                if (textBoxKeyBinary.Text == "")
                {
                    MessageBox.Show("Введите ключ в бинарном либо обычном виде");
                    return;
                }
                else
                {
                    key = BinaryToOrdinal(textBoxKeyBinary.Text);
                    textBoxKey.Text = key;
                }
            }
            else
            {
                key = textBoxKey.Text;
                textBoxKeyBinary.Text = OrdinalToBinary(key);
            }

            textBoxInfo.AppendText(String.Format("Зашифровываем текст с помощью пользовательского ключа\n ", key) );

            //text = text.Trim().Replace("\r", "");


            if (inputText.Length < key.Length)
            {
                MessageBox.Show(String.Format("Ошибка! Длина ключа ({0}) превышает длину текста ({1})", key.Length, inputText.Length));
                return;
            }

            if (inputText.Length != key.Length)
            {
                textBoxInfo.AppendText(String.Format("Ключ имеет длину {0}, он будет дополнен до длины текста ({1})\n", key.Length, inputText.Length) );
                if (key.Length != 0)
                {
                    key = CreateKey(key, inputText.Length);
                    textBoxKey.Text = key;
                }

            }

            encryptedText = XOR_Encrypt_2(inputText, key);
            textBoxResult.Text = BinaryToOrdinal(OrdinalToBinary(encryptedText));
            textBoxResultBinary.Text = OrdinalToBinary(textBoxResult.Text);

        }

        string CreateKey(string keyword, int lenght)
        {
            int remainder;
            int quotient = Math.DivRem(lenght, keyword.Length, out remainder);
            return string.Concat(Enumerable.Repeat(keyword, quotient)) + keyword.Substring(0, remainder);
        }


        private BigInteger StringToBigInt(string str)
        {
            return new BigInteger(StringToByteArray(str));
        }

        private string BigIntToString(BigInteger bigInt)
        {
            return ByteArrayToString(bigInt.ToByteArray());
        }




        private bool IsKeyEmpty(string key)
        {
            return (key == "");
        }

        private BigInteger XOR_Encrypt_old(BigInteger message, BigInteger gamma)
        {
            return message ^ gamma;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBoxInputTextBinary.Text == "")
            {
                MessageBox.Show("Введите двоичный код");
                return;
            }
            textBoxInputText.Text = BinaryToOrdinal(textBoxInputTextBinary.Text);

        }

        private void buttonRandomEncrypt_Click(object sender, EventArgs e)
        {

            if (textBoxInputText.Text == "")
            {
                if (textBoxInputTextBinary.Text == "")
                {
                    MessageBox.Show("Введите текст в бинарном либо обычном виде");
                    return;
                }
                else
                {
                    inputText = BinaryToOrdinal(textBoxInputTextBinary.Text);
                    textBoxInputText.Text = inputText;
                }
            }
            else
            {
                inputText = textBoxInputText.Text;
                textBoxInputTextBinary.Text = OrdinalToBinary(textBoxInputText.Text);
            }

            textBoxInfo.AppendText(String.Format("Зашифровываем текст с помощью псевдослучайной последовательности длины {0}", inputText.Length) + "\n");

            //var key = String.Join("", alphabet.OrderBy(x => rnd.Next()).Take(inputText.Length));

            //var key = GetRandomKey(inputText.Length);

            var bytes_count = Encoding.Unicode.GetBytes(inputText).Length;

            var binary_string_key = CreateRandomSequence(bytes_count);

            textBoxRandomKey.Text = BinaryToOrdinal(binary_string_key);


            textBoxRandomKeyBinary.Text = binary_string_key;

            
            var ones = CountWords(binary_string_key, "1");
            var zeros = CountWords(binary_string_key, "0");


            textBoxInfo.AppendText(String.Format("Обратим внимание, что для повышения криптостойкости шифрования мы используем равное количество нулей и единиц в гамме.\n " +
                "Проверим, действительно ли это так \n" +
                "Количество единиц: {0}, количество нулей: {1}, общее количество битов {2} при длине текста {3}\n", ones, zeros, bytes_count * 8, inputText.Length));

            encryptedText = XOR_Encrypt_2(inputText, BinaryToOrdinal(binary_string_key));

            textBoxResult.Text = BinaryToOrdinal(OrdinalToBinary(encryptedText));

            textBoxResultBinary.Text = OrdinalToBinary(encryptedText);

        }

        private int CountWords(string s, string s0)
        {
            int count = (s.Length - s.Replace(s0, "").Length) / s0.Length;
            return count;
        }


        private string GetRandomKey(int length)
        {
            var gamma = new StringBuilder();
            var rnd = new Random();
            for (var i = 0; i < length; i++)
            {
                gamma.Append(((char)rnd.Next(33, 126)).ToString());
                // с 26 по 127 находятся: символы английского алфавита, основные знаки пунктуации. Кракозябр нет
            }
            return gamma.ToString();
        }

        private string CreateRandomSequence(int length_in_bytes)
        {
            Random rnd = new Random();

            int length_in_bits = length_in_bytes * 8;

            int a = length_in_bits / 2;

            StringBuilder str = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                str.Append('0');
            }
            for (int i = a; i < length_in_bits; i++)
            {
                str.Append('1');
            }

            var result = str.ToString();

            var shuffled = string.Join("", result.OrderBy(x => rnd.Next()));

            return shuffled;
        }

        private string XOR_Decrypt_2(string result, string key)
        {

            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == ' ')
                {
                    newText.Append(' ');
                    continue;
                }

                var y = alphabet.IndexOf(result[i]) ^ alphabet.IndexOf(key[i]);
                while (y < 0)
                    y += alphabet.Count;
                newText.Append(alphabet[y]);
            }

            return newText.ToString();
        }

        private bool CheckInputTextBox(TextBox textBox)
        {
            string text = textBox.Text;

            foreach (char symbol in text)
            {
                if (symbol == ' ')
                    continue;
                //textBoxInfo.AppendText(symbol;
                if (!alphabet.Contains(symbol))
                    return false;
            }
            return true;
        }

        private string XOR_Encrypt_1(string text, string key)
        {
            if (text.Length != key.Length)
            {
                key = CreateKey(key, text.Length);
            }
            // 1 вариант: Гаммирование с двоичным алфавитом

            byte[] textArray = currendEncoding.GetBytes(text);
            byte[] keyArray = currendEncoding.GetBytes(key);

            byte[] newArray = new byte[textArray.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToByte(textArray[i] ^ keyArray[i]);
            }

            return ByteArrayToString(newArray);

            // 2 вариант: Гаммирование с модулем, равным длине алфавита (обычное гаммирование)

            //StringBuilder newText = new StringBuilder();

            //for (int i = 0; i < text.Length; i++)
            //{
            // var newIndex = alphabet.IndexOf(text[i]) ^ alphabet.IndexOf(key[i] % alphabet.Length);

            // newText.Append(alphabet[newIndex]);
            //}

            //return newText.ToString();
        }

        private string XOR_Encrypt_2(string text, string key)
        {
            if (text.Length != key.Length)
            {
                MessageBox.Show(String.Format("Длина текста: {0}, а длина ключа {1}", text.Length, key.Length));
                return "";
            }

            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                newText.Append(((char)(text[i] ^ key[i])).ToString());
            }
            return newText.ToString();
        }

        private void buttonRandomDecrypt_Click(object sender, EventArgs e)
        { 

            string key;

            //if (textBoxResult.Text == "")
            //{
            //    if (textBoxResultBinary.Text == "")
            //    {
            //        MessageBox.Show("Введите текст в бинарном либо обычном виде");
            //        return;
            //    }
            //    else
            //    {
            //        encryptedText = BinaryToOrdinal(textBoxResultBinary.Text);
            //        textBoxResult.Text = encryptedText;
            //    }
            //}
            //else
            //{
            //    encryptedText = textBoxResult.Text;
            //    textBoxResultBinary.Text = OrdinalToBinary(textBoxResult.Text);
            //}

            if (textBoxRandomKey.Text == "")
            {
                MessageBox.Show("Не сформирована случайная последовательность для расшифровки");
                return;
            }
            else
            {
                key = textBoxRandomKey.Text;
            }


            decryptedText = XOR_Encrypt_2(encryptedText, key);

            textBoxDecrypted.Text = BinaryToOrdinal(OrdinalToBinary(decryptedText));

            textBoxDecryptedBinary.Text = OrdinalToBinary(decryptedText);


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (textBoxResult.Text == "")
            {
                MessageBox.Show("Введите текст");
                return;
            }
            textBoxResultBinary.Text = OrdinalToBinary(textBoxResult.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxResultBinary.Text == "")
            {
                MessageBox.Show("Введите двоичный код");
                return;
            }
            textBoxResult.Text = BinaryToOrdinal(textBoxResultBinary.Text);
        }

        private void buttonKeyDecrypt_Click(object sender, EventArgs e)
        {
            string key;

            //if (textBoxResult.Text == "")
            //{
            //    if (textBoxResultBinary.Text == "")
            //    {
            //        MessageBox.Show("Введите текст в бинарном либо обычном виде");
            //        return;
            //    }
            //    else
            //    {
            //        encryptedText = BinaryToOrdinal(textBoxResultBinary.Text);
            //        textBoxResult.Text = encryptedText;
            //    }
            //}
            //else
            //{
            //    encryptedText = textBoxResult.Text;
            //    textBoxResultBinary.Text = OrdinalToBinary(textBoxResult.Text);
            //}

            if (textBoxKey.Text == "")
            {
                if (textBoxKeyBinary.Text == "")
                {
                    MessageBox.Show("Введите ключ в бинарном либо обычном виде");
                    return;
                }
                else
                {
                    key = BinaryToOrdinal(textBoxKeyBinary.Text);
                    textBoxKey.Text = key;
                }
            }
            else
            {
                key = textBoxKey.Text;
                textBoxKeyBinary.Text = OrdinalToBinary(key);
            }

            textBoxInfo.AppendText(String.Format("Расшифровываем текст с помощью пользовательского ключа\n", key) );

            if (encryptedText.Length < key.Length)
            {
                MessageBox.Show(String.Format("Ошибка! Длина ключа ({0}) превышает длину текста ({1})", key.Length, encryptedText.Length));
                return;
            }

            if (encryptedText.Length != key.Length)
            {
                textBoxInfo.AppendText(String.Format("Ключ имеет длину {0}, он будет дополнен до длины текста ({1})\n", key.Length, encryptedText.Length) );
                if (key.Length != 0)
                {
                    key = CreateKey(key, encryptedText.Length);
                    textBoxKey.Text = key;
                }

            }

            decryptedText = XOR_Encrypt_2(encryptedText, key);

            textBoxDecrypted.Text = BinaryToOrdinal(OrdinalToBinary(decryptedText));
            textBoxDecryptedBinary.Text = OrdinalToBinary(decryptedText);

        }

        private BigInteger XOR_Decrypt(BigInteger text, BigInteger key)
        {
            return text ^ key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInputText.Text = string.Empty;
        }

        private void textBoxKeyBinary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
