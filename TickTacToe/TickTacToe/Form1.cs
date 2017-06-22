using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TickTacToe
{
    public partial class Form1 : Form
    {
        //bool value for turns true players(X) turn false computer turn(O)
        private bool turn = true;
        private int turn_count = 0;
        private bool Winner = false;
        bool Against_Computer;

        public Form1()
        {
            InitializeComponent();
            if (MessageBox.Show("Do you want to play against computer?", "Computer Player", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Against_Computer = true;
            }
            else
            {
                Against_Computer = false;
            }
        }

        private void CheckForWinner()
        {

#region Check win conditions
            if ((BTNA1.Text == BTNA2.Text) && (BTNA2.Text == BTNA3.Text) && (!BTNA1.Enabled))
            {
                Winner = true;
            }
            else if ((BTNB1.Text == BTNB2.Text) && (BTNB2.Text == BTNB3.Text) && (!BTNB1.Enabled))
            {
                Winner = true;
            }
            else if ((BTNC1.Text == BTNC2.Text) && (BTNC2.Text == BTNC3.Text) && (!BTNC1.Enabled))
            {
                Winner = true;
            }
            else if ((BTNA1.Text == BTNB1.Text) && (BTNB1.Text == BTNC1.Text) && (!BTNA1.Enabled))
            {
                Winner = true;
            }
            else if ((BTNA2.Text == BTNB2.Text) && (BTNB2.Text == BTNC2.Text) && (!BTNA2.Enabled))
            {
                Winner = true;
            }
            else if ((BTNA3.Text == BTNB3.Text) && (BTNB3.Text == BTNC3.Text) && (!BTNA3.Enabled))
            {
                Winner = true;
            }
            else if ((BTNA1.Text == BTNB2.Text) && (BTNB2.Text == BTNC3.Text) && (!BTNA1.Enabled))
            {
                Winner = true;
            }
            else if ((BTNA3.Text == BTNB2.Text) && (BTNB2.Text == BTNC1.Text) && (!BTNA3.Enabled))
            {
                Winner = true;
            }
            else
            {
                Winner = false;
            }
#endregion


            if (Winner == true)
            {
                string WhoIsWinner = "";
                if (turn)
                {
                    WhoIsWinner = "Player : O";
                }
                else
                {
                    WhoIsWinner = "Player : X";
                }

                MessageBox.Show(WhoIsWinner + "Wins!");
                if (MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

            if (turn_count == 8 && Winner != true )
            {
                MessageBox.Show("Draw!");
                //turn_count = 0;
            }
        }

        private void PlaySound()
        {
            WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();
            wmplayer.URL = "Punch.mp3";
            wmplayer.controls.play();
        }


#region Tool strip menu items
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a basic Tic Tac Toe game with a sountrack and option to play with two human players or against a Computer.Devloper: William D Scholtz  Special Thanks to Chris Merritt TickTacToe youtube video");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        #endregion
#region Button events
        private void BTNClicked(object sender, EventArgs e)
        {         
            Button b = (Button)sender;
            Winner = false;
            //Changes the turn between x and o
            if (turn)
            {
                b.Text = "X";
                b.BackColor = Color.Aqua;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.Red;
            }

            //Changes the turn
            turn = !turn;
            //disable button so i cant be used again
            b.Enabled = false;
            //check if the is a winner
            CheckForWinner();
            PlaySound();
            turn_count++;

            //
            if ((!turn) && (Against_Computer == true))
            {
                ComputerMove();
            }


        }
        private void BTN_Enter(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (b.Enabled)
            {
                b.BackColor = Color.Cornsilk;
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void BTN_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.BackColor = Color.LightGray;
                b.Text = "";
            }
        }
        #endregion

#region AI methods
        private void ComputerMove()
        {
            //Rule 1 get tictac
            //Rule 2 block x ticktax
            //rule 3 go for coner spaces
            //rule 4 pick open space

            Button move = null;

            //look for tictac
            move = look_for_win_or_block("O");//move to win

            if (move == null)
            {
                move = look_for_win_or_block("X");//move to block
                if (move == null)
                {
                    move = look_for_coner();
                    if (move == null)
                    {
                        move = look_for_open();
                    }
                }

            }

            move.PerformClick();
        
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((BTNA1.Text == mark) && (BTNA2.Text == mark) && (BTNA3.Text == ""))
                return BTNA3;
            if ((BTNA2.Text == mark) && (BTNA3.Text == mark) && (BTNA1.Text == ""))
                return BTNA1;
            if ((BTNA1.Text == mark) && (BTNA3.Text == mark) && (BTNA2.Text == ""))
                return BTNA2;

            if ((BTNB1.Text == mark) && (BTNB2.Text == mark) && (BTNB3.Text == ""))
                return BTNB3;
            if ((BTNB2.Text == mark) && (BTNB3.Text == mark) && (BTNB1.Text == ""))
                return BTNB1;
            if ((BTNB1.Text == mark) && (BTNB3.Text == mark) && (BTNB2.Text == ""))
                return BTNB2;

            if ((BTNC1.Text == mark) && (BTNC2.Text == mark) && (BTNC3.Text == ""))
                return BTNC3;
            if ((BTNC2.Text == mark) && (BTNC3.Text == mark) && (BTNC1.Text == ""))
                return BTNC1;
            if ((BTNC1.Text == mark) && (BTNC3.Text == mark) && (BTNC2.Text == ""))
                return BTNC2;

            //VERTICAL TESTS
            if ((BTNA1.Text == mark) && (BTNB1.Text == mark) && (BTNC1.Text == ""))
                return BTNC1;
            if ((BTNB1.Text == mark) && (BTNC1.Text == mark) && (BTNA1.Text == ""))
                return BTNA1;
            if ((BTNA1.Text == mark) && (BTNC1.Text == mark) && (BTNB1.Text == ""))
                return BTNB1;

            if ((BTNA2.Text == mark) && (BTNB2.Text == mark) && (BTNC2.Text == ""))
                return BTNC2;
            if ((BTNB2.Text == mark) && (BTNC2.Text == mark) && (BTNA2.Text == ""))
                return BTNA2;
            if ((BTNA2.Text == mark) && (BTNC2.Text == mark) && (BTNB2.Text == ""))
                return BTNB2;

            if ((BTNA3.Text == mark) && (BTNB3.Text == mark) && (BTNC3.Text == ""))
                return BTNC3;
            if ((BTNB3.Text == mark) && (BTNC3.Text == mark) && (BTNA3.Text == ""))
                return BTNA3;
            if ((BTNA3.Text == mark) && (BTNC3.Text == mark) && (BTNB3.Text == ""))
                return BTNB3;

            //DIAGONAL TESTS
            if ((BTNA1.Text == mark) && (BTNB2.Text == mark) && (BTNC3.Text == ""))
                return BTNC3;
            if ((BTNB2.Text == mark) && (BTNC3.Text == mark) && (BTNA1.Text == ""))
                return BTNA1;
            if ((BTNA1.Text == mark) && (BTNC3.Text == mark) && (BTNB2.Text == ""))
                return BTNB2;

            if ((BTNA3.Text == mark) && (BTNB2.Text == mark) && (BTNC1.Text == ""))
                return BTNC1;
            if ((BTNB2.Text == mark) && (BTNC1.Text == mark) && (BTNA3.Text == ""))
                return BTNA3;
            if ((BTNA3.Text == mark) && (BTNC1.Text == mark) && (BTNB2.Text == ""))
                return BTNB2;

            return null;

        }

        private Button look_for_coner()
        {
            Console.WriteLine("Looking for corner");
            if (BTNA1.Text == "O")
            {
                if (BTNA3.Text == "")
                    return BTNA3;
                if (BTNC3.Text == "")
                    return BTNC3;
                if (BTNC1.Text == "")
                    return BTNC1;
            }

            if (BTNA3.Text == "O")
            {
                if (BTNA1.Text == "")
                    return BTNA1;
                if (BTNC3.Text == "")
                    return BTNC3;
                if (BTNC1.Text == "")
                    return BTNC1;
            }

            if (BTNC3.Text == "O")
            {
                if (BTNA1.Text == "")
                    return BTNA3;
                if (BTNA3.Text == "")
                    return BTNA3;
                if (BTNC1.Text == "")
                    return BTNC1;
            }

            if (BTNC1.Text == "O")
            {
                if (BTNA1.Text == "")
                    return BTNA3;
                if (BTNA3.Text == "")
                    return BTNA3;
                if (BTNC3.Text == "")
                    return BTNC3;
            }

            if (BTNA1.Text == "")
                return BTNA1;
            if (BTNA3.Text == "")
                return BTNA3;
            if (BTNC1.Text == "")
                return BTNC1;
            if (BTNC3.Text == "")
                return BTNC3;

            return null;
        }
        private Button look_for_open()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

#endregion
    }
}
