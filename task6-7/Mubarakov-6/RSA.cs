using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mubarakov_4
{
    public class RSA
    {
        static List<char> alphabet = new List<char>(" abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ!@#$%^&*()_+=-0987654321'`~{}[]|></.,\\\"№;:?".ToCharArray());
        //static List<char> alphabet = new List<char>(" abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890".ToCharArray());

        static Encoding currentEncoding = Encoding.Unicode;

        static Random rnd = new Random();

        static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public static BigInteger PollardRhoAlgorithm_IshmuhametovImplementation(BigInteger N)
        {
            // Реализация по псевдокоду из монографии Ишмухаметова, 2011, с. 64.
            BigInteger x = randomBigIntLessOrEqualLength(N.ToByteArray().Length) - 2;

            BigInteger y = 1;
            BigInteger i = 0;
            BigInteger stage = 2;

            while (greatestCommonDivisor(N, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage *= 2;
                }
                x = (x * x + 1) % N;
                i++;
            }
            return greatestCommonDivisor(N, BigInteger.Abs(x - y));
        }


        /// <summary>
        /// Тест простоты Миллера-Рабина
        /// </summary>
        /// <param name="p">проверяемое число</param>
        /// <param name="n">заранее установленное количество раундов</param>
        /// <returns></returns>
        static public bool primeTestMillerRabin(BigInteger p)
        {
            if (p < 2 || p % 2 == 0)
                return p == 2;

            int n = (int)Math.Ceiling(BigInteger.Log10(p) / BigInteger.Log10(2)); //  Рекомендуется брать количество раундов (свидетелей простоты) равное величине логарифма n по основанию 2

            //Console.WriteLine("Программа пройдет {0} раундов", n, Color.LightCyan);

            // представим p − 1 в виде (2^s)·d (d-нечетно), производим последовательные деления p - 1 на 2
            BigInteger d = p - 1;

            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }


            for (int i = 0; i < n; i++)
            {
                // выберем случайное целое число a в отрезке [2, p − 1]
                BigInteger a;
                do
                {
                    a = randomBigIntLessOrEqualLength(p.ToByteArray().Length);
                    //Console.WriteLine("Попытка подобрать а: {0}", a, Color.Plum);
                }
                while (a < 2 || a > p - 1);

                //Console.WriteLine("a = {0}", a, Color.Pink);

                BigInteger x = fastModPow(a, d, p); // x = a^d (mod p)


                if (x == 1 || x == p - 1)
                    continue; // + свидетель простоты по первому условию (a в степени d = плюс/минус мод p)


                for (int r = 1; r < s; r++)
                {
                    x = fastModPow(x, 2, p); // x = a^(2^r*d) (mod p)

                    if (x == 1)
                        return false;
                    //В модульной арифметике, если n — простое число, то квадратный корень равен только 1(либо + 1, либо –1).Если n — составной объект, то квадратный корень — +1 или(-1), но могут быть и другие корни. Это называют испытанием простоты чисел квадратным корнем.Обратите внимание, что в модульной арифметике –1 означает

                    if (x == p - 1)
                        break; // + свидетель простоты по второму условию a^(2^r*d) = -1 (mod p)
                }

                if (x != p - 1)
                    return false; // + св. непростоты по 2 условию
            }

            return true;

        }

        public static BigInteger generatePrimeNumber(int numOfBits = 512)
        {
            while (true)
            {
                BigInteger n = randomBigIntOfThisLength(numOfBits);
                if (primeTestMillerRabin(n))
                    return n;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">Количество бит</param>
        /// <returns></returns>
        public static BigInteger randomBigIntLessOrEqualLength(int length = 512)
        {
            // Округляю до ближайшей 8

            int tmp = length;
            if ((tmp = length % 8) != 0)
                length += length > -1 ? (8 - tmp) : -tmp;

            byte[] bytes = new byte[length / 8];
            rng.GetBytes(bytes);

            return new BigInteger(bytes);
        }

        public static BigInteger randomBigIntOfThisLength(int length = 512)
        {
            // Округляю до ближайшей 8

            int tmp = length;
            if ((tmp = length % 8) != 0)
                length += length > -1 ? (8 - tmp) : -tmp;

            byte[] bytes = new byte[length / 8];
            rng.GetBytes(bytes);

            //var major_byte = bytes[bytes.Length - 1];
            //BitArray bits = new BitArray(major_byte);
            //bits[7] = true;
            //major_byte = bits.CopyTo(major_byte,0);

            return new BigInteger(bytes);
        }

        public static bool mutuallyPrimeNumbers(BigInteger a, BigInteger b)
        {
            return (greatestCommonDivisor(a, b) == 1);
        }

        public static BigInteger greatestCommonDivisor(BigInteger a, BigInteger b)
        {
            if (b > a)
                swap(ref a, ref b);

            while (b != 0)
                b = a % (a = b);
            return BigInteger.Abs(a);
            //return extendedEuclideanAlgorithm(a, b).Item3;
        }



        /// <summary>
        /// Расширенный алгоритм Евклида
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a - НОД, x0, y0 - коэффициенты Безу при a и b соответственно </returns>
        public static (BigInteger, BigInteger, BigInteger) extendedEuclideanAlgorithm(BigInteger a, BigInteger b)
        {
            if (b > a)
            {
                swap(ref a, ref b);
            }

            BigInteger a0 = a, b0 = b, x0 = 1, y0 = 0, x1 = 0, y1 = 1;

            while (b != 0)
            {
                BigInteger remainder = 0;
                BigInteger quotient = BigInteger.DivRem(a, b, out remainder);
                //https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger.divide?view=netcore-3.1

                a = b;
                b = remainder;

                var x0_buff = x0;
                x0 = x1;
                x1 = x0_buff - quotient * x1;


                var y0_buff = y0;
                y0 = y1;
                y1 = y0_buff - quotient * y1;
            }

            return (x0, y0, a);
        }

        public static void swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        //public static (Tuple<BigInteger, BigInteger>, Tuple<BigInteger, BigInteger>) generateKey(BigInteger p, BigInteger q)
        //{
        //    if (primalityTest(p) && primalityTest(q))
        //    {
        //        BigInteger n = p * q;

        //        BigInteger fi = (p - 1) * (q - 1);


        //        int lengthOfFiInBits = fi.GetByteCount();

        //        //int temp = (int)8 / lengthOfFiInBits;

        //        //lengthOfFiInBits += 8 - temp * lengthOfFiInBits;

        //        //lengthOfFiInBits = (int) Math.Ceiling((decimal)lengthOfFiInBits);


        //        //Console.WriteLine(lengthOfFiInBits, Color.Red);

        //        BigInteger e = randomBigInt(lengthOfFiInBits);

        //        while (!mutualSimplicityOfNumbers(e, fi) || e >= fi || e <= 1)
        //        {
        //            // e должно быть короче fi ->
        //            e = randomBigInt(lengthOfFiInBits);
        //            //Console.WriteLine(e, Color.LightPink);
        //        }

        //        BigInteger d = generateD(e, fi);

        //        //Console.WriteLine("fi = {0}, e = {1}, d = {2}", fi, e, d, Color.Fuchsia);

        //        var openKey = Tuple.Create(n, e);
        //        var closedKey = Tuple.Create(n, d);

        //        return (openKey, closedKey);

        //    }
        //    else
        //        throw new NotPrimalyArgumentException();
        //}

        public static (Tuple<BigInteger, BigInteger>, Tuple<BigInteger, BigInteger>) generateKey(int numOfBits = 512)
        {
            BigInteger p = generatePrimeNumber(numOfBits);
            BigInteger q = generatePrimeNumber(numOfBits);

            BigInteger n = p * q;

            BigInteger fi = (p - 1) * (q - 1);

            int lengthOfFiInBits = fi.ToByteArray().Length;

            BigInteger e = randomBigIntLessOrEqualLength(lengthOfFiInBits);

            while (!mutuallyPrimeNumbers(e, fi) || e >= fi || e <= 1)
            {
                e = randomBigIntLessOrEqualLength(lengthOfFiInBits);
            }

            BigInteger d = generateD(e, fi);

            var openKey = Tuple.Create(n, e);
            var closedKey = Tuple.Create(n, d);

            return (openKey, closedKey);

        }

        public static (Tuple<BigInteger, BigInteger>, Tuple<BigInteger, BigInteger>) generateKey(BigInteger p, BigInteger q)
        {

            BigInteger n = p * q;

            BigInteger fi = (p - 1) * (q - 1);

            int lengthOfFiInBits = fi.ToByteArray().Length;

            BigInteger e = randomBigIntLessOrEqualLength(lengthOfFiInBits);

            while (!mutuallyPrimeNumbers(e, fi) || e >= fi || e <= 1)
            {
                e = randomBigIntLessOrEqualLength(lengthOfFiInBits);
            }

            BigInteger d = generateD(e, fi);

            var openKey = Tuple.Create(n, e);
            var closedKey = Tuple.Create(n, d);

            return (openKey, closedKey);

        }


        public static BigInteger generateD(BigInteger e, BigInteger fi)
        {
            BigInteger d = extendedEuclideanAlgorithm(fi, e).Item2;

            while (d < 1) { d += fi; }

            while (d > fi) { d -= fi; }

            return d;

        }

        public static BigInteger Encrypt(BigInteger message, Tuple<BigInteger, BigInteger> openKey)
        {
            var (n, e) = openKey;
            return fastModPow(message, e, n);
            //return BigInteger.ModPow(message, e, n);
        }

        public static byte[] Encrypt(byte[] message, Tuple<BigInteger, BigInteger> openKey)
        {
            BigInteger messBI = new BigInteger(message);
            return Encrypt(messBI, openKey).ToByteArray();
        }

        //public static int[] Encrypt(int[] message, Tuple<BigInteger, BigInteger> openKey)
        //{
        //    int[] result = new int[message.Length];
        //    for (int i = 0; i < message.Length; i++)
        //    {
        //        result[i] = message[i]
        //    }
        //    return Encrypt(messBI, openKey).ToByteArray();
        //}



        public static string Encrypt(string message, Tuple<BigInteger, BigInteger> openKey)
        {
            // Нихера не работает
            //byte[] text = currentEncoding.GetBytes(message);
            //BigInteger messBI = new BigInteger(text);
            //var temp = Encrypt(messBI, openKey).ToByteArray();
            //return currentEncoding.GetString(temp);

            StringBuilder resultText = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int index = alphabet.IndexOf(message[i]);
                if (index == -1)
                {
                    MessageBox.Show(String.Format("Вы ввели символ не из алфавита. Этот символ: '{0}'", message[i]));
                    return string.Empty;
                }
                var (n, e) = openKey;
                BigInteger code = (fastModPow(index, e, n));
                resultText.Append(code.ToString());
                resultText.Append(" ");
            }
            return resultText.ToString();
        }


        public static BigInteger Encrypt(char message, Tuple<BigInteger, BigInteger> openKey)
        {
            return Encrypt((int)message, openKey);
        }

        public static BigInteger fastPow(BigInteger a, BigInteger b)
        {
            /// Схема "справа налево" (от младших бит к старшим) - см. лекции Еникеева стр. 29
            BigInteger result = 1;
            BigInteger ai = a;
            //первый бит - самый правый
            while (b > 0)
            {
                if ((b & 1) == 1)
                {
                    result *= ai;
                }
                ai *= ai;
                b >>= 1; // тоже самое что b = b << 1; Сдвиг вправо (от младшего бита к старшему)
            }

            return result;
        }

        public static BigInteger fastModPow(BigInteger a, BigInteger b, BigInteger modulus)
        {
            BigInteger result = 1;
            BigInteger ai = a;
            //первый бит - самый правый
            while (b > 0)
            {
                if ((b & 1) == 1)
                {
                    result = result * ai % modulus;
                }
                ai = ai * ai % modulus;
                b >>= 1; // тоже самое что b = b >> 1;
            }
            return result;
        }

        public static BigInteger Decrypt(BigInteger encryptedMessage, Tuple<BigInteger, BigInteger> closedKey)
        {
            var (n, d) = closedKey;
            //return fastModPow(encryptedMessage, d, n);
            return fastPow(encryptedMessage, d) % n;
            //return BigInteger.ModPow(encryptedMessage, d, n);
        }

        public static byte[] Decrypt(byte[] encryptedMessage, Tuple<BigInteger, BigInteger> closedKey)
        {
            BigInteger messBI = new BigInteger(encryptedMessage);
            return Decrypt(messBI, closedKey).ToByteArray();
        }
        public static string Decrypt(string encryptedMessage, Tuple<BigInteger, BigInteger> closedKey)
        {
            //byte[] message = currentEncoding.GetBytes(encryptedMessage);
            //BigInteger messBI = new BigInteger(message);
            //return currentEncoding.GetString(Decrypt(messBI, closedKey).ToByteArray());

            string[] codes = encryptedMessage.Trim(' ').Split(' ');

            StringBuilder resultText = new StringBuilder();
            for (int i = 0; i < codes.Length; i++)
            {
                BigInteger code = BigInteger.Parse(codes[i]);
                var (n, d) = closedKey;

                var index = (fastModPow(code, d, n));
                if (index > alphabet.Count)
                    index = index % alphabet.Count;
                int i_index = (int)index;
                resultText.Append(alphabet[i_index]);
            }
            return resultText.ToString();
        }

        public static char toSymbol(BigInteger codeOfSymbol)
        {
            return (char)codeOfSymbol;
        }

        public static char toSymbol(int codeOfSymbol)
        {
            return (char)codeOfSymbol;
        }

        public static BigInteger toCode(char symbol)
        {
            return (int)symbol;
        }

        public static BigInteger stringToBigInt(string str)
        {
            return new BigInteger(currentEncoding.GetBytes(str));
        }

        public static string bigIntToString(BigInteger bigint)
        {
            return currentEncoding.GetString(bigint.ToByteArray());
        }

        public static int[] stringToIntArray(string text)
        {
            int[] result = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (int)text[i]; // код из UTF-16
            }
            return result;
        }

    }

}