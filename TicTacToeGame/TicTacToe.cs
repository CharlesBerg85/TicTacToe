using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace TicTacToeGame
    {
        public partial class TicTacToe : UserControl
        {
            string[] gameBoard = new string[9];
            int currentTurn = 0;

            public TicTacToe()
            {
                InitializeComponent();
            }

            public string ReturnSymbol(int turn)
            {
                return turn % 2 == 0 ? "O" : "X";
            }
            
            public System.Drawing.Color determineColor(String symbol)
            { 
                if(symbol.Equals("O"))
                {
                    return System.Drawing.Color.DarkGreen;
                }
                else
                {
                    return System.Drawing.Color.OrangeRed;
                }
            }

            public void CheckForWinner()
            {
                //this will loop through the game board pieces and check what Symbole is 
                //inside the box/button and then calculate wether or not a win has happened
                for (int i = 0; i < 8; i++)
                {
                    string combination = "";

                    switch (i)
                    {
                        case 0:
                            combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                            break;
                        case 1:
                            combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                            break;
                        case 2:
                            combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                            break;
                        case 3:
                            combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                            break;
                        case 4:
                            combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                            break;
                        case 5:
                            combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                            break;
                        case 6:
                            combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                            break;
                        case 7:
                            combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                            break;
                    }

                    if (combination == "OOO")
                    {
                        Reset();
                        MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (combination == "XXX")
                    {
                        Reset();
                        MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        CheckForDraw();
                    }
                }
            }

            public void Reset()
            {
                button1.Text = " ";
                button2.Text = " ";
                button3.Text = " ";
                button4.Text = " ";
                button5.Text = " ";
                button6.Text = " ";
                button7.Text = " ";
                button8.Text = " ";
                gameBoard = new string[9];
                currentTurn = 0;
            }

            public void CheckForDraw()
            {
                int counter = 0;
                for (int i = 0; i < gameBoard.Length; i++)
                {
                    if (gameBoard[i] != null)
                    {
                        counter++;
                    }
                    if (counter == 9)
                    {
                        Reset();
                        MessageBox.Show("That's a draw!", "No winner today!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[0] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[1] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }
            private void button3_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[2] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[3] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[4] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button6_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[5] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[6] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button8_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[7] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                currentTurn++;
                Button button = (Button)sender;
                gameBoard[8] = ReturnSymbol(currentTurn);
                button.Text = ReturnSymbol(currentTurn);
                button.Enabled = false;
                button.BackColor = determineColor(ReturnSymbol(currentTurn));
                CheckForWinner();
            }
        }
    }
