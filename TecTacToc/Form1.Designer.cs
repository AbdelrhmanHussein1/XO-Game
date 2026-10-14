namespace TecTacToc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTernPlayer = new System.Windows.Forms.Label();
            this.lbRestartGame = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lbWin1 = new System.Windows.Forms.Label();
            this.lbWin2 = new System.Windows.Forms.Label();
            this.lbWinResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRound = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(282, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 64);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tec Tac Toc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTernPlayer
            // 
            this.lbTernPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbTernPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTernPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTernPlayer.Location = new System.Drawing.Point(24, 214);
            this.lbTernPlayer.Name = "lbTernPlayer";
            this.lbTernPlayer.Size = new System.Drawing.Size(244, 40);
            this.lbTernPlayer.TabIndex = 12;
            this.lbTernPlayer.Text = "Player 1";
            this.lbTernPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTernPlayer.Click += new System.EventHandler(this.lbPlayer_Click);
            // 
            // lbRestartGame
            // 
            this.lbRestartGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbRestartGame.BackgroundImage = global::TecTacToc.Properties.Resources.Background2;
            this.lbRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestartGame.ForeColor = System.Drawing.Color.Azure;
            this.lbRestartGame.Location = new System.Drawing.Point(695, 533);
            this.lbRestartGame.Name = "lbRestartGame";
            this.lbRestartGame.Size = new System.Drawing.Size(226, 100);
            this.lbRestartGame.TabIndex = 14;
            this.lbRestartGame.Text = "Restart Game";
            this.lbRestartGame.UseVisualStyleBackColor = false;
            this.lbRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.SkyBlue;
            this.lbResult.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Black;
            this.lbResult.Location = new System.Drawing.Point(335, 54);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(322, 70);
            this.lbResult.TabIndex = 34;
            this.lbResult.Tag = "0";
            this.lbResult.Text = "In Round";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button1.Location = new System.Drawing.Point(316, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 99);
            this.button1.TabIndex = 25;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button2.Location = new System.Drawing.Point(445, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 99);
            this.button2.TabIndex = 26;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button3.Location = new System.Drawing.Point(575, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 99);
            this.button3.TabIndex = 27;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button4.Location = new System.Drawing.Point(316, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 99);
            this.button4.TabIndex = 28;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button5.Location = new System.Drawing.Point(445, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 99);
            this.button5.TabIndex = 29;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button6.Location = new System.Drawing.Point(575, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 99);
            this.button6.TabIndex = 30;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button7.Location = new System.Drawing.Point(316, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 99);
            this.button7.TabIndex = 31;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button8.Location = new System.Drawing.Point(445, 399);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 99);
            this.button8.TabIndex = 32;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::TecTacToc.Properties.Resources.Null2;
            this.button9.Location = new System.Drawing.Point(575, 399);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 99);
            this.button9.TabIndex = 33;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // lbWin1
            // 
            this.lbWin1.AutoSize = true;
            this.lbWin1.BackColor = System.Drawing.Color.Transparent;
            this.lbWin1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin1.Location = new System.Drawing.Point(17, 25);
            this.lbWin1.Name = "lbWin1";
            this.lbWin1.Size = new System.Drawing.Size(129, 26);
            this.lbWin1.TabIndex = 35;
            this.lbWin1.Tag = "0";
            this.lbWin1.Text = "Player 1 ";
            this.lbWin1.Click += new System.EventHandler(this.lbWin1_Click);
            // 
            // lbWin2
            // 
            this.lbWin2.AutoSize = true;
            this.lbWin2.BackColor = System.Drawing.Color.Transparent;
            this.lbWin2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin2.Location = new System.Drawing.Point(17, 86);
            this.lbWin2.Name = "lbWin2";
            this.lbWin2.Size = new System.Drawing.Size(129, 26);
            this.lbWin2.TabIndex = 36;
            this.lbWin2.Tag = "0";
            this.lbWin2.Text = "Player 2 ";
            this.lbWin2.Click += new System.EventHandler(this.lbWin2_Click);
            // 
            // lbWinResult
            // 
            this.lbWinResult.BackColor = System.Drawing.Color.Transparent;
            this.lbWinResult.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinResult.Location = new System.Drawing.Point(135, 51);
            this.lbWinResult.Name = "lbWinResult";
            this.lbWinResult.Size = new System.Drawing.Size(158, 37);
            this.lbWinResult.TabIndex = 37;
            this.lbWinResult.Text = "Draw";
            this.lbWinResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWinResult.Click += new System.EventHandler(this.lbWinResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbRound);
            this.panel1.Controls.Add(this.lbWin1);
            this.panel1.Controls.Add(this.lbWinResult);
            this.panel1.Controls.Add(this.lbWin2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTernPlayer);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 264);
            this.panel1.TabIndex = 38;
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.BackColor = System.Drawing.Color.Transparent;
            this.lbRound.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRound.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbRound.Location = new System.Drawing.Point(10, 131);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(124, 33);
            this.lbRound.TabIndex = 38;
            this.lbRound.Tag = "0";
            this.lbRound.Text = "Round : ";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.BackgroundImage = global::TecTacToc.Properties.Resources.Background2;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Azure;
            this.button10.Location = new System.Drawing.Point(24, 537);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(226, 100);
            this.button10.TabIndex = 39;
            this.button10.Text = "Next Round";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TecTacToc.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 649);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRestartGame);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lbRestartGame;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lbWin1;
        private System.Windows.Forms.Label lbWin2;
        private System.Windows.Forms.Label lbWinResult;
        public System.Windows.Forms.Label lbTernPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lbRound;
    }
}

