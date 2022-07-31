
namespace HangmanGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HangmanGame.Properties.Resources.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(321, 182);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(40, 40);
            this.buttonQ.TabIndex = 1;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(367, 182);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(40, 40);
            this.buttonW.TabIndex = 2;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.guess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guess the word!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 44);
            this.label4.TabIndex = 7;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(459, 182);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(40, 40);
            this.buttonR.TabIndex = 9;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(413, 182);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(40, 40);
            this.buttonE.TabIndex = 8;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(643, 182);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(40, 40);
            this.buttonI.TabIndex = 13;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(597, 182);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(40, 40);
            this.buttonU.TabIndex = 12;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(551, 182);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(40, 40);
            this.buttonY.TabIndex = 11;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(505, 182);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(40, 40);
            this.buttonT.TabIndex = 10;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(735, 182);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(40, 40);
            this.buttonP.TabIndex = 15;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(689, 182);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(40, 40);
            this.buttonO.TabIndex = 14;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(712, 228);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(40, 40);
            this.buttonL.TabIndex = 24;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(666, 228);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(40, 40);
            this.buttonK.TabIndex = 23;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(620, 228);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(40, 40);
            this.buttonJ.TabIndex = 22;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(574, 228);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(40, 40);
            this.buttonH.TabIndex = 21;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(528, 228);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(40, 40);
            this.buttonG.TabIndex = 20;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(482, 228);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(40, 40);
            this.buttonF.TabIndex = 19;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(436, 228);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(40, 40);
            this.buttonD.TabIndex = 18;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(390, 228);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(40, 40);
            this.buttonS.TabIndex = 17;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(344, 228);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(40, 40);
            this.buttonA.TabIndex = 16;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(643, 274);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(40, 40);
            this.buttonM.TabIndex = 31;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(597, 274);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(40, 40);
            this.buttonN.TabIndex = 30;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(551, 274);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(40, 40);
            this.buttonB.TabIndex = 29;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(505, 274);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(40, 40);
            this.buttonV.TabIndex = 28;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(459, 274);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(40, 40);
            this.buttonC.TabIndex = 27;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(413, 274);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(40, 40);
            this.buttonX.TabIndex = 26;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.guess_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(367, 274);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(40, 40);
            this.buttonZ.TabIndex = 25;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.guess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Number of won games:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Username: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Hint: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "_";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Hint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The HangMan- Game";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Click += new System.EventHandler(this.guess_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}