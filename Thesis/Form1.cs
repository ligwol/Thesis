using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Thesis
{
    public partial class Form1 : Form
    {
        private bool isWide = false, isWide2 = false;
        public Form1()
        {
            InitializeComponent();
            this.Width = 400;
        }

        private void buttonCypher_Click(object sender, EventArgs e)
        {
            string originalText = textBoxOriginal.Text.ToUpper().Replace(" ", ""); ;

            string alphabet = "0123456789abcdef.,x";
            //string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,'";
            int.TryParse(textBoxA11.Text, out int A11); //a11=5
            int.TryParse(textBoxA12.Text, out int A12); //a12=4
            int.TryParse(textBoxA13.Text, out int A13); //a13=6
            int.TryParse(textBoxA21.Text, out int A21); //a21=2
            int.TryParse(textBoxA22.Text, out int A22); //a22=3
            int.TryParse(textBoxA23.Text, out int A23); //a23=1
            int.TryParse(textBoxA31.Text, out int A31); //a31=2
            int.TryParse(textBoxA32.Text, out int A32); //a32=4
            int.TryParse(textBoxA33.Text, out int A33); //a33=5

            //int A11 = 5, A12 = 4, A13 = 6, A21 = 2, A22 = 3, A23 = 1, A31 = 2, A32 = 4, A33 = 5;
            int[] MatrixA = { A11, A12, A13, A21, A22, A23, A31, A32, A33 }; // Matrix A


            int.TryParse(textBoxS1.Text, out int S1); //S1
            int.TryParse(textBoxS2.Text, out int S2); //S2
            int.TryParse(textBoxS3.Text, out int S3); //S3
            //int S1 = 1, S2 = 2, S3 = 3;
            int[] VectorS = { S1, S2, S3 };     // vector S


            int.TryParse(textBoxNa.Text, out int nA); //nA=2
            int.TryParse(textBoxNb.Text, out int nB); //nB=3
            int.TryParse(textBoxP.Text, out int p); //p=211
            int.TryParse(textBoxG0.Text, out int G0); //G0=2
            int.TryParse(textBoxG1.Text, out int G1); //G1=2
            int b = 0, c = -4;
            //int nA = 2, nB = 3, p = 211, b = 0, c = -4, G0 = 2, G1 = 2;
            int[] G = { G0, G1 };

            string outputHash = Hash.makingHash(originalText);

            string outputAffine = Affin.Encryption_Affine(outputHash, alphabet, MatrixA, VectorS);//originalText->outputMatr
            string outputElliptic = Elliptic.EllipticEncryption(outputAffine, alphabet, nA, nB, p, b, c, G);
            textBoxResult.Text = outputElliptic;
            textBoxHash.Text = outputHash;
            //textBoxResult.Text = outputAffine;
            //textBoxResult.Text = outputHash;
        }

        private void buttonDecypher_Click(object sender, EventArgs e)

        {
            string originalText = textBoxOriginal.Text.ToUpper().Trim();

            string alphabet = "0123456789abcdef.,x";

            int.TryParse(textBoxA11.Text, out int A11); //a11=5
            int.TryParse(textBoxA12.Text, out int A12); //a12=4
            int.TryParse(textBoxA13.Text, out int A13); //a13=6
            int.TryParse(textBoxA21.Text, out int A21); //a21=2
            int.TryParse(textBoxA22.Text, out int A22); //a22=3
            int.TryParse(textBoxA23.Text, out int A23); //a23=1
            int.TryParse(textBoxA31.Text, out int A31); //a31=2
            int.TryParse(textBoxA32.Text, out int A32); //a32=4
            int.TryParse(textBoxA33.Text, out int A33); //a33=5

            //int A11 = 5, A12 = 4, A13 = 6, A21 = 2, A22 = 3, A23 = 1, A31 = 2, A32 = 4, A33 = 5;
            int[] MatrixA = { A11, A12, A13, A21, A22, A23, A31, A32, A33 }; // Matrix A

            int.TryParse(textBoxS1.Text, out int S1); //S1
            int.TryParse(textBoxS2.Text, out int S2); //S2
            int.TryParse(textBoxS3.Text, out int S3); //S3
            int[] VectorS = { S1, S2, S3 };     // vector S


            int.TryParse(textBoxNa.Text, out int nA); //nA=2
            int.TryParse(textBoxNb.Text, out int nB); //nB=3
            int.TryParse(textBoxP.Text, out int p); //p=211
            int.TryParse(textBoxG0.Text, out int G0); //G0=2
            int.TryParse(textBoxG1.Text, out int G1); //G1=2
            int b = 0, c = -4;
            //int nA = 2, nB = 3, p = 211, b = 0, c = -4, G0 = 2, G1 = 2;
            int[] G = { G0, G1 };
            string outputElliptic = Elliptic.EllipticDecryption(originalText, alphabet, nB, b, p);
            string outputAffine = Affin.Decryption_Affine(outputElliptic, alphabet, MatrixA, VectorS);
            textBoxResult.Text = outputAffine;
        }

        private void buttonCleanText_Click(object sender, EventArgs e)
        {

        }

        private void labelOriginal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void buttonShowKeys_Click(object sender, EventArgs e)
        {
            if (isWide)
            {
                // Если окно было широким, уменьшаем его на 400 пикселей
                this.Width -= 200;
            }
            else
            {
                // Если окно было узким, увеличиваем его на 400 пикселей
                this.Width += 200;
            }

            // Инвертируем состояние окна
            isWide = !isWide;
        }

        private void radioButtonMatrix1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMatrix1.Checked)
            {
                groupBoxMatrix1.Enabled = true;
                groupBoxMatrix2.Enabled = false;
                groupBoxMatrix3.Enabled = false;
                groupBoxMatrix4.Enabled = false;
                // Деактивировать остальные groupBox
                textBoxA11.Text = textBoxMatrixA11.Text;
                textBoxA12.Text = textBoxMatrixA12.Text;
                textBoxA13.Text = textBoxMatrixA13.Text;
                textBoxA21.Text = textBoxMatrixA21.Text;
                textBoxA22.Text = textBoxMatrixA22.Text;
                textBoxA23.Text = textBoxMatrixA23.Text;
                textBoxA31.Text = textBoxMatrixA31.Text;
                textBoxA32.Text = textBoxMatrixA32.Text;
                textBoxA33.Text = textBoxMatrixA33.Text;
            }
        }

        private void radioButtonMatrix2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMatrix2.Checked)
            {
                groupBoxMatrix1.Enabled = false;
                groupBoxMatrix2.Enabled = true;
                groupBoxMatrix3.Enabled = false;
                groupBoxMatrix4.Enabled = false;
                // Деактивировать остальные groupBox

                textBoxA11.Text = textBoxMatrixB11.Text;
                textBoxA12.Text = textBoxMatrixB12.Text;
                textBoxA13.Text = textBoxMatrixB13.Text;
                textBoxA21.Text = textBoxMatrixB21.Text;
                textBoxA22.Text = textBoxMatrixB22.Text;
                textBoxA23.Text = textBoxMatrixB23.Text;
                textBoxA31.Text = textBoxMatrixB31.Text;
                textBoxA32.Text = textBoxMatrixB32.Text;
                textBoxA33.Text = textBoxMatrixB33.Text;
            }
        }

        private void radioButtonMatrix3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMatrix3.Checked)
            {
                groupBoxMatrix1.Enabled = false;
                groupBoxMatrix2.Enabled = false;
                groupBoxMatrix3.Enabled = true;
                groupBoxMatrix4.Enabled = false;
                // Деактивировать остальные groupBox

                textBoxA11.Text = textBoxMatrixC11.Text;
                textBoxA12.Text = textBoxMatrixC12.Text;
                textBoxA13.Text = textBoxMatrixC13.Text;
                textBoxA21.Text = textBoxMatrixC21.Text;
                textBoxA22.Text = textBoxMatrixC22.Text;
                textBoxA23.Text = textBoxMatrixC23.Text;
                textBoxA31.Text = textBoxMatrixC31.Text;
                textBoxA32.Text = textBoxMatrixC32.Text;
                textBoxA33.Text = textBoxMatrixC33.Text;
            }
        }

        private void radioButtonMatrix4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMatrix4.Checked)
            {
                groupBoxMatrix1.Enabled = false;
                groupBoxMatrix2.Enabled = false;
                groupBoxMatrix3.Enabled = false;
                groupBoxMatrix4.Enabled = true;
                // Деактивировать остальные groupBox

                textBoxA11.Text = textBoxMatrixD11.Text;
                textBoxA12.Text = textBoxMatrixD12.Text;
                textBoxA13.Text = textBoxMatrixD13.Text;
                textBoxA21.Text = textBoxMatrixD21.Text;
                textBoxA22.Text = textBoxMatrixD22.Text;
                textBoxA23.Text = textBoxMatrixD23.Text;
                textBoxA31.Text = textBoxMatrixD31.Text;
                textBoxA32.Text = textBoxMatrixD32.Text;
                textBoxA33.Text = textBoxMatrixD33.Text;
            }
        }

        private void panelResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonVector1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVector1.Checked)
            {
                groupBoxVector1.Enabled = true;
                groupBoxVector2.Enabled = false;
                groupBoxVector3.Enabled = false;
                // Деактивировать остальные groupBox

                textBoxS1.Text = textBoxVector11.Text;
                textBoxS2.Text = textBoxVector12.Text;
                textBoxS3.Text = textBoxVector13.Text;
            }
        }

        private void radioButtonVector2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVector2.Checked)
            {
                groupBoxVector1.Enabled = false;
                groupBoxVector2.Enabled = true;
                groupBoxVector3.Enabled = false;
                // Деактивировать остальные groupBox

                textBoxS1.Text = textBoxVector21.Text;
                textBoxS2.Text = textBoxVector22.Text;
                textBoxS3.Text = textBoxVector23.Text;
            }
        }

        private void radioButtonVector3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVector3.Checked)
            {
                groupBoxVector1.Enabled = false;
                groupBoxVector2.Enabled = false;
                groupBoxVector3.Enabled = true;
                // Деактивировать остальные groupBox

                textBoxS1.Text = textBoxVector31.Text;
                textBoxS2.Text = textBoxVector32.Text;
                textBoxS3.Text = textBoxVector33.Text;
            }
        }

        private void buttonChooseKeys_Click(object sender, EventArgs e)
        {
            if (isWide2)
            {
                // Если окно было широким, уменьшаем его на 400 пикселей
                this.Width -= 300;
            }
            else
            {
                // Если окно было узким, увеличиваем его на 400 пикселей
                this.Width += 300;
            }

            // Инвертируем состояние окна
            isWide2 = !isWide2;
        }
    }
}
