using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        // here we define variables
        int xWins = 0;
        int yWins = 0;
        int d = 0;
        Button[] _grid = new Button[9];
     
        public Form1()
        {
            InitializeComponent();
        }

       //Here the form will be loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                _grid[i] = new Button
                {
                    Width = 100,
                    Height = 100
                };
                _grid[i].Click += new EventHandler(Form1_Click);
                
                flowLayoutPanel1.Controls.Add(_grid[i]);
            }

        }

        int flag = 0;
        int draw = 0;
        /// <summary>
        /// Reset is the method to clear the board.
        /// </summary>
        void Reset()
        {
            for (int i = 0; i < 9; i++)
            {
                _grid[i].Enabled = true;
                _grid[i].Text = "";
                draw = 0;
            }
        }

        void Form1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (flag == 0)
            {
                bt.Text = "X";
                label10.Text = "O";
                flag = 1;
            }
            else
            {
                bt.Text = "O";
                label10.Text = "X";
                flag = 0;
            }
            bt.Enabled = false;

            draw++;

            //call check funtion for conditions
            Check();
            if (draw == 9)
            {
                MessageBox.Show("Game Draw");
                d++;
                label6.Text = d.ToString();
                Reset();
            }
        }

        void Check() // This method will check certain conditions
        {
            #region Rows
            //For Rows
            if (_grid[0].Text == _grid[1].Text && _grid[1].Text == _grid[2].Text && _grid[0].Text != "")
            {
                MessageBox.Show(_grid[0].Text + " Wins");
                if (_grid[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }

                Reset();
            }
            else if (_grid[3].Text == _grid[4].Text && _grid[4].Text == _grid[5].Text && _grid[3].Text != "")
            {
                MessageBox.Show(_grid[3].Text + " Wins");
                if (_grid[3].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            else if (_grid[6].Text == _grid[7].Text && _grid[7].Text == _grid[8].Text && _grid[6].Text != "")
            {
                MessageBox.Show(_grid[6].Text + " Wins");
                if (_grid[6].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            #endregion

            #region Columns
            //For Columns
            else if (_grid[0].Text == _grid[3].Text && _grid[3].Text == _grid[6].Text && _grid[0].Text != "")
            {
                MessageBox.Show(_grid[0].Text + " Wins");
                if (_grid[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            else if (_grid[1].Text == _grid[4].Text && _grid[4].Text == _grid[7].Text && _grid[1].Text != "")
            {
                MessageBox.Show(_grid[1].Text + " Wins");
                if (_grid[1].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            else if (_grid[2].Text == _grid[5].Text && _grid[5].Text == _grid[8].Text && _grid[2].Text != "")
            {
                MessageBox.Show(_grid[2].Text + " Wins");
                if (_grid[2].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            #endregion

            #region Diagonals
            //For Diagonals
            else if (_grid[0].Text == _grid[4].Text && _grid[4].Text == _grid[8].Text && _grid[0].Text != "")
            {
                MessageBox.Show(_grid[0].Text + " Wins");
                if (_grid[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            else
            {
                MessageBox.Show(_grid[2].Text + " Wins");
                if (_grid[2].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                Reset();
            }
            #endregion
        }
    }

}
