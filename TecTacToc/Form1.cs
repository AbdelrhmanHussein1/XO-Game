using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using TecTacToc.Properties;

namespace TecTacToc
{
    public partial class Form1 : Form
    {
        public Form1(string player1, string player2, bool playWithComputer = false, bool useDefaultNames = false, enLevel level = enLevel.Medium)
        {
            InitializeComponent();

            PlayWithComputer = playWithComputer;
            Level = level;
            if (useDefaultNames)
            {
                Player1Name = "Player1";

                if (PlayWithComputer)
                    Player2Name = "Computer";
                else
                    Player2Name = "Player2";
            }
            else
            {
                Player1Name = player1;

                if (PlayWithComputer)
                    Player2Name = "Computer";
                else
                    Player2Name = player2;
            }
        }

        public enum enLevel
        {
            Easy,
            Medium,
            Hard
        }

        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        public bool PlayWithComputer { get; set; }
        public short GameRound { get; set; }

        public enLevel Level { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStatus = new stGameStatus();
            GameStatus.GameOver = false;

            GameRound = 1;

            lbTernPlayer.Text = Player1Name;
            lbWin1.Text = Player1Name + " : 0";
            lbWin1.Tag = 0;

            lbWin2.Text = Player2Name + " : 0";
            lbWin2.Tag = 0;

            lbRound.Text = "Round : 1";
            lbRound.Tag = 1;
        }

        //void DrawLineBetweenButtons(Graphics g, Button b1, Button b2, Color color, float width)
        //{
        //    using (Pen pen = new Pen(color, width))
        //    {
        //        Point p1 = new Point(b1.Left + b1.Width / 2, b1.Top + b1.Height / 2);
        //        Point p2 = new Point(b2.Left + b2.Width / 2, b2.Top + b2.Height / 2);
        //        g.DrawLine(pen, p1, p2);
        //    }
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //DrawLineBetweenButtons(e.Graphics, button1, button2, Color.Black, 4);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Text = $"X = {e.X} , Y = {e.Y}";
        //}

        enPlayWith Gamming = enPlayWith.Frind;

        enum enPlayWith
        {
            Frind,
            Computer
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        Random rand = new Random();

        Button easyMode()
        {
            for (int i = 1; i <= 9; i++)
            {
                string StringBtnCom = "button" + rand.Next(1, 10).ToString();
                Button btnCom = this.Controls[StringBtnCom] as Button;

                if (btnCom != null && btnCom.Tag.ToString() == "?")
                    return btnCom;
            }

            return null;
        }

        Button WhatToPlay(Button btn1, Button btn2, Button btn3, string Tag)
        {
            if ((btn1.Tag.ToString() == Tag && btn2.Tag.ToString() == Tag) ||
                (btn1.Tag.ToString() == Tag && btn3.Tag.ToString() == Tag) ||
                (btn2.Tag.ToString() == Tag && btn3.Tag.ToString() == Tag))
            {
                if (btn1.Tag.ToString() == "?" || btn2.Tag.ToString() == "?" || btn3.Tag.ToString() == "?")
                {
                    if (btn1.Tag.ToString() == "?")
                    {
                        return btn1;
                    }
                    else if ((btn1.Tag.ToString() == btn2.Tag.ToString()))
                    {
                        return btn3;
                    }
                    else
                    {
                        return btn2;
                    }
                }
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>        // -------------------- Minimax helpers --------------------
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private int Minimax(bool isMaximizing, int alpha, int beta)
        {
            string result = EvaluateBoard();
            if (result == "O") return +1;
            if (result == "X") return -1;
            if (result == "Draw") return 0;

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                foreach (var btn in GetEmptyButtons())
                {
                    btn.Tag = "O";
                    int score = Minimax(false, alpha, beta);
                    btn.Tag = "?";
                    bestScore = Math.Max(bestScore, score);

                    alpha = Math.Max(alpha, bestScore);

                    if (beta <= alpha) break;
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                foreach (var btn in GetEmptyButtons())
                {
                    btn.Tag = "X";
                    int score = Minimax(true, alpha, beta);
                    btn.Tag = "?";
                    bestScore = Math.Min(bestScore, score);

                    beta = Math.Min(beta, bestScore);

                    if (beta <= alpha) break;
                }
                return bestScore;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private List<Button> GetEmptyButtons()
        {
            return this.Controls
                       .OfType<Button>()
                       .Where(b => b.Name.StartsWith("button") && b.Tag != null && b.Tag.ToString() == "?")
                       .OrderBy(b => b.Name)
                       .ToList();
        }

        private string EvaluateBoard()
        {
            Button[][] lines = new Button[][]
            {
                new Button[]{button1, button2, button3},
                new Button[]{button4, button5, button6},
                new Button[]{button7, button8, button9},
                new Button[]{button1, button4, button7},
                new Button[]{button2, button5, button8},
                new Button[]{button3, button6, button9},
                new Button[]{button1, button5, button9},
                new Button[]{button3, button5, button7}
            };
            //8 صناديق كل صندوق يحتوي مغلف كل مغلف يحتوي 3 اسماء وهي صار عنا مصفوفه ثنائيه الابعاد
            //بحلقه بنقدر نفحص كل الحالات دون استعمال كود مكرر في شرط اف 
            foreach (var line in lines)
            {
                string a = line[0].Tag?.ToString();
                string b = line[1].Tag?.ToString();
                string c = line[2].Tag?.ToString();

                if (!string.IsNullOrEmpty(a) && a != "?" && a == b && b == c)
                    return a;
            }

            if (GetEmptyButtons().Count == 0) return "Draw";

            return null;
        }

        //private int Minimax(bool isMaximizing)
        //{
        //    string result = EvaluateBoard();// مادام اللعبه شغاله رح ترجع null
        //    if (result == "O") return +1;
        //    if (result == "X") return -1;
        //    if (result == "Draw") return 0;

        //    if (isMaximizing)
        //    {
        //        int bestScore = int.MinValue;
        //        foreach (var btn in GetEmptyButtons())
        //        {
        //            btn.Tag = "O";
        //            int score = Minimax(false);
        //            btn.Tag = "?";
        //            if (score > bestScore) bestScore = score;
        //        }
        //        return bestScore;
        //    }
        //    else
        //    {
        //        int bestScore = int.MaxValue;
        //        foreach (var btn in GetEmptyButtons())
        //        {
        //            btn.Tag = "X";
        //            int score = Minimax(true);
        //            btn.Tag = "?";
        //            if (score < bestScore) bestScore = score;
        //        }
        //        return bestScore;
        //    }
        //}

        private Button BestMoveMinimax()
        {
            int bestScore = int.MinValue;
            Button bestButton = null;

            int alpha = int.MinValue;
            int beta = int.MaxValue;

            foreach (var btn in GetEmptyButtons())
            {
                btn.Tag = "O";

                int score = Minimax(false, alpha, beta);

                btn.Tag = "?";

                if (score > bestScore)
                {
                    bestScore = score;
                    bestButton = btn;
                }
            }

            return bestButton;
        }

        //private Button BestMoveMinimax()
        //{
        //    int bestScore = int.MinValue;
        //    Button bestButton = null;

        //    foreach (var btn in GetEmptyButtons())
        //    {
        //        btn.Tag = "O";
        //        int score = Minimax(false);
        //        btn.Tag = "?";

        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            bestButton = btn;
        //        }
        //    }

        //    return bestButton;
        //}

        // -------------------- استبدال hardMode --------------------
        /// ///////////////////////////////////////////////////////////////////////////////////////////

        Button hardMode()
        {
            Button move = BestMoveMinimax();
            if (move != null) return move;
            return easyMode();
        }

        Button MediumMod()
        {
            if (WhatToPlay(button1, button2, button3, "O") != null) return WhatToPlay(button1, button2, button3, "O");
            if (WhatToPlay(button4, button5, button6, "O") != null) return WhatToPlay(button4, button5, button6, "O");
            if (WhatToPlay(button7, button8, button9, "O") != null) return WhatToPlay(button7, button8, button9, "O");

            if (WhatToPlay(button1, button4, button7, "O") != null) return WhatToPlay(button1, button4, button7, "O");
            if (WhatToPlay(button2, button5, button8, "O") != null) return WhatToPlay(button2, button5, button8, "O");
            if (WhatToPlay(button3, button6, button9, "O") != null) return WhatToPlay(button3, button6, button9, "O");

            if (WhatToPlay(button1, button5, button9, "O") != null) return WhatToPlay(button1, button5, button9, "O");
            if (WhatToPlay(button3, button5, button7, "O") != null) return WhatToPlay(button3, button5, button7, "O");

            if (WhatToPlay(button1, button2, button3, "X") != null) return WhatToPlay(button1, button2, button3, "X");
            if (WhatToPlay(button4, button5, button6, "X") != null) return WhatToPlay(button4, button5, button6, "X");
            if (WhatToPlay(button7, button8, button9, "X") != null) return WhatToPlay(button7, button8, button9, "X");

            if (WhatToPlay(button1, button4, button7, "X") != null) return WhatToPlay(button1, button4, button7, "X");
            if (WhatToPlay(button2, button5, button8, "X") != null) return WhatToPlay(button2, button5, button8, "X");
            if (WhatToPlay(button3, button6, button9, "X") != null) return WhatToPlay(button3, button6, button9, "X");

            if (WhatToPlay(button1, button5, button9, "X") != null) return WhatToPlay(button1, button5, button9, "X");
            if (WhatToPlay(button3, button5, button7, "X") != null) return WhatToPlay(button3, button5, button7, "X");

            return easyMode();
        }

        Button ChangeLevelWithComputer()
        {
            switch (Level)
            {
                case enLevel.Easy:
                    return easyMode();

                case enLevel.Medium:
                    return MediumMod();

                case enLevel.Hard:
                    return hardMode();
            }

            return easyMode();
        }

        private bool WinnerLook(Button btn1)
        {
            if (btn1.Tag.ToString() == "X")
            {
                GameStatus.Winner = enWinner.Player1;
                lbResult.ForeColor = Color.Blue;
                GameStatus.GameOver = true;
                return true;
            }
            else if (btn1.Tag.ToString() == "O")
            {
                GameStatus.Winner = enWinner.Player2;
                lbResult.ForeColor = Color.MediumVioletRed;
                GameStatus.GameOver = true;
                return true;
            }
            else { return false; }
        }

        public bool CheackValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                btn1.Refresh();
                btn2.Refresh();
                btn3.Refresh();

                if (WinnerLook(btn1))
                    return true;
            }

            return false;
        }

        public bool CheckWinner()
        {
            if (CheackValues(button1, button2, button3) ||
                CheackValues(button4, button5, button6) ||
                CheackValues(button7, button8, button9) ||
                CheackValues(button1, button4, button7) ||
                CheackValues(button2, button5, button8) ||
                CheackValues(button3, button6, button9) ||
                CheackValues(button1, button5, button9) ||
                CheackValues(button3, button5, button7))
            {
                return true;
            }
            else if (GameStatus.PlayCount >= 9)
            {
                lbTernPlayer.Text = "Result Round";

                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                lbResult.ForeColor = Color.Gold;

                return true;
            }

            else
                return false;
        }

        public void ChangeRole(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:

                        if (PlayWithComputer)
                        {
                            lbTernPlayer.Text = "Computer";
                        }
                        else
                        {
                            lbTernPlayer.Text = Player2Name;
                        }

                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        btn.BackgroundImage = Resources.X2;
                        PlayerTurn = enPlayer.Player2;
                        btn.Enabled = false;

                        if (CheckWinner())
                            EndGme();

                        break;

                    case enPlayer.Player2:

                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        btn.BackgroundImage = Resources.O2;
                        lbTernPlayer.Text = Player1Name;
                        PlayerTurn = enPlayer.Player1;
                        btn.Enabled = false;

                        if (CheckWinner())
                            EndGme();

                        break;
                }
            }
        }

        void EndGme()
        {
            string Name1 = Player1Name;
            string Name2 = Player2Name;

            if (GameStatus.GameOver)
            {
                if (GameStatus.Winner == enWinner.Player1)
                {
                    lbResult.Text = Name1;
                    lbWin1.Tag = Convert.ToInt32(lbWin1.Tag) + 1;
                    lbWin1.Text = Name1 + " : " + lbWin1.Tag.ToString();
                    MessageBox.Show("Game Win", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (GameStatus.Winner == enWinner.Player2)
                {
                    lbResult.Text = Name2;
                    lbWin2.Tag = Convert.ToInt32(lbWin2.Tag) + 1;
                    lbWin2.Text = Name2 + " : " + lbWin2.Tag.ToString();
                    MessageBox.Show("Game Over", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (GameStatus.Winner == enWinner.Draw)
                {
                    lbResult.Text = "Draw";
                    MessageBox.Show("Draw", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClaculateWins();
                EnabldButton();
            }
        }

        void ClaculateWins()
        {
            if (Convert.ToInt32(lbWin1.Tag) == Convert.ToInt32(lbWin2.Tag))
            {
                lbWinResult.Text = "Draw";
            }
            else if (Convert.ToInt32(lbWin1.Tag) > Convert.ToInt32(lbWin2.Tag))
            {
                lbWinResult.Text = Player1Name;
            }
            else
            {
                lbWinResult.Text = Player2Name;
            }
        }

        void EnabldButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void Dsabld1OneButton(Button btn)
        {
            btn.Enabled = true;
        }

        private void RestButton(Button btn)
        {
            btn.BackgroundImage = Resources.Null2;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
            btn.Enabled = true;
        }

        private void RestartGame()
        {
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button btn in buttons)
            {
                RestButton(btn);
            }

            // ✅ لا نحدد PlayerTurn ولا lbTernPlayer هنا
            // المسؤولية تركناها لـ button10_Click و btnRestartGame_Click
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
            lbWinResult.Text = "Draw";
            lbWin1.Text = Player1Name + " : 0";
            lbWin1.Tag = 0;
            lbWin2.Text = Player2Name + " : 0";
            lbWin2.Tag = 0;
            GameRound = 1;
            lbRound.Text = "Round : " + GameRound.ToString();

            // ✅ Player1 يبدأ دائماً عند إعادة التشغيل الكاملة
            PlayerTurn = enPlayer.Player1;
            lbTernPlayer.Text = Player1Name;
        }

        void RunGame(Button btn)
        {
            if (!PlayWithComputer)
            {
                ChangeRole(btn);
            }
            else
            {
                if (PlayerTurn == enPlayer.Player1)
                {
                    ChangeRole(btn);

                    if (!CheckWinner())
                    {
                        Button computerBtn = ChangeLevelWithComputer();
                        if (computerBtn != null)
                        {
                            ChangeRole(computerBtn);
                        }
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton != null)
            {
                RunGame(clickedButton);
            }
        }

        private void lbWinResult_Click(object sender, EventArgs e)
        {
        }

        private void lbPlayer_Click(object sender, EventArgs e)
        {
        }

        private void lbResult_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ++GameRound;
            lbRound.Text = "Round : " + GameRound.ToString();

            RestartGame();

            if (PlayWithComputer)
            {
                if (GameRound % 2 == 0)
                {
                    // ✅ الجولة زوجية → الكمبيوتر يبدأ
                    PlayerTurn = enPlayer.Player2;
                    lbTernPlayer.Text = Player2Name;

                    Button computerBtn = ChangeLevelWithComputer();
                    if (computerBtn != null)
                        ChangeRole(computerBtn);

                    CheckWinner();
                    return;
                }
                else
                {
                    // ✅ الجولة فردية → Player1 يبدأ
                    PlayerTurn = enPlayer.Player1;
                    lbTernPlayer.Text = Player1Name;
                }
            }
            else
            {
                // ✅ مع صديق: الجولة الزوجية → Player2 يبدأ
                if (GameRound % 2 == 0)
                {
                    PlayerTurn = enPlayer.Player2;
                    lbTernPlayer.Text = Player2Name;
                }
                else
                {
                    PlayerTurn = enPlayer.Player1;
                    lbTernPlayer.Text = Player1Name;
                }
            }
        }

        private void lbWin1_Click(object sender, EventArgs e)
        {
        }

        private void lbWin2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
