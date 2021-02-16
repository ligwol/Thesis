﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCypher_Click(object sender, EventArgs e)
        {
            string OriginalText = textBoxOriginal.Text.ToUpper().Trim();

            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,'";
            /*
            int.TryParse(textBoxA11.Text, out int A11); //a11=5
            int.TryParse(textBoxA12.Text, out int A12); //a12=4
            int.TryParse(textBoxA13.Text, out int A13); //a13=6
            int.TryParse(textBoxA21.Text, out int A21); //a21=2
            int.TryParse(textBoxA22.Text, out int A22); //a22=3
            int.TryParse(textBoxA23.Text, out int A23); //a23=1
            int.TryParse(textBoxA31.Text, out int A31); //a31=2
            int.TryParse(textBoxA32.Text, out int A32); //a32=4
            int.TryParse(textBoxA33.Text, out int A33); //a33=5*/

            int A11 = 5, A12 = 4, A13 = 6, A21 = 2, A22 = 3, A23 = 1, A31 = 2, A32 = 4, A33 = 5;
            int[] MatrixA = { A11, A12, A13, A21, A22, A23, A31, A32, A33 }; // Matrix A

            /*
            int.TryParse(textBoxS1.Text, out int S1); //S1
            int.TryParse(textBoxS2.Text, out int S2); //S2
            int.TryParse(textBoxS3.Text, out int S3); //S3*/
            int S1 = 1, S2 = 2, S3 = 3;
            int[] VectorS = { S1, S2, S3 };     // vector S

            string outputAffine = Affin.Encryption_Affine(OriginalText, Alphabet, MatrixA, VectorS);//OriginalText->outputMatr
            textBoxResult.Text = outputAffine;
        }

        private void buttonDecypher_Click(object sender, EventArgs e)
        {
            string OriginalText = textBoxOriginal.Text.ToUpper().Trim();

            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,'";
            /*
            int.TryParse(textBoxA11.Text, out int A11); //a11=5
            int.TryParse(textBoxA12.Text, out int A12); //a12=4
            int.TryParse(textBoxA13.Text, out int A13); //a13=6
            int.TryParse(textBoxA21.Text, out int A21); //a21=2
            int.TryParse(textBoxA22.Text, out int A22); //a22=3
            int.TryParse(textBoxA23.Text, out int A23); //a23=1
            int.TryParse(textBoxA31.Text, out int A31); //a31=2
            int.TryParse(textBoxA32.Text, out int A32); //a32=4
            int.TryParse(textBoxA33.Text, out int A33); //a33=5*/

            int A11 = 5, A12 = 4, A13 = 6, A21 = 2, A22 = 3, A23 = 1, A31 = 2, A32 = 4, A33 = 5;
            int[] MatrixA = { A11, A12, A13, A21, A22, A23, A31, A32, A33 }; // Matrix A

            /*
            int.TryParse(textBoxS1.Text, out int S1); //S1
            int.TryParse(textBoxS2.Text, out int S2); //S2
            int.TryParse(textBoxS3.Text, out int S3); //S3*/
            int S1 = 1, S2 = 2, S3 = 3;
            int[] VectorS = { S1, S2, S3 };     // vector S

            string outputAffine = Affin.Decryption_Affine(OriginalText, Alphabet, MatrixA, VectorS);
            textBoxResult.Text = outputAffine;
        }
    }
}
