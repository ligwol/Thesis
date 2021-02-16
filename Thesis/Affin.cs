using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesis
{
    class Affin
    {
        public static int Mod(int n, int nn)
        {
            int n1;
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
            //k[1] - HOD(48,11)
            //k[1] - 8^(-1)mod27 получаем v=-10, для результата необх. -10mod27
            return k[1];
        }

        public static string Encryption_Affine(string OriginalText, string Alphabet, int[] A, int[] S)
        {
            int[] t = new int[3];
            int t1 = 0, t2 = 0, t3 = 0;

            //НЕправильно добавляются лишние символы (вообще не добавляются)
            int TextLenght = 0;

            
            if (OriginalText.Length % 3 == 2) { TextLenght = OriginalText.Length + 1; }
            else
            {
                if (OriginalText.Length % 3 == 1) { TextLenght = OriginalText.Length + 2; }
                else TextLenght = OriginalText.Length;
            }
            char[] Text = new char[TextLenght];

            if (OriginalText.Length % 3 == 0)
            {
                for (int i = 0; i < OriginalText.Length; i++) Text[i] = OriginalText[i];
            }
            else
            {
                if (OriginalText.Length % 3 == 1)
                {
                    for (int i = 0; i < OriginalText.Length; i++)
                    {
                        Text[i] = OriginalText[i];
                    }
                    Text[Text.Length - 2] = '.';
                    Text[Text.Length - 1] = ',';
                }
                else
                {
                    if (OriginalText.Length % 3 == 2)
                    {
                        for (int i = 0; i < OriginalText.Length; i++)
                        {
                            Text[i] = OriginalText[i];
                        }
                        Text[Text.Length - 2] = '.';
                    }
                }
            }

            char[] Encrypted_Affine = new char[TextLenght];
            for (int i = 0; i < TextLenght; i += 3)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (Text[i] == Alphabet[j]) { t[0] = j; }
                    if (Text[i + 1] == Alphabet[j]) { t[1] = j; }
                    if (Text[i + 2] == Alphabet[j]) { t[2] = j; }
                }
                Encrypted_Affine[i] = Alphabet[Mod(A[0] * t[0] + A[1] * t[1] + A[2] * t[2], Alphabet.Length)];
                Encrypted_Affine[i + 1] = Alphabet[Mod(A[3] * t[0] + A[4] * t[1] + A[5] * t[2], Alphabet.Length)];
                Encrypted_Affine[i + 2] = Alphabet[Mod(A[6] * t[0] + A[7] * t[1] + A[8] * t[2], Alphabet.Length)];
            }

            //string result = string.Join("", Text);
            string result = string.Join("", Encrypted_Affine);
            return result;
        }

        public static string Decryption_Affine(string Text, string Alphabet, int[] A, int[] S)
        {
            int det = A[0] * A[4] * A[8] + A[1] * A[5] * A[6] + A[2] * A[3] * A[7] - A[2] * A[4] * A[6] - A[0] * A[5] * A[7] - A[1] * A[3] * A[8];
            int[] A1 = new int[9];
            int[] t = new int[3];
            int t1, t2, t3; t1 = t2 = t3 = 0;
            int w = Mod(det, Alphabet.Length);
            int w1 = Mod(Evklid(Alphabet.Length, w), Alphabet.Length);


            A1[0] = Mod((A[4] * A[8] - A[5] * A[7]) * w1, Alphabet.Length);
            A1[1] = Mod(-(A[3] * A[8] - A[5] * A[6]) * w1, Alphabet.Length);
            A1[2] = Mod((A[3] * A[7] - A[4] * A[6]) * w1, Alphabet.Length);
            A1[3] = Mod(-(A[1] * A[8] - A[2] * A[7]) * w1, Alphabet.Length);
            A1[4] = Mod((A[0] * A[8] - A[2] * A[6]) * w1, Alphabet.Length);
            A1[5] = Mod(-(A[0] * A[7] - A[1] * A[6]) * w1, Alphabet.Length);
            A1[6] = Mod((A[1] * A[5] - A[2] * A[4]) * w1, Alphabet.Length);
            A1[7] = Mod(-(A[0] * A[5] - A[2] * A[3]) * w1, Alphabet.Length);
            A1[8] = Mod((A[0] * A[4] - A[1] * A[3]) * w1, Alphabet.Length);


            char[] Decrypted_Affine = new char[Text.Length];
            for (int i = 0; i <= Text.Length - 3; i += 3)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (Text[i] == Alphabet[j]) t[0] = j;
                    if (Text[i + 1] == Alphabet[j]) t[1] = j;
                    if (Text[i + 2] == Alphabet[j]) t[2] = j;
                }
                Decrypted_Affine[i] = Alphabet[Mod(A1[0] * t[0] + A1[3] * t[1] + A1[6] * t[2], Alphabet.Length)];
                Decrypted_Affine[i + 1] = Alphabet[Mod(A1[1] * t[0] + A1[4] * t[1] + A1[7] * t[2], Alphabet.Length)];
                Decrypted_Affine[i + 2] = Alphabet[Mod(A1[2] * t[0] + A1[5] * t[1] + A1[8] * t[2], Alphabet.Length)];
            }

            string result = string.Join("", Decrypted_Affine);
            return result;
        }
    }
}
