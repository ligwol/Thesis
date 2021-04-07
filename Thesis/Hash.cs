using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace Thesis
{
    class Hash
    {
        public static uint Mod(uint n, uint nn)
        {
            uint n1;
            if (n >= 0)
            {
                n1 = n % nn;
            }
            else
            {
                n1 = (n % nn) + nn;
            }
            return n1;
        }
        public static string makingHash(string original)
        {
            //Преобразование исходного текста в числа из алфавита
            uint[] originalNumbers = new uint[original.Length];
            /*for (int i = 0; i < original.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (original[i] == alphabet[j])
                    {
                        originalNumbers[i] = (uint)j;
                    }
                }
            }*/
            for (int i=0; i<original.Length; i++)
            {
                originalNumbers[i] = (uint)original[i];
            }


            //Добавление чисел для полноты блока в 16 байт
            int indexNumbers = original.Length % 16; //количество символов в тексте
            int missingNumbers = 16 - indexNumbers; //количество недостающих символов в тексте
            int blockNumbers = (original.Length / 16) + 1; //количество блоков по 16
            int sizeNumbers = 16 * blockNumbers; //размер будущего масива с текстом, который надо дополнить
            uint[] filledNumbers = new uint[sizeNumbers];

            for (int i = 0; i < original.Length; i++)   
            {
                filledNumbers[i] = originalNumbers[i];
            }
            filledNumbers[original.Length] = 0x1;
            for (int i = original.Length + 1; i < sizeNumbers; i++)     // заполнить массив лишними символами
            {
                filledNumbers[i] = 0x0;
            }

            //Разбиение блоков на 16 частей
            uint[,] mNumbers = new uint[blockNumbers, 16];
            uint[,] M = new uint[16,32];
            int co = 0;
            
            for(int i = 0; i<blockNumbers; i++) //Разделить массив на блоки по 512бит
            {
               for(int j = 0; j<16; j++)
                {
                    mNumbers[i, j] = filledNumbers[co];
                    co++;
                    if (co > sizeNumbers) break;
                }
            }

            uint[,] wNumbers = new uint[blockNumbers, 80];
            for (uint i = 0; i < blockNumbers; i++) //Разделить массив на блоки по 512бит
            {
                for (uint j = 0; j < 16; j++)
                {
                    wNumbers[i,j] = mNumbers[i,j];
                }
            }
            for (uint i = 0; i < blockNumbers; i++) //Дополнить еще 80 подблоков по формуле
            {
                for (uint j = 16; j < 80; j++)
                {
                    wNumbers[i, j] = (wNumbers[i, j - 3] ^ wNumbers[i, j - 8] ^ wNumbers[i, j - 16])<<1;
                }
            }

            //инициализировать константы
            uint k1 = 0x5A827999;
            uint k2 = 0x6ED9EBA1;
            uint k3 = 0x8F1BBCDC;
            uint k4 = 0xCA62C1D6;
            uint A = 0x67452301;
            uint B = 0xE1CDAB89;
            uint C = 0x98BADCFE;
            uint D = 0x10325476;
            uint E = 0xC3D2E1F0;
            uint a = A;
            uint b = B;
            uint c = C;
            uint d = D;
            uint e = E;
            uint[] h = new uint[20];


            for (uint i = 0; i < blockNumbers; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        BigInteger temp = ((a << 5) + ((b & c) | (b & d)) + e + wNumbers[i,j]) + k1;
                        e = d;
                        d = c;
                        c = (b << 3);
                        a = (uint)temp;
                    }
                }
            }
            h[0] = Mod(Mod(A, 256) + Mod(a, 256), 256);
            h[1] = Mod(Mod(B, 256) + Mod(b, 256), 256);
            h[2] = Mod(Mod(C, 256) + Mod(c, 256), 256);
            h[3] = Mod(Mod(D, 256) + Mod(d, 256), 256);
            h[4] = Mod(Mod(E, 256) + Mod(e, 256), 256);
                        
            for (uint i = 0; i < blockNumbers; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    for (int k = 20; k < 40; k++)
                    {
                        BigInteger temp = ((a << 5) + (b^c^d) + e + wNumbers[i, j]) + k2;
                        e = d;
                        d = c;
                        c = (b << 3);
                        a = (uint)temp;
                    }
                }
            }

            h[5] = Mod(Mod(A, 256) + Mod(a, 256), 256);
            h[6] = Mod(Mod(B, 256) + Mod(b, 256), 256);
            h[7] = Mod(Mod(C, 256) + Mod(c, 256), 256);
            h[8] = Mod(Mod(D, 256) + Mod(d, 256), 256);
            h[9] = Mod(Mod(E, 256) + Mod(e, 256), 256);

            for (uint i = 0; i < blockNumbers; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    for (int k = 40; k < 60; k++)
                    {
                        BigInteger temp = ((a << 5) + ((b&c) | (b & d) | (c & d)) + e + wNumbers[i, j]) + k3;
                        e = d;
                        d = c;
                        c = (b << 3);
                        a = (uint)temp;
                    }
                }
            }

            h[10] = Mod(Mod(A, 256) + Mod(a, 256), 256);
            h[11] = Mod(Mod(B, 256) + Mod(b, 256), 256);
            h[12] = Mod(Mod(C, 256) + Mod(c, 256), 256);
            h[13] = Mod(Mod(D, 256) + Mod(d, 256), 256);
            h[14] = Mod(Mod(E, 256) + Mod(e, 256), 256);

            for (uint i = 0; i < blockNumbers; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    for (int k = 60; k < 80; k++)
                    {
                        BigInteger temp = ((a << 5) + (b ^ c ^ d) + e + wNumbers[i, j]) + k4;
                        e = d;
                        d = c;
                        c = (b << 3);
                        a = (uint)temp;
                    }
                }
            }

            h[15] = Mod(Mod(A, 256) + Mod(a, 256), 256);
            h[16] = Mod(Mod(B, 256) + Mod(b, 256), 256);
            h[17] = Mod(Mod(C, 256) + Mod(c, 256), 256);
            h[18] = Mod(Mod(D, 256) + Mod(d, 256), 256);
            h[19] = Mod(Mod(E, 256) + Mod(e, 256), 256);
            //
            //Вывод двумерного массива с числами в текстовый файл
            //StreamWriter sw = new StreamWriter("d:\\array.txt");
            //for (int i = 0; i < blockNumbers; i++)
            //{
            //    for (int j = 0; j < 80; j++)
            //    {
            //        sw.Write(wNumbers[i, j] + "\t");
            //    }
            //    sw.WriteLine();
            //}
            //sw.Close();


            //StringBuilder hex = new StringBuilder(h.Length * 2);
            //foreach (uint i in h)
            //    hex.AppendFormat("{0:x2}", i);

            string hex="";
            for (int i = 0; i < h.Length; i++)
            {
                string tp = h[i].ToString("x8");
                hex += tp;
            }

            /*string hex = "";
            for (int i = 1; i < 8; i++)
            {
                hex += hexLong[8 * i - 1] + hexLong[8 * i];
            }*/

            hex = hex.Replace("00", "");

            string result = string.Join("", "0x" + hex);
            return result;//sizeNumbers.ToString();
        }
    }
}
