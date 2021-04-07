
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
            this.groupBoxS = new System.Windows.Forms.GroupBox();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.textBoxA23 = new System.Windows.Forms.TextBox();
            this.textBoxA33 = new System.Windows.Forms.TextBox();
            this.textBoxA11 = new System.Windows.Forms.TextBox();
            this.textBoxA32 = new System.Windows.Forms.TextBox();
            this.textBoxA12 = new System.Windows.Forms.TextBox();
            this.textBoxA31 = new System.Windows.Forms.TextBox();
            this.textBoxA13 = new System.Windows.Forms.TextBox();
            this.textBoxA21 = new System.Windows.Forms.TextBox();
            this.textBoxA22 = new System.Windows.Forms.TextBox();
            this.buttonCleanText = new System.Windows.Forms.Button();
            this.buttonCleanAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHash = new System.Windows.Forms.Label();
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
            this.panel3.SuspendLayout();
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
            this.textBoxResult.Size = new System.Drawing.Size(383, 77);
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
            this.buttonCypher.Location = new System.Drawing.Point(6, 150);
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
            this.buttonDecypher.Location = new System.Drawing.Point(167, 150);
            this.buttonDecypher.Name = "buttonDecypher";
            this.buttonDecypher.Size = new System.Drawing.Size(92, 47);
            this.buttonDecypher.TabIndex = 5;
            this.buttonDecypher.Text = "Decypher";
            this.buttonDecypher.UseVisualStyleBackColor = true;
            this.buttonDecypher.Click += new System.EventHandler(this.buttonDecypher_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDecypher);
            this.panel1.Controls.Add(this.buttonCypher);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 205);
            this.panel1.TabIndex = 6;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.textBoxResult);
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(265, 3);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(392, 99);
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
            this.groupBoxKeys.Controls.Add(this.groupBoxUserKeys);
            this.groupBoxKeys.Controls.Add(this.groupBoxG);
            this.groupBoxKeys.Controls.Add(this.groupBoxP);
            this.groupBoxKeys.Controls.Add(this.groupBoxS);
            this.groupBoxKeys.Controls.Add(this.groupBoxA);
            this.groupBoxKeys.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.groupBoxKeys.Location = new System.Drawing.Point(300, 12);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(375, 144);
            this.groupBoxKeys.TabIndex = 8;
            this.groupBoxKeys.TabStop = false;
            this.groupBoxKeys.Text = "KEYS";
            // 
            // groupBoxUserKeys
            // 
            this.groupBoxUserKeys.Controls.Add(this.Nblabel1);
            this.groupBoxUserKeys.Controls.Add(this.labelNa);
            this.groupBoxUserKeys.Controls.Add(this.textBoxNb);
            this.groupBoxUserKeys.Controls.Add(this.textBoxNa);
            this.groupBoxUserKeys.Location = new System.Drawing.Point(197, 24);
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
            this.textBoxNb.Text = "3";
            // 
            // textBoxNa
            // 
            this.textBoxNa.Location = new System.Drawing.Point(34, 24);
            this.textBoxNa.Name = "textBoxNa";
            this.textBoxNa.Size = new System.Drawing.Size(37, 25);
            this.textBoxNa.TabIndex = 8;
            this.textBoxNa.Text = "2";
            // 
            // groupBoxG
            // 
            this.groupBoxG.Controls.Add(this.textBoxG0);
            this.groupBoxG.Controls.Add(this.textBoxG1);
            this.groupBoxG.Location = new System.Drawing.Point(269, 89);
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
            this.textBoxG0.Text = "2";
            // 
            // textBoxG1
            // 
            this.textBoxG1.Location = new System.Drawing.Point(51, 19);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(37, 25);
            this.textBoxG1.TabIndex = 19;
            this.textBoxG1.Text = "2";
            // 
            // groupBoxP
            // 
            this.groupBoxP.Controls.Add(this.textBoxP);
            this.groupBoxP.Location = new System.Drawing.Point(197, 89);
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
            this.textBoxP.Text = "701";
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
            this.textBoxS1.Text = "3";
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(23, 75);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(25, 25);
            this.textBoxS3.TabIndex = 7;
            this.textBoxS3.Text = "7";
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(23, 49);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(25, 25);
            this.textBoxS2.TabIndex = 4;
            this.textBoxS2.Text = "9";
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.textBoxA23);
            this.groupBoxA.Controls.Add(this.textBoxA33);
            this.groupBoxA.Controls.Add(this.textBoxA11);
            this.groupBoxA.Controls.Add(this.textBoxA32);
            this.groupBoxA.Controls.Add(this.textBoxA12);
            this.groupBoxA.Controls.Add(this.textBoxA31);
            this.groupBoxA.Controls.Add(this.textBoxA13);
            this.groupBoxA.Controls.Add(this.textBoxA21);
            this.groupBoxA.Controls.Add(this.textBoxA22);
            this.groupBoxA.Location = new System.Drawing.Point(6, 24);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(94, 112);
            this.groupBoxA.TabIndex = 10;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Matrix A";
            // 
            // textBoxA23
            // 
            this.textBoxA23.Location = new System.Drawing.Point(61, 49);
            this.textBoxA23.Name = "textBoxA23";
            this.textBoxA23.Size = new System.Drawing.Size(25, 25);
            this.textBoxA23.TabIndex = 6;
            this.textBoxA23.Text = "1";
            // 
            // textBoxA33
            // 
            this.textBoxA33.Location = new System.Drawing.Point(61, 75);
            this.textBoxA33.Name = "textBoxA33";
            this.textBoxA33.Size = new System.Drawing.Size(25, 25);
            this.textBoxA33.TabIndex = 9;
            this.textBoxA33.Text = "5";
            // 
            // textBoxA11
            // 
            this.textBoxA11.Location = new System.Drawing.Point(9, 23);
            this.textBoxA11.Name = "textBoxA11";
            this.textBoxA11.Size = new System.Drawing.Size(25, 25);
            this.textBoxA11.TabIndex = 1;
            this.textBoxA11.Text = "5";
            // 
            // textBoxA32
            // 
            this.textBoxA32.Location = new System.Drawing.Point(35, 75);
            this.textBoxA32.Name = "textBoxA32";
            this.textBoxA32.Size = new System.Drawing.Size(25, 25);
            this.textBoxA32.TabIndex = 8;
            this.textBoxA32.Text = "4";
            // 
            // textBoxA12
            // 
            this.textBoxA12.Location = new System.Drawing.Point(35, 23);
            this.textBoxA12.Name = "textBoxA12";
            this.textBoxA12.Size = new System.Drawing.Size(25, 25);
            this.textBoxA12.TabIndex = 2;
            this.textBoxA12.Text = "4";
            // 
            // textBoxA31
            // 
            this.textBoxA31.Location = new System.Drawing.Point(9, 75);
            this.textBoxA31.Name = "textBoxA31";
            this.textBoxA31.Size = new System.Drawing.Size(25, 25);
            this.textBoxA31.TabIndex = 7;
            this.textBoxA31.Text = "2";
            // 
            // textBoxA13
            // 
            this.textBoxA13.Location = new System.Drawing.Point(61, 23);
            this.textBoxA13.Name = "textBoxA13";
            this.textBoxA13.Size = new System.Drawing.Size(25, 25);
            this.textBoxA13.TabIndex = 3;
            this.textBoxA13.Text = "6";
            // 
            // textBoxA21
            // 
            this.textBoxA21.Location = new System.Drawing.Point(9, 49);
            this.textBoxA21.Name = "textBoxA21";
            this.textBoxA21.Size = new System.Drawing.Size(25, 25);
            this.textBoxA21.TabIndex = 4;
            this.textBoxA21.Text = "2";
            // 
            // textBoxA22
            // 
            this.textBoxA22.Location = new System.Drawing.Point(35, 49);
            this.textBoxA22.Name = "textBoxA22";
            this.textBoxA22.Size = new System.Drawing.Size(25, 25);
            this.textBoxA22.TabIndex = 5;
            this.textBoxA22.Text = "3";
            // 
            // buttonCleanText
            // 
            this.buttonCleanText.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonCleanText.Location = new System.Drawing.Point(300, 162);
            this.buttonCleanText.Name = "buttonCleanText";
            this.buttonCleanText.Size = new System.Drawing.Size(92, 47);
            this.buttonCleanText.TabIndex = 9;
            this.buttonCleanText.Text = "CleanText";
            this.buttonCleanText.UseVisualStyleBackColor = true;
            // 
            // buttonCleanAll
            // 
            this.buttonCleanAll.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.buttonCleanAll.Location = new System.Drawing.Point(412, 162);
            this.buttonCleanAll.Name = "buttonCleanAll";
            this.buttonCleanAll.Size = new System.Drawing.Size(92, 47);
            this.buttonCleanAll.TabIndex = 10;
            this.buttonCleanAll.Text = "Clean All";
            this.buttonCleanAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelResult);
            this.panel2.Location = new System.Drawing.Point(12, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 108);
            this.panel2.TabIndex = 11;
            // 
            // textBoxHash
            // 
            this.textBoxHash.Location = new System.Drawing.Point(6, 16);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(247, 80);
            this.textBoxHash.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelHash);
            this.panel3.Controls.Add(this.textBoxHash);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 99);
            this.panel3.TabIndex = 9;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHash.Location = new System.Drawing.Point(3, 0);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(44, 16);
            this.labelHash.TabIndex = 2;
            this.labelHash.Text = "HASH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 340);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxS;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox textBoxA23;
        private System.Windows.Forms.TextBox textBoxA33;
        private System.Windows.Forms.TextBox textBoxA11;
        private System.Windows.Forms.TextBox textBoxA32;
        private System.Windows.Forms.TextBox textBoxA12;
        private System.Windows.Forms.TextBox textBoxA31;
        private System.Windows.Forms.TextBox textBoxA13;
        private System.Windows.Forms.TextBox textBoxA21;
        private System.Windows.Forms.TextBox textBoxA22;
        private System.Windows.Forms.Button buttonCleanText;
        private System.Windows.Forms.Button buttonCleanAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHash;
    }
}

