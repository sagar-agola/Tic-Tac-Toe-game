using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_App
{
    public partial class TicTacToe : Form
    {
        public Board board;
        public int turn = 0;
        public String Winner = "n";
        public String [,] initBoard = new String [3, 3]
        {
            {" ", " ", " " }, {" ", " ", " "}, {" ", " ", " "}
        };

        String player1Name = IGN.p1;
        String player2Name = IGN.p2;

        public TicTacToe()
        {
            InitializeComponent ();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Board (initBoard);
            lblPlayerOneName.Text += " " + IGN.p1;
            lblPlayerTwoName.Text += " " + IGN.p2;
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (String.IsNullOrEmpty (button.Text))
            {
                if (turn % 2 == 0)
                {
                    button.Text = "O";
                    button.ForeColor = Color.Green;
                    lblTurn.Text = IGN.p2 + "'s turn..."; 
                }
                else
                {
                    button.Text = "X";
                    button.ForeColor = Color.Red;
                    lblTurn.Text = IGN.p1 + "'s turn...";
                }
                turn++;
                lblNumberOfMoves.Text = "Move Count : " + turn;
                PrintWinner ();
            }
        }
        public void FillBoard()
        {
            String [,] ourBoard = new String [3, 3]
            {
                {Btn11.Text, Btn12.Text, Btn13.Text },
                {Btn21.Text, Btn22.Text, Btn23.Text},
                {Btn31.Text, Btn32.Text, Btn33.Text}
            };
            if (board.CheckWinner (ourBoard) == 'o')
                Winner = player1Name;
            else if (board.CheckWinner (ourBoard) == 'x')
                Winner = player2Name;
        }
        private void PrintWinner()
        {
            FillBoard ();
            if (Winner != "n")
            {
                DialogResult userAnswer = MessageBox.Show (Winner + " Won this Round!" + Environment.NewLine + "Would you like to play again?"
                    , "Game Over", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (userAnswer == DialogResult.Yes)
                    NewGame ();
                else if (userAnswer == DialogResult.No)
                    Application.Exit ();
                else
                    DisableAllButtons ();
            }
            else if(turn == 9 && Winner == "n")
            {
                DialogResult userAnswer = MessageBox.Show ("Both Player are equal" + Environment.NewLine + "Would you like to play again?", "Game Over"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (userAnswer == DialogResult.Yes)
                    NewGame ();
                else if (userAnswer == DialogResult.No)
                    Application.Exit ();
                else
                    DisableAllButtons ();
            }
        }
        private void DisableAllButtons()
        {
            Btn11.Enabled = false;
            Btn12.Enabled = false;
            Btn13.Enabled = false;
            Btn21.Enabled = false;
            Btn22.Enabled = false;
            Btn23.Enabled = false;
            Btn31.Enabled = false;
            Btn32.Enabled = false;
            Btn33.Enabled = false;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) => NewGame ();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit ();
        private void restartToolStripMenuItem_Click(object sender, EventArgs e) => Application.Restart ();
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Created by N3o" + Environment.NewLine + " Have fun...", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void NewGame()
        {
            turn = 0;
            Winner = "n";

            Btn11.Text = String.Empty;
            Btn12.Text = String.Empty;
            Btn13.Text = String.Empty;
            Btn21.Text = String.Empty;
            Btn22.Text = String.Empty;
            Btn23.Text = String.Empty;
            Btn31.Text = String.Empty;
            Btn32.Text = String.Empty;
            Btn33.Text = String.Empty;

            Btn11.Enabled = true;
            Btn12.Enabled = true;
            Btn13.Enabled = true;
            Btn21.Enabled = true;
            Btn22.Enabled = true;
            Btn23.Enabled = true;
            Btn31.Enabled = true;
            Btn32.Enabled = true;
            Btn33.Enabled = true;

            lblNumberOfMoves.Text = "Move Count : 0";
            lblTurn.Text = IGN.p1 + "'s turn...";
        }
    }
}
