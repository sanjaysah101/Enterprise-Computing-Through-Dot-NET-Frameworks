using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        static char player1 = 'O'; 
        static char player2 = 'X'; 
        static char activerPlayer = player1;
        static int count = 0;
        static char winner = 'N';
        static char[] filledPos = { 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N' };
        static bool isGameActive = false;
        int player1_score = 0;
        int player2_score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            labelTurn.Text = "Player 1 - O";
            labelPlayer1Score.Text = "Player 1: " + player1_score;
            labelPlayer2Score.Text = "Player 2: " + player2_score;
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

                    
        }
        private void btnClick(object sender, EventArgs e)
        {

            if (!isGameActive)
                return;
            
            Button button = (Button) sender;
            if (button.Text.Equals(""))
            {

                //int lastIndex = (int)button.Name[6];
                int lastIndex = Convert.ToInt32(button.Name[6] - '0'); // This will convert char to its ascii value
                
                filledPos[lastIndex-1] = activerPlayer;
                //MessageBox.Show(""+lastIndex);
                /*int lastIndex = button.Name.Length -1 ;
                int lastIndex = button.Name.Length -1 ;
                filledPos[lastIndex - 1] = activerPlayer;
                */
                //MessageBox.Show(""+(lastIndex -1) +" " + filledPos[lastIndex-1]);
                /*foreach(char c in filledPos)
                {

                    MessageBox.Show("" + c);
                }*/

                count++;
                if(activerPlayer == player1)
                {
                    button.Text = char.ToString(player1);
                    labelTurn.Text = "Player 2 - X";
                    activerPlayer = player2;
                }
                else
                {
                    button.Text = char.ToString(player2);
                    labelTurn.Text = "Player 1 - O";
                    activerPlayer = player1;
                }
            }
            if(count > 4)
            {
                /*foreach (char c in filledPos)
                {
                    MessageBox.Show("" + c);
                }*/
                winner = checkWinner();
                //MessageBox.Show(Char.ToString(winner));
                if(winner == player1)
                {
                    player1_score++;
                    labelPlayer1Score.Text = "Player 1: " + player1_score;
                    MessageBox.Show(player1 + " is winner");
                }else if(winner == player2)
                {
                    player2_score++;
                    labelPlayer2Score.Text = "Player 2: " + player2_score;
                    MessageBox.Show(player2 + " is winner");

                }else if(count == 9 && winner == 'N')
                {
                    MessageBox.Show("Game Draw");
                }
            }
            
            
        }

        private static char checkWinner()
        {
            int[,] winningPosition = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < winningPosition.GetLength(0); i++)
            {
                int val0 = winningPosition[i, 0];
                int val1 = winningPosition[i, 1];
                int val2 = winningPosition[i, 2];


                if (filledPos[val0] == filledPos[val1] && filledPos[val1] == filledPos[val2] && filledPos[val0] != 'N')
                {
                    isGameActive = false;
                    if (filledPos[val0] == player1)
                    {
                        return player1;
                    }
                    else
                        return player2;
                }
            }
            return 'N';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1 = 'O';
            player2 = 'X';
            activerPlayer = player1;       
            player1_score = 0;
            player2_score = 0;
            labelTurn.Text = "Player 1 - "+activerPlayer;          


            labelPlayer1Score.Text = "Player 1: " + player1_score;
            labelPlayer2Score.Text = "Player 2: " + player2_score;
            clearBoard();

        }
        private void clearBoard()
        {
            count = 0;
            winner = 'N';
            for(int i = 0; i < filledPos.Length; i++)
            {
                filledPos[i] = 'N';
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            isGameActive = true;
        }

        private void continueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(player1_score > 0 || player1_score > 0)
            {
                activerPlayer = winner;
            }
            labelTurn.Text = "Player 1 - " + activerPlayer;
            clearBoard();
            isGameActive = true;
        }

        private void toolStripMenuItemPlayWithAI_Click(object sender, EventArgs e)
        {
            PlaywithAI playwithAI = new PlaywithAI();
            playwithAI.Show();
        }
    }
}
