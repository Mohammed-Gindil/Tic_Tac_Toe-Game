using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_ToeProject.Properties;

namespace Tic_Tac_ToeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        stGameStatus GameStatus;

        enPalyer PlayerTurn = enPalyer.Player1;
        enum enPalyer
        {
            Player1, player2
        }

        enum enWinner
        {
            player1,
            palyer2,
            Drow,
            Inprogres
        }

        struct stGameStatus
        {
            public enWinner winner;
            public short PlayCounte;
            public bool GameOver;

        }


        public void EndGame()
        {
            lblWhoTurn.Text = "Game Over";

            switch (GameStatus.winner)
            {
                case enWinner.player1:
                    lblWhoWin.Text = "Player 1";
                    break;
                case enWinner.palyer2:
                    lblWhoWin.Text = "player 2";
                    break;
                default:
                    lblWhoWin.Text = "Drow";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool CheckValue(Button bttn1,Button bttn2,Button bttn3)
        {
            if (bttn1.Tag.ToString()!="?"&&bttn1.Tag.ToString()==bttn2.Tag.ToString()&&bttn1.Tag.ToString()==bttn3.Tag.ToString())
            {
                bttn1.BackColor = Color.GreenYellow;
                bttn2.BackColor = Color.GreenYellow;
                bttn3.BackColor = Color.GreenYellow;

                if (bttn1.Tag.ToString()=="X")
                {
                    GameStatus.winner = enWinner.player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.winner = enWinner.palyer2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver =false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValue(btn1,btn2,btn3))
              return;
            if (CheckValue(btn4,btn5,btn6))
              return;
            if (CheckValue(btn7,btn8,btn9))
              return;
            if (CheckValue(btn1,btn4,btn7))
              return;
            if (CheckValue(btn2,btn5,btn8))
              return;
            if (CheckValue(btn3,btn6,btn9))
              return;
            if (CheckValue(btn1,btn5,btn9))
              return;
            if (CheckValue(btn3,btn5,btn7))
              return;

        }

        public void ChangeImage(Button bttn)
        {
            if (bttn.Tag.ToString()=="?")
            {
                switch (PlayerTurn)
                {
                    case enPalyer.Player1:
                        bttn.Image = Properties.Resources.X;
                        PlayerTurn = enPalyer.player2;
                        lblWhoTurn.Text = "player 2";
                        bttn.Tag = "X";
                        GameStatus.PlayCounte++;
                        CheckWinner();
                        break;
                    case enPalyer.player2:
                        bttn.Image = Properties.Resources.O;
                        PlayerTurn = enPalyer.Player1;
                        lblWhoTurn.Text = "player 1";
                        bttn.Tag = "O";
                        GameStatus.PlayCounte++;
                        CheckWinner();
                        break;
                }

            }
            else
            {
                MessageBox.Show("you cant play this ","Game",MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

            if (GameStatus.PlayCounte == 9)
            {
                GameStatus.winner = enWinner.Drow;
                GameStatus.GameOver = true;
                EndGame();
            }
        }

        void ResetButton(Button bttnNum)
        {
            bttnNum.Image = Resources.question_mark_96; ;
            bttnNum.Tag = "?";
            bttnNum.BackColor = Color.Transparent;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Pain(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen pen = new Pen(Color.White);//Pen(color,Width)
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 550, 77, 550, 384);
            e.Graphics.DrawLine(pen, 440, 77, 440, 384);
            e.Graphics.DrawLine(pen, 350, 179, 640, 179);
            e.Graphics.DrawLine(pen, 350, 281, 640, 281);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void RestartGame()
        {
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);

            PlayerTurn = enPalyer.Player1;
            lblWhoTurn.Text = "player 1";

            GameStatus.winner = enWinner.Inprogres;
            GameStatus.PlayCounte = 0;
            GameStatus.GameOver =false;
            lblWhoWin.Text = "in proggres";
        }
        private void Reset_Game_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void lblWhoWin_Click(object sender, EventArgs e)
        {

        }
    }
}
