using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe_App
{
    public partial class IGN : Form
    {
        public static String p1;
        public static String p2;
        public IGN()
        {
            InitializeComponent ();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            p1 = txtPlayer1Name.Text;
            p2 = txtPlayerTwoName.Text;

            TicTacToe ticTacToe = new TicTacToe ();
            ticTacToe.Show ();
            this.Hide ();
        }
    }
}
