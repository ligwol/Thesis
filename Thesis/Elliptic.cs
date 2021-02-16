using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thesis
{
    class Elliptic
    {
        public static int Mod(int a, int n)
        {
            if (a < 0) a = n + a % n;
            else a = a % n;
            return a;
        }
        public static int Evklid(int a1, int a2)
        {
            int q;
            int[] k = { 1, 0, a1 };
            int[] j = { 0, 1, a2 };
            int[] i = { 0, 0, 0 };
            while (j[2] != 0)
            {
                q = k[2] / j[2];
                for (int p = 0; p < 3; p++)
                {
                    i[p] = k[p] - j[p] * q;
                    k[p] = j[p];
                    j[p] = i[p];
                }
            }
            // for (int i = 0; i < 3; i++) cout << k[i] << endl;
            return k[1];
        }
        public static int[] Addition(int x1, int y1, int x2, int y2, int b, int p, int[] Point)//функция, реализующая алгоритм сложения двух точек
        {
            int alpha, ResultEvklid, Minus = 1;
            int AlphaChislitel, AlphaZnamenatel;
            int x3, y3;
            if (x1 == x2 && y1 == y2)
            {
                AlphaChislitel = 3 * x1 * x1 + b;
                AlphaZnamenatel = 2 * y1;
            }
            else
            {
                AlphaChislitel = y2 - y1; AlphaZnamenatel = x2 - x1;
            }

            int CriteriyMinusa = AlphaZnamenatel;
            if (AlphaZnamenatel < 0)
            {
                Minus = -1;
                CriteriyMinusa *= -1;
            }
            ResultEvklid = Evklid(p, CriteriyMinusa);
            alpha = Mod(AlphaChislitel * ResultEvklid * Minus, p);

            x3 = Mod(alpha * alpha - x1 - x2, p);
            y3 = Mod(alpha * (x1 - x3) - y1, p);

            Point[0] = x3; Point[1] = y3;

            return Point;
        }

        public static int[] Duplication(int n, int x1, int y1, int b, int p, int[] Mas) //функция, реализующая алгоритм умножения точки на скаляр
        {
            int[] Res = new int[2]; int[] Res1 = new int[2];
            Res[0] = x1; Res[1] = y1;
            for (int i = 1; i < n; i++)
            {
                Addition(Res[0], Res[1], x1, y1, b, p, Res1);
                Res[0] = Res1[0];
                Res[1] = Res1[1];
            }
            Mas[0] = Res1[0];
            Mas[1] = Res1[1];
            return Mas;
        }

        public static string EllipticEncryption(string text, string Alphabet, int nA, int nB, int p, int b, int c, int[] G)
        {
            List<int> XX = new List<int>();     //переменные для хранения координат точек группы Ep(b,c)
            List<int> YY = new List<int>();

            int tx, ty;
            for (int x = 0; x < p; x++)
            {
                for (int y = 0; y < p; y++)
                {
                    if (Mod(y * y, p) == Mod(x * x * x + b * x + c, p))     //составляем группу точек Ep(b,c)
                    {
                        tx = x; ty = y;
                        XX.Add(tx);//XX-х координаты точек группы E
                        YY.Add(ty);//YY-у координаты точек группы E
                    }
                }
            }

            /////////////запись всей группы точек в документ group.txt:
            string pathX = @"D:\group.txt";
            using (StreamWriter sw = new StreamWriter(pathX, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < XX.Count; i++)
                    sw.WriteLine("(" + XX[i] + ";" + YY[i] + ")");
            }

            //////выбираем Alphabet.Length (29/37) случайных чисел в массив IndexRandom:
            int[] IndexRandom = new int[Alphabet.Length];
            Random rnd = new Random();
            for (int i = 0; i < Alphabet.Length; i++)
            {
                int a = rnd.Next(0, XX.Count());
                if (!IndexRandom.Contains(a))
                {
                    IndexRandom[i] = a;
                }
                else
                    i--;
            }

            int[,] Point = new int[Alphabet.Length, 2];    //ассоциативный массив, точки из группы Ep(b,c) записаны в соответствии со случайными номерами IndexRandom
            for (int i = 0; i < Alphabet.Length; i++)
            {
                Point[i, 0] = XX[IndexRandom[i]];//выбираем из группы точки, соответствующие номерам indexRandom, в массив Point
                Point[i, 1] = YY[IndexRandom[i]];
            }

            /////////////запись точек в документ point.txt:
            string pathP = @"D:\point.txt";
            using (StreamWriter sw = new StreamWriter(pathP, false, Encoding.GetEncoding(1251)))
            {
                for (int i = 0; i < Alphabet.Length; i++)
                    sw.WriteLine(Alphabet[i] + "  " + "(" + Point[i, 0] + ";" + Point[i, 1] + ")");
            }
            ////проверка значений координат точек (не равны)
            for (int i = 0; i < Alphabet.Length; i++)
                if (Point[i, 0] == Point[i, 1])
                {
                    Point[i, 0] = Point[i + 1, 0];
                    Point[i, 1] = Point[i + 1, 1];
                }

            //преобразование двумерного массива Point в string
            string PointDop = null;
            for (int i = 0; i < Alphabet.Length; i++)
                PointDop += Point[i, 0] + " " + Point[i, 1] + " ";
            string pathDop = @"D:\Dop.txt";
            using (StreamWriter sw = new StreamWriter(pathDop, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(PointDop);
            }

            /////////генерируем открытые ключи Pa, Pb:
            int[] Pa = new int[2];
            int[] Pb = new int[2];
            Duplication(nA, G[0], G[1], b, p, Pa);
            Duplication(nB, G[0], G[1], b, p, Pb);

            /////////генерируем общий секретный ключ GenKey = na*Pb=nb*Pa:
            int[] GeneralKey1 = new int[2];
            int[] GeneralKey2 = new int[2];
            int[] GeneralKey = new int[2];
            Duplication(nA, Pb[0], Pb[1], b, p, GeneralKey1);
            Duplication(nB, Pa[0], Pa[1], b, p, GeneralKey2);
            for (int i = 0; i < 2; i++)
                if (GeneralKey1[i] == GeneralKey2[i])
                    GeneralKey[i] = GeneralKey1[i];

            int[] Cm1 = new int[2];
            int[,] Cm2 = new int[text.Length, 2];
            int[] temp = new int[2];    //каждой букве соответствует точка кривой
            int[] ENC = new int[2]; //дополнительный массив для хранения зашифрованного текста (для каждой буквы)

            Duplication(nA, G[0], G[1], b, p, Cm1); //заполнение Cm1

            ////////////заполнение Cm2:
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (text[i] == Alphabet[j])
                    {
                        temp[0] = Point[j, 0];
                        temp[1] = Point[j, 1];
                        Addition(temp[0], temp[1], GeneralKey1[0], GeneralKey1[1], b, p, ENC);
                        Cm2[i, 0] = ENC[0];
                        Cm2[i, 1] = ENC[1];
                    }
                }

            ////////////заполнение массива CM значениями Cm1 и Cm2:
            int[,] CM = new int[text.Length + 1, 2];
            CM[0, 0] = Cm1[0];
            CM[0, 1] = Cm1[1];
            for (int i = 1; i < text.Length + 1; i++)
            {
                CM[i, 0] = Cm2[i - 1, 0];
                CM[i, 1] = Cm2[i - 1, 1];
            }

            /////////////////////////преобразование двумерного массива CM в текст string:
            string EllipticRes = "";
            for (int i = 0; i < text.Length + 1; i++)
                EllipticRes += "(" + CM[i, 0] + "," + CM[i, 1] + "); ";

            return EllipticRes;
        }

        public static string EllipticDecryption(string textd, string Alphabet, int nB, int b, int p)
        {
            //удаление лишних символов из шифра
            string textd1 = textd.Replace("(", "");
            string textd2 = textd1.Replace(")", "");
            string textd3 = textd2.Replace(",", " ");
            string text = textd3.Replace(";", "");
            //заполнение массива Cm1
            string[] Cmchar = text.Split(' ');
            int[] Cm1 = new int[2];
            for (int i = 0; i < 2; i++)
                int.TryParse(Cmchar[i], out Cm1[i]);
            //заполнение массива Cm2
            int[,] Cm2 = new int[Cmchar.Length - 2, 2];
            int k = 2;
            for (int i = 0; i < (Cmchar.Length - 2) / 2; i++)     //(Cmchar.Length-2)/2 - кол-во букв в шифре
                for (int j = 0; j < 2; j++)
                {
                    int.TryParse(Cmchar[k], out Cm2[i, j]);
                    k++;
                }

            //извлечение чисел в массив PointFromFile из файла Dop.txt
            int[,] PointFromFile = new int[Alphabet.Length, 2];
            string PointFromFile1 = System.IO.File.ReadAllText(@"D:\Dop.txt");  //текст из файла
            string[] PointChar = PointFromFile1.Split(' ');
            int k1 = 0;
            for (int i = 0; i < PointChar.Length / 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    int.TryParse(PointChar[k1], out PointFromFile[i, j]);
                    k1++;
                }

            int[] desh = new int[2];
            Duplication(nB, Cm1[0], Cm1[1], b, p, desh);  //умножение первой точки в паре на секретный ключ: nb*Cm1
            int[] DEC = new int[2];

            int[,] ShifrNumbers = new int[(Cmchar.Length - 2) / 2, 2];
            for (int i = 0; i < (Cmchar.Length - 2) / 2; i++)
            {
                Addition(Cm2[i, 0], Cm2[i, 1], desh[0], -desh[1], b, p, DEC);   //вычитание результата из второй точки: Cm2-nb*Cm1
                ShifrNumbers[i, 0] = DEC[0];
                ShifrNumbers[i, 1] = DEC[1];
            }

            char[] Deshifr = new char[(Cmchar.Length - 2) / 2];

            for (int t = 0; t < (Cmchar.Length - 2) / 2; t++)
                for (int i = 0; i < Alphabet.Length; i++)
                    for (int j = 0; j < 2; j++)
                    {
                        //                       if (ShifrNumbers[t,j] == PointFromFile[i,j])
                        if (ShifrNumbers[t, 0] == PointFromFile[i, 0] && ShifrNumbers[t, 1] == PointFromFile[i, 1])
                            Deshifr[t] = Alphabet[i];
                    }

            //         string EllipticResDecrypt = string.Join("", ShifrNumbers[0,0], '\r', '\n', ShifrNumbers[0,1],'\r','\n', ShifrNumbers[1,0], '\r', '\n', ShifrNumbers[1, 1], '\r', '\n', ShifrNumbers[2, 0], '\r', '\n', ShifrNumbers[2,1], '\r', '\n', ShifrNumbers[3, 0], '\r', '\n', ShifrNumbers[3, 1], '\r', '\n', ShifrNumbers[4, 0], '\r', '\n', ShifrNumbers[4, 1]);
            string EllipticResDecrypt = string.Join("", Deshifr);
            return EllipticResDecrypt;
        }
        /*,                       
                           '\r', '\n', MatrixDecryptReverse[0, 0], MatrixDecryptReverse[0, 1],
                           '\r', '\n', MatrixDecryptReverse[0, 2], MatrixDecryptReverse[0, 3],
                           '\r', '\n', MatrixDecryptReverse[0, 4], MatrixDecryptReverse[0, 5],
                           '\r', '\n', MatrixDecryptReverse[1, 0], MatrixDecryptReverse[1, 1],
                           '\r', '\n', MatrixDecryptReverse[1, 2], MatrixDecryptReverse[1, 3],
                           '\r', '\n', MatrixDecryptReverse[1, 4], MatrixDecryptReverse[1, 5]*/
        /*'\r', '\n', MatrixDecryptReverse[0, 0], MatrixDecryptReverse[1, 0],
                           '\r', '\n', MatrixDecryptReverse[0, 1], MatrixDecryptReverse[1, 1],
                           '\r', '\n', MatrixDecryptReverse[0, 2], MatrixDecryptReverse[1, 2],
                           '\r', '\n', MatrixDecryptReverse[0, 3], MatrixDecryptReverse[1, 3],
                           '\r', '\n', MatrixDecryptReverse[0, 4], MatrixDecryptReverse[1, 4],
                           '\r', '\n', MatrixDecryptReverse[0, 5], MatrixDecryptReverse[1, 5]
                            
                           '\r', '\n', MatrixDecrypt[0, 0], MatrixDecrypt[0, 1],
                           '\r', '\n', MatrixDecrypt[0, 2], MatrixDecrypt[0, 3],
                           '\r', '\n', MatrixDecrypt[0, 4], MatrixDecrypt[0, 5],
                           '\r', '\n', MatrixDecrypt[1, 0], MatrixDecrypt[1, 1],
                           '\r', '\n', MatrixDecrypt[1, 2], MatrixDecrypt[1, 3],
                           '\r', '\n', MatrixDecrypt[1, 4], MatrixDecrypt[1, 5],
         
         */
        //         string result = string.Join("", MatrixEncryptReverse[0,0], MatrixEncryptReverse[1, 0], MatrixEncryptReverse[0, 1], MatrixEncryptReverse[1, 1], MatrixEncryptReverse[0, 2], MatrixEncryptReverse[1, 2], MatrixEncryptReverse[0, 3], MatrixEncryptReverse[1, 3], MatrixEncryptReverse[0, 4], MatrixEncryptReverse[1, 4], MatrixEncryptReverse[0, 5], MatrixEncryptReverse[1, 5]);
        //         textbox_result.Text = result;

        //          string result = t.ToString();
        //          OutputTextBox.Text = result.ToString();

        //          string result = new string(t);

        //          string result = string.Join("", KeyNumbers);   
        //          OutputTextBox.Text = result;
        //          return KeyNumbers.ToString();
    }

}

