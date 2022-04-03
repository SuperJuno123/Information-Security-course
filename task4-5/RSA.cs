using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;

namespace Encryption
{
    public class RSA
    {
        static Random rnd = new Random();

        static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        /// <summary>
        /// Тест простоты Миллера-Рабина
        /// </summary>
        /// <param name="p">проверяемое число</param>
        /// <param name="n">заранее установленное количество раундов</param>
        /// <returns></returns>
        static public bool primalityTest(BigInteger p)
        {
            if (p < 2 || p % 2 == 0)
                return p == 2;

            int n = (int)Math.Ceiling(BigInteger.Log(p)); //  Рекомендуется брать количество раундов (свидетелей простоты) равное величине логарифма n по основанию 2

            //Console.WriteLine("Программа пройдет {0} раундов", n, Color.LightCyan);

            // представим p − 1 в виде (2^s)·d (d-нечетно), производим последовательные деления p - 1 на 2
            BigInteger d = p - 1;

            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            //Console.WriteLine("{0}=2^{1}*{2}", p - 1, s, d, Color.PeachPuff);

            for (int i = 0; i < n; i++)
            {
                // выберем случайное целое число a в отрезке [2, p − 1]
                BigInteger a;
                do
                {
                    a = randomBigInt(p.GetByteCount());
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

                    if (x == p - 1)
                        break; // + свидетель простоты по второму условию a^(2^r*d) = -1 (mod p)
                }

                if (x != p - 1)
                    return false; // + св. непростоты по 2 условию
            }

            return true;

        }

        public static BigInteger generateSimpleNum(int numOfBits = 512)
        {
            while (true)
            {
                BigInteger n = randomBigInt(numOfBits);
                if (primalityTest(n))
                    return n;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">Количество бит</param>
        /// <returns></returns>
        public static BigInteger randomBigInt(int length = 512)
        {
            // Округляю до ближайшей 8

            int tmp = length;
            if ((tmp = length % 8) != 0)
                length += length > -1 ? (8 - tmp) : -tmp;

            byte[] bytes = new byte[length / 8];
            rng.GetBytes(bytes);

            return new BigInteger(bytes);
        }

        public static bool mutualSimplicityOfNumbers(BigInteger a, BigInteger b)
        {
            return (greatestCommonDivisor(a, b) == 1);
        }

        public static BigInteger greatestCommonDivisor(BigInteger a, BigInteger b)
        {
            return extendedEuclideanAlgorithm(a, b).Item3;
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
            BigInteger p = generateSimpleNum(numOfBits);
            BigInteger q = generateSimpleNum(numOfBits);

            BigInteger n = p * q;

            BigInteger fi = (p - 1) * (q - 1);

            int lengthOfFiInBits = fi.GetByteCount();

            BigInteger e = randomBigInt(lengthOfFiInBits);

            while (!mutualSimplicityOfNumbers(e, fi) || e >= fi || e <= 1)
            {
                e = randomBigInt(lengthOfFiInBits);
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
            //return fastPow(message, e) % n;
            //return BigInteger.ModPow(message, e, n);
        }
        public static byte[] Encrypt(byte[] message, Tuple<BigInteger, BigInteger> openKey)
        {
            BigInteger messBI = new BigInteger(message);
            return Encrypt(messBI, openKey).ToByteArray();
        }

        public static BigInteger Encrypt(char message, Tuple<BigInteger, BigInteger> openKey)
        {
            return Encrypt((int)message, openKey);
        }

        public static BigInteger fastPow(BigInteger a, BigInteger b)
        {
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
                b >>= 1; // тоже самое что b = b >> 1;
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
            return fastModPow(encryptedMessage, d, n);
            //return fastPow(encryptedMessage, d) % n;
            //return BigInteger.ModPow(encryptedMessage, d, n);
        }

        public static byte[] Decrypt(byte[] encryptedMessage, Tuple<BigInteger, BigInteger> closedKey)
        {
            BigInteger messBI = new BigInteger(encryptedMessage);
            return Decrypt(messBI, closedKey).ToByteArray();
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

        public void eulerFunc() { }

    }

    public class DH
    {
        static Random rnd = new Random();

        static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public static BigInteger randomBigInt(int length = 1024)
        {
            // Округляю до ближайшей 8

            int tmp = length;
            if ((tmp = length % 8) != 0)
                length += length > -1 ? (8 - tmp) : -tmp;

            byte[] bytes = new byte[length / 8];
            bytes[length-1] = 1;
            rng.GetBytes(bytes);

            return new BigInteger(bytes);
        }

        public static (BigInteger, int) toBob(int lengthInBits = 1024)
        {
            BigInteger p = createPrimeNumber(lengthInBits);

            int g = findGenerator(p, lengthInBits);

            return (p, g);
        }

        public static BigInteger evaluateSecretKeyAlice(int length, int g, BigInteger p)
        {
            BigInteger a = randomBigInt(length);
            while (a <= 1 || a >= p)
            {
                a = randomBigInt(length);
            }

            BigInteger x = fastModPow(g, a, p);
            return x;
        }

        
        public static BigInteger evaluateCommontKeyAlice(BigInteger y, BigInteger a, BigInteger p)
        {
            BigInteger k = fastModPow(y, a, p);
            return k;
        }

        // Удалить
        public static BigInteger evaluateCommontKeyBob(BigInteger x, BigInteger b, BigInteger p)
        {
            BigInteger k = fastModPow(x, b, p);
            return k;
        }


        //Убрать лишний
        public static BigInteger evaluateSecretKeyBob(int length, int g, BigInteger p)
        {
            BigInteger b = randomBigInt(length);
            while (b <= -1 || b >= p)
            {
                b = randomBigInt(length);
            }
            BigInteger y = fastModPow(g, b, p);
            return y;
        }

        public static int findGenerator(BigInteger p, int length)
        {
            List<BigInteger> fact = new List<BigInteger>();
            BigInteger phi = p - 1;
            BigInteger n = phi;
            int i = 2;
            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    fact.Add(i);
                    while (n % i == 0)
                        n /= i;
                }
                i += 1;
                if (n > 1)
                    fact.Add(n);
                for (int res = 2; res < p + 1; p++)
                {
                    bool ok = true;
                    i = 0;
                    while (i < fact.Count && ok)
                    {
                        ok = fastModPow(res, (int)(phi / fact[i]), p) != 1;

                        i++;
                    }
                    if (ok)
                        return res;
                }
            }
            return -1;
        }

        public static int evalOrder(BigInteger g, BigInteger p)
        {
            int n = 1;
            while (fastModPow(g, n, p) != 1)
            {
                n++;
            }
            return n;
        }

        static public bool primeTest(BigInteger p)
        {
            if (p < 2 || p % 2 == 0)
                return p == 2;

            int n = (int)Math.Ceiling(BigInteger.Log(p)); //  Рекомендуется брать количество раундов (свидетелей простоты) равное величине логарифма n по основанию 2

            //Console.WriteLine("Программа пройдет {0} раундов", n, Color.LightCyan);

            // представим p − 1 в виде (2^s)·d (d-нечетно), производим последовательные деления p - 1 на 2
            BigInteger d = p - 1;

            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            //Console.WriteLine("{0}=2^{1}*{2}", p - 1, s, d, Color.PeachPuff);

            for (int i = 0; i < n; i++)
            {
                // выберем случайное целое число a в отрезке [2, p − 1]
                BigInteger a;
                do
                {
                    a = randomBigInt(p.GetByteCount());
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

                    if (x == p - 1)
                        break; // + свидетель простоты по второму условию a^(2^r*d) = -1 (mod p)
                }

                if (x != p - 1)
                    return false; // + св. непростоты по 2 условию
            }

            return true;

        }

        public static BigInteger createPrimeNumber(int numOfBits = 512)
        {
            while (true)
            {
                BigInteger n = randomBigInt(numOfBits);
                if (primeTest(n))
                    return n;
            }
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

        public int length(BigInteger a)
        {
            return a.GetByteCount();
        }

        public static BigInteger fastPow(BigInteger a, BigInteger b)
        {
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
                b >>= 1; // тоже самое что b = b >> 1;
            }

            return result;
        }
    }

    public class NotPrimalyArgumentException : Exception
    {
        public NotPrimalyArgumentException()
        {

        }
    }

}
