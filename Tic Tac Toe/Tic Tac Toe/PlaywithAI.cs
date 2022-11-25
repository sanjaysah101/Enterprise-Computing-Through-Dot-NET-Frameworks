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
    public partial class PlaywithAI : Form
    {
        public enum Player
        {
            X, O, N
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        static Player[] filledPos = { Player.N, Player.N, Player.N, Player.N, Player.N, Player.N, Player.N, Player.N, Player.N };


        static char huPlayer = 'X';
        static char aiPlayer = 'O';
        static bool isGameActive = false;
        public PlaywithAI()
        {
            InitializeComponent();
            startGame();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_click(Button button)
        {

            currentPlayer = Player.X;
            int index = Convert.ToInt32(button.Name[6] - '0');

            button.Text = currentPlayer.ToString();

            button.Enabled = false;
            filledPos[index - 1] = currentPlayer;
            button.BackColor = Color.DarkOrange;
            buttons.Remove(button);
            Check();
            CPUTimer.Start();
        }




        private void startGame()
        {
            clearBoard();
            //            int[] filledPos = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            RestartGame();
            isGameActive = true;
            currentPlayer = Player.X;
            foreach (Button button in buttons)
            {
                button.Click += (sender, args) =>
                {

                    btn_click(button);
                };
            }
            //if(currentPlayer == Player.X)
            //{
            //}
            //else if(currentPlayer == Player.O)
            //{
            //    CPUTimer.Start();
            //    //if (buttons.Count > 0)
            //    //{
            //    //    int index = random.Next(buttons.Count);
            //    //    buttons[index].Enabled = false;
            //    //    currentPlayer = Player.O;
            //    //    filledPos[index] = currentPlayer;
            //    //    buttons[index].Text = currentPlayer.ToString();
            //    //    buttons[index].BackColor = Color.BurlyWood;
            //    //    buttons.RemoveAt(index);
            //    //    CheckWinner();
            //    //    CPUTimer.Stop();
            //    //}


            //}

        }
        private void clearBoard()
        {
            //count = 0;
            //winner = 'N';
            //for (int i = 0; i < filledPos.Length; i++)
            //{
            //    filledPos[i] = 'N';
            //}

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            //isGameActive = true;
        }


        //Easy Level
        //private void CPUMove(object sender, EventArgs e)
        //{
        //    if(buttons.Count > 0)
        //    {
        //        int index = random.Next(buttons.Count);
        //        buttons[index].Enabled = false;
        //        currentPlayer = Player.O;
        //        filledPos[index] = currentPlayer;
        //        buttons[index].Text = currentPlayer.ToString();
        //        buttons[index].BackColor = Color.BurlyWood;
        //        buttons.RemoveAt(index);
        //        Check();
        //        CPUTimer.Stop();
        //    }
        //}

        //Diffecult Level
        private void CPUMove(object sender, EventArgs e)
        {

            if (buttons.Count > 0)
            {
                currentPlayer = Player.O;
                int index = bestSpot(currentPlayer);
                buttons[index].Enabled = false;
                filledPos[index] = currentPlayer;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.BurlyWood;
                buttons.RemoveAt(index);
                Check();
                CPUTimer.Stop();
            }
        }

        private void newGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Check()
        {
            //in this function we will check if the player or the AI has won
            // we have two very large if statements with the winning possibilities
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // if any of the above conditions are met
                CPUTimer.Stop(); //stop the timer
                MessageBox.Show("Player Wins"); // show a message to the player
                playerWinCount++; // increase the player wins 
                label1.Text = "Player Wins: " + playerWinCount; // update player label
                RestartGame(); // run the reset game function
            }
            // below if statement is for when the AI wins the game
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {

                // if any of the conditions are met above then we will do the following
                // this code will run when the AI wins the game
                CPUTimer.Stop(); // stop the timer
                MessageBox.Show("Computer Wins"); // show a message box to say computer won
                CPUWinCount++; // increase the computer wins score number
                label2.Text = "BOT Wins: " + CPUWinCount; // update the label 2 for computer wins
                RestartGame(); // run the reset game
            }
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = Color.OrangeRed;
            }
        }

        private int bestSpot(Player player)
        {

            return miniMax(buttons, player);
        }

        private int miniMax(List<Button> boards, Player player)
        {
            foreach (var button in buttons)
            {
            }
            return random.Next(buttons.Count);
        }
    }
}
