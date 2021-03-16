
namespace Thesis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOriginal = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCypher = new System.Windows.Forms.Button();
            this.buttonDecypher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelOriginal = new System.Windows.Forms.Panel();
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.groupBoxUserKeys = new System.Windows.Forms.GroupBox();
            this.Nblabel1 = new System.Windows.Forms.Label();
            this.labelNa = new System.Windows.Forms.Label();
            this.textBoxNb = new System.Windows.Forms.TextBox();
            this.textBoxNa = new System.Windows.Forms.TextBox();
            this.groupBoxG = new System.Windows.Forms.GroupBox();
            this.textBoxG0 = new System.Windows.Forms.TextBox();
            this.textBoxG1 = new System.Windows.Forms.TextBox();
            this.groupBoxP = new System.Windows.Forms.GroupBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxS = new System.Windows.Forms.GroupBox();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxA11 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonCleanText = new System.Windows.Forms.Button();
            this.buttonCleanAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHash = new System.Windows.Forms.Button();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelOriginal.SuspendLayout();
            this.groupBoxKeys.SuspendLayout();
            this.groupBoxUserKeys.SuspendLayout();
            this.groupBoxG.SuspendLayout();
            this.groupBoxP.SuspendLayout();
            this.groupBoxS.SuspendLayout();
            this.groupBoxA.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginal.Location = new System.Drawing.Point(3, 0);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(84, 16);
            this.labelOriginal.TabIndex = 0;
            this.labelOriginal.Text = "PUT IN TEXT:";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(6, 19);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(247, 112);
            this.textBoxOriginal.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(247, 112);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(3, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 16);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "RESULT:";
            // 
            // buttonCypher
            // 
            this.buttonCypher.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonCypher.Location = new System.Drawing.Point(6, 310);
            this.buttonCypher.Name = "buttonCypher";
            this.buttonCypher.Size = new System.Drawing.Size(92, 47);
            this.buttonCypher.TabIndex = 4;
            this.buttonCypher.Text = "Cypher";
            this.buttonCypher.UseVisualStyleBackColor = true;
            this.buttonCypher.Click += new System.EventHandler(this.buttonCypher_Click);
            // 
            // buttonDecypher
            // 
            this.buttonDecypher.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonDecypher.Location = new System.Drawing.Point(167, 310);
            this.buttonDecypher.Name = "buttonDecypher";
            this.buttonDecypher.Size = new System.Drawing.Size(92, 47);
            this.buttonDecypher.TabIndex = 5;
            this.buttonDecypher.Text = "Decypher";
            this.buttonDecypher.UseVisualStyleBackColor = true;
            this.buttonDecypher.Click += new System.EventHandler(this.buttonDecypher_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelResult);
            this.panel1.Controls.Add(this.buttonDecypher);
            this.panel1.Controls.Add(this.buttonCypher);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 365);
            this.panel1.TabIndex = 6;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.textBoxResult);
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(6, 150);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(260, 138);
            this.panelResult.TabIndex = 8;
            // 
            // panelOriginal
            // 
            this.panelOriginal.Controls.Add(this.labelOriginal);
            this.panelOriginal.Controls.Add(this.textBoxOriginal);
            this.panelOriginal.Location = new System.Drawing.Point(12, 17);
            this.panelOriginal.Name = "panelOriginal";
            this.panelOriginal.Size = new System.Drawing.Size(266, 139);
            this.panelOriginal.TabIndex = 7;
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.Controls.Add(this.label1);
            this.groupBoxKeys.Controls.Add(this.textBoxB);
            this.groupBoxKeys.Controls.Add(this.groupBoxUserKeys);
            this.groupBoxKeys.Controls.Add(this.groupBoxG);
            this.groupBoxKeys.Controls.Add(this.groupBoxP);
            this.groupBoxKeys.Controls.Add(this.textBoxC);
            this.groupBoxKeys.Controls.Add(this.label2);
            this.groupBoxKeys.Controls.Add(this.groupBoxS);
            this.groupBoxKeys.Controls.Add(this.groupBoxA);
            this.groupBoxKeys.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.groupBoxKeys.Location = new System.Drawing.Point(300, 12);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(204, 304);
            this.groupBoxKeys.TabIndex = 8;
            this.groupBoxKeys.TabStop = false;
            this.groupBoxKeys.Text = "KEYS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "x + ";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(55, 269);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(25, 25);
            this.textBoxB.TabIndex = 21;
            // 
            // groupBoxUserKeys
            // 
            this.groupBoxUserKeys.Controls.Add(this.Nblabel1);
            this.groupBoxUserKeys.Controls.Add(this.labelNa);
            this.groupBoxUserKeys.Controls.Add(this.textBoxNb);
            this.groupBoxUserKeys.Controls.Add(this.textBoxNa);
            this.groupBoxUserKeys.Location = new System.Drawing.Point(16, 142);
            this.groupBoxUserKeys.Name = "groupBoxUserKeys";
            this.groupBoxUserKeys.Size = new System.Drawing.Size(172, 63);
            this.groupBoxUserKeys.TabIndex = 20;
            this.groupBoxUserKeys.TabStop = false;
            this.groupBoxUserKeys.Text = "User keys";
            // 
            // Nblabel1
            // 
            this.Nblabel1.AutoSize = true;
            this.Nblabel1.Location = new System.Drawing.Point(90, 28);
            this.Nblabel1.Name = "Nblabel1";
            this.Nblabel1.Size = new System.Drawing.Size(22, 16);
            this.Nblabel1.TabIndex = 15;
            this.Nblabel1.Text = "nB";
            // 
            // labelNa
            // 
            this.labelNa.AutoSize = true;
            this.labelNa.Location = new System.Drawing.Point(10, 28);
            this.labelNa.Name = "labelNa";
            this.labelNa.Size = new System.Drawing.Size(23, 16);
            this.labelNa.TabIndex = 14;
            this.labelNa.Text = "nA";
            // 
            // textBoxNb
            // 
            this.textBoxNb.Location = new System.Drawing.Point(112, 24);
            this.textBoxNb.Name = "textBoxNb";
            this.textBoxNb.Size = new System.Drawing.Size(37, 25);
            this.textBoxNb.TabIndex = 13;
            // 
            // textBoxNa
            // 
            this.textBoxNa.Location = new System.Drawing.Point(34, 24);
            this.textBoxNa.Name = "textBoxNa";
            this.textBoxNa.Size = new System.Drawing.Size(37, 25);
            this.textBoxNa.TabIndex = 8;
            // 
            // groupBoxG
            // 
            this.groupBoxG.Controls.Add(this.textBoxG0);
            this.groupBoxG.Controls.Add(this.textBoxG1);
            this.groupBoxG.Location = new System.Drawing.Point(88, 207);
            this.groupBoxG.Name = "groupBoxG";
            this.groupBoxG.Size = new System.Drawing.Size(100, 50);
            this.groupBoxG.TabIndex = 9;
            this.groupBoxG.TabStop = false;
            this.groupBoxG.Text = "G(x;y)";
            // 
            // textBoxG0
            // 
            this.textBoxG0.Location = new System.Drawing.Point(8, 19);
            this.textBoxG0.Name = "textBoxG0";
            this.textBoxG0.Size = new System.Drawing.Size(37, 25);
            this.textBoxG0.TabIndex = 17;
            // 
            // textBoxG1
            // 
            this.textBoxG1.Location = new System.Drawing.Point(51, 19);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(37, 25);
            this.textBoxG1.TabIndex = 19;
            // 
            // groupBoxP
            // 
            this.groupBoxP.Controls.Add(this.textBoxP);
            this.groupBoxP.Location = new System.Drawing.Point(16, 207);
            this.groupBoxP.Name = "groupBoxP";
            this.groupBoxP.Size = new System.Drawing.Size(52, 50);
            this.groupBoxP.TabIndex = 10;
            this.groupBoxP.TabStop = false;
            this.groupBoxP.Text = "P";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(6, 19);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(37, 25);
            this.textBoxP.TabIndex = 19;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(111, 269);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(25, 25);
            this.textBoxC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "y = x + ";
            // 
            // groupBoxS
            // 
            this.groupBoxS.Controls.Add(this.textBoxS1);
            this.groupBoxS.Controls.Add(this.textBoxS3);
            this.groupBoxS.Controls.Add(this.textBoxS2);
            this.groupBoxS.Location = new System.Drawing.Point(117, 24);
            this.groupBoxS.Name = "groupBoxS";
            this.groupBoxS.Size = new System.Drawing.Size(71, 112);
            this.groupBoxS.TabIndex = 11;
            this.groupBoxS.TabStop = false;
            this.groupBoxS.Text = "Vector S";
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(23, 23);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(25, 25);
            this.textBoxS1.TabIndex = 1;
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(23, 75);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(25, 25);
            this.textBoxS3.TabIndex = 7;
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(23, 49);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(25, 25);
            this.textBoxS2.TabIndex = 4;
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.textBox5);
            this.groupBoxA.Controls.Add(this.textBox8);
            this.groupBoxA.Controls.Add(this.textBoxA11);
            this.groupBoxA.Controls.Add(this.textBox7);
            this.groupBoxA.Controls.Add(this.textBox1);
            this.groupBoxA.Controls.Add(this.textBox6);
            this.groupBoxA.Controls.Add(this.textBox2);
            this.groupBoxA.Controls.Add(this.textBox3);
            this.groupBoxA.Controls.Add(this.textBox4);
            this.groupBoxA.Location = new System.Drawing.Point(6, 24);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(94, 112);
            this.groupBoxA.TabIndex = 10;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Matrix A";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 25);
            this.textBox5.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(61, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(25, 25);
            this.textBox8.TabIndex = 9;
            // 
            // textBoxA11
            // 
            this.textBoxA11.Location = new System.Drawing.Point(9, 23);
            this.textBoxA11.Name = "textBoxA11";
            this.textBoxA11.Size = new System.Drawing.Size(25, 25);
            this.textBoxA11.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(35, 75);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 25);
            this.textBox7.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 25);
            this.textBox6.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 25);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 25);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 25);
            this.textBox4.TabIndex = 5;
            // 
            // buttonCleanText
            // 
            this.buttonCleanText.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonCleanText.Location = new System.Drawing.Point(300, 322);
            this.buttonCleanText.Name = "buttonCleanText";
            this.buttonCleanText.Size = new System.Drawing.Size(92, 47);
            this.buttonCleanText.TabIndex = 9;
            this.buttonCleanText.Text = "CleanText";
            this.buttonCleanText.UseVisualStyleBackColor = true;
            // 
            // buttonCleanAll
            // 
            this.buttonCleanAll.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonCleanAll.Location = new System.Drawing.Point(412, 322);
            this.buttonCleanAll.Name = "buttonCleanAll";
            this.buttonCleanAll.Size = new System.Drawing.Size(92, 47);
            this.buttonCleanAll.TabIndex = 10;
            this.buttonCleanAll.Text = "Clean All";
            this.buttonCleanAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonHash);
            this.panel2.Controls.Add(this.textBoxHash);
            this.panel2.Location = new System.Drawing.Point(12, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 110);
            this.panel2.TabIndex = 11;
            // 
            // buttonHash
            // 
            this.buttonHash.Location = new System.Drawing.Point(6, 3);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(253, 29);
            this.buttonHash.TabIndex = 1;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // textBoxHash
            // 
            this.textBoxHash.Location = new System.Drawing.Point(6, 38);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(253, 64);
            this.textBoxHash.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCleanAll);
            this.Controls.Add(this.buttonCleanText);
            this.Controls.Add(this.groupBoxKeys);
            this.Controls.Add(this.panelOriginal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelOriginal.ResumeLayout(false);
            this.panelOriginal.PerformLayout();
            this.groupBoxKeys.ResumeLayout(false);
            this.groupBoxKeys.PerformLayout();
            this.groupBoxUserKeys.ResumeLayout(false);
            this.groupBoxUserKeys.PerformLayout();
            this.groupBoxG.ResumeLayout(false);
            this.groupBoxG.PerformLayout();
            this.groupBoxP.ResumeLayout(false);
            this.groupBoxP.PerformLayout();
            this.groupBoxS.ResumeLayout(false);
            this.groupBoxS.PerformLayout();
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCypher;
        private System.Windows.Forms.Button buttonDecypher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelOriginal;
        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.GroupBox groupBoxUserKeys;
        private System.Windows.Forms.Label Nblabel1;
        private System.Windows.Forms.Label labelNa;
        private System.Windows.Forms.TextBox textBoxNb;
        private System.Windows.Forms.TextBox textBoxNa;
        private System.Windows.Forms.GroupBox groupBoxG;
        private System.Windows.Forms.TextBox textBoxG0;
        private System.Windows.Forms.TextBox textBoxG1;
        private System.Windows.Forms.GroupBox groupBoxP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxS;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxA11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonCleanText;
        private System.Windows.Forms.Button buttonCleanAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TextBox textBoxHash;
    }
}

