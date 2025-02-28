// Author: Cameron Anderer
// Class: CIS162AD
// Section: 28370
// Assignment: Chapter 7 Tic Tac Toe
// Submission Date: 10/24/22
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
        public Form1()
        {
            InitializeComponent();
        }

        //Declare a 3x3 char array called ticTacToe

        // this is my two dimensional char array
        char[,] ticTacToe = new char[3, 3];

        char playerTurn = 'X';

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {            
            Array.Clear(ticTacToe, 0, 9);
            r1c1.Text = "";
            r1c2.Text = "";
            r1c3.Text = "";
            r2c1.Text = "";
            r2c2.Text = "";
            r2c3.Text = "";
            r3c1.Text = "";
            r3c2.Text = "";
            r3c3.Text = "";
            lblResult.Text = "Player X's turn";
            playerTurn = 'X';
        }

        
        // Im giving an array value to each text name
        private void displayArray()
        {
            r1c1.Text = ticTacToe[0, 0].ToString();
            r1c2.Text = ticTacToe[0, 1].ToString();
            r1c3.Text = ticTacToe[0, 2].ToString();
            r2c1.Text = ticTacToe[1, 0].ToString();
            r2c2.Text = ticTacToe[1, 1].ToString();
            r2c3.Text = ticTacToe[1, 2].ToString();
            r3c1.Text = ticTacToe[2, 0].ToString();
            r3c2.Text = ticTacToe[2, 1].ToString();
            r3c3.Text = ticTacToe[2, 2].ToString();
            //Add six more lines of code to output the correct array value into the correct label.
            //I've already done Row 1 for you.  You need to complete rows 2 and 3.
        }
        // This code checks if my X or O won the game and is implemented after every turn
        private void checkForWin()
        {
            if(((ticTacToe[0, 0] == 'X') && (ticTacToe[0, 1] == 'X') && (ticTacToe[0, 2] == 'X')) ||
            ((ticTacToe[1, 0] == 'X') && (ticTacToe[1, 1] == 'X') && (ticTacToe[1, 2] == 'X')) ||
            ((ticTacToe[2, 0] == 'X') && (ticTacToe[2, 1] == 'X') && (ticTacToe[2, 2] == 'X')) ||
            ((ticTacToe[0, 0] == 'X') && (ticTacToe[1, 0] == 'X') && (ticTacToe[2, 0] == 'X')) ||
            ((ticTacToe[0, 1] == 'X') && (ticTacToe[1, 1] == 'X') && (ticTacToe[2, 1] == 'X')) ||
            ((ticTacToe[0, 2] == 'X') && (ticTacToe[1, 2] == 'X') && (ticTacToe[2, 2] == 'X')) ||
            ((ticTacToe[0, 0] == 'X') && (ticTacToe[1, 1] == 'X') && (ticTacToe[2, 2] == 'X')) ||
            ((ticTacToe[2, 0] == 'X') && (ticTacToe[1, 1] == 'X') && (ticTacToe[0, 2] == 'X')) 
            //Add five more lines of code to validate for a Team X vidtory in column 1, column 2, column 3, 
            //diagonal top left to bottom right, and diagonal top right to bottom left
            )
            {
                lblResult.Text = "X wins!";
                btnNewGame.Enabled = true;                
            }

            else if (  /*copy the code from the above if statement, and modify it to validate for an O victory*/
                ((ticTacToe[0, 0] == 'O') && (ticTacToe[0, 1] == 'O') && (ticTacToe[0, 2] == 'O')) ||
            ((ticTacToe[1, 0] == 'O') && (ticTacToe[1, 1] == 'O') && (ticTacToe[1, 2] == 'O')) ||
            ((ticTacToe[2, 0] == 'O') && (ticTacToe[2, 1] == 'O') && (ticTacToe[2, 2] == 'O')) ||
            ((ticTacToe[0, 0] == 'O') && (ticTacToe[1, 0] == 'O') && (ticTacToe[2, 0] == 'O')) ||
            ((ticTacToe[0, 1] == 'O') && (ticTacToe[1, 1] == 'O') && (ticTacToe[2, 1] == 'O')) ||
            ((ticTacToe[0, 2] == 'O') && (ticTacToe[1, 2] == 'O') && (ticTacToe[2, 2] == 'O')) ||
            ((ticTacToe[0, 0] == 'O') && (ticTacToe[1, 1] == 'O') && (ticTacToe[2, 2] == 'O')) ||
            ((ticTacToe[2, 0] == 'O') && (ticTacToe[1, 1] == 'O') && (ticTacToe[0, 2] == 'O'))
                )
            {
                lblResult.Text = "O wins!";
                btnNewGame.Enabled = true;
            }
            // I made the 3 lines that validate if the box has the letter
            else if (((ticTacToe[0, 0] == 'X') || (ticTacToe[0, 0] == 'O')) &&
            ((ticTacToe[0, 1] == 'X') || (ticTacToe[0, 1] == 'O')) &&
            ((ticTacToe[0, 2] == 'X') || (ticTacToe[0, 2] == 'O')) &&
            ((ticTacToe[1, 0] == 'X') || (ticTacToe[1, 0] == 'O')) &&
            ((ticTacToe[1, 1] == 'X') || (ticTacToe[1, 1] == 'O')) &&
            ((ticTacToe[1, 2] == 'X') || (ticTacToe[1, 2] == 'O')) &&
            ((ticTacToe[2, 0] == 'X') || (ticTacToe[2, 0] == 'O')) &&
            ((ticTacToe[2, 1] == 'X') || (ticTacToe[2, 1] == 'O')) &&
            ((ticTacToe[2, 2] == 'X') || (ticTacToe[2, 2] == 'O')) 
            //Add three more lines of code to validate whether each of 
            //the three boxes in the bottom row have either 'X' or 'O' in it
            )
            {
                lblResult.Text = "Tie game!";
                btnNewGame.Enabled = true;
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            clear();
            btnNewGame.Enabled = false;
        }
        // This is where I tell my code which letter to enter in the box after its been clicked
        private void r1c1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 'X')
            {
                ticTacToe[0, 0] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[0, 0] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r1c2_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[0, 1] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[0, 1] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r1c3_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[0, 2] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[0, 2] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r2c1_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[1, 0] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[1, 0] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r2c2_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[1, 1] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[1, 1] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r2c3_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[0, 0] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[1, 2] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r3c1_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[2, 0] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[2, 0] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r3c2_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[2, 1] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[2, 1] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }

        private void r3c3_Click(object sender, EventArgs e)
        {
            //program this method
            if (playerTurn == 'X')
            {
                ticTacToe[2, 2] = 'X';
                lblResult.Text = "Player O's turn";
                playerTurn = 'O';
            }
            else if (playerTurn == 'O')
            {
                ticTacToe[2, 2] = 'O';
                lblResult.Text = "Player X's turn";
                playerTurn = 'X';
            }

            displayArray();
            checkForWin();
        }
    }
}
