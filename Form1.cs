using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCPT
{
    //Culminating
    //Yashvi Sheth
    //June 17th 2022
    public partial class Form1 : Form
    {
        Wall oWall;
        Color checkColour;
        int counter = 0;
        int brickcount = 0;
        Brick temp;
        int rows;
        int columns;
        int rows1;
        int col1;
        int mouseCount = 0;
        int counter2;
        int moveleft = 0;
        int points = 0;
        int numbricks = 0;
        int singlecount = 0;
        int another = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //create a new wall filled with bricks and shuffle the colours
            oWall = new Wall(16, 16, 20);
            oWall.Shuffle();
            lblEnd.Visible = false;
            //put all values to default
            points = 0;
            lblPoints.Text = "Points: " + points;
            btnStart.Enabled = false;
            pcbWand1.Width = 58;
            pcbWand1.Height = 69;
            pcbWand2.Width = 58;
            pcbWand2.Height = 69;
            pcbWand3.Width = 58;
            pcbWand3.Height = 69;
            pcbWand4.Width = 58;
            pcbWand4.Height = 69;
            pcbWand5.Width = 58;
            pcbWand5.Height = 69;
            pcbWand1.Image = FinalCPT.Properties.Resources.wand_;
            pcbWand2.Image = FinalCPT.Properties.Resources.wand_;
            pcbWand3.Image = FinalCPT.Properties.Resources.wand_;
            pcbWand4.Image = FinalCPT.Properties.Resources.wand_;
            pcbWand5.Image = FinalCPT.Properties.Resources.wand_;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //if resized, everything resizes
            base.OnPaint(e);

            if (oWall != null)
            {
                oWall.Draw(e.Graphics, 140, 50);
            }
        }

        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //make sure you can only click once
            if (mouseCount < 1)
            {
                //map the position of the mouse to the corresponding grid cell
                int cols = (e.X - 140) / 20;
                int row = (e.Y - 50) / 20;
                
                //make sure the click is within bounds of the grid
                if (row < 16 && row > -1 && cols < 16 && cols > -1)
                {
                    //save the colour of the clicked cell and if it is black, make sure nothing happens
                    checkColour = oWall.mWall[row, cols].BackgroundColour;
                    if (oWall.mWall[row, cols].BackgroundColour == Color.Transparent)
                    {
                        row = -1;
                        cols = -1;
                    }
                    
                    //save the numbers to a new variable that won't reset to 0
                    if (checkColour != Color.Green)
                    {
                        //find how many bricks of the same colour are adjacent to the clicked one
                        brickcheck(row, cols);
                        numbricks = brickcount;
                        rows1 = row;
                        col1 = cols;
                        if (brickcount > 1)
                        {
                            this.Refresh();
                            timer1.Start();
                        }
                        //if there are no bricks of the same colour, click a wand which will
                        //allow you to break that brick
                        else if (brickcount == 1)
                        {
                            if (pcbWand1.Image != null && pcbWand1.Visible == false)
                            {
                                brickcheck(row, cols);
                                rows1 = row;
                                col1 = cols;
                                pcbWand1.Image = null;
                                pcbWand1.Visible = true;
                                pcbWand1.Width = 7;
                                pcbWand1.Height = 30;
                            }
                            else if (pcbWand2.Image != null && pcbWand2.Visible == false)
                            {
                                brickcheck(row, cols);
                                rows1 = row;
                                col1 = cols;
                                pcbWand2.Image = null;
                                pcbWand2.Visible = true;
                                pcbWand2.Width = 0;
                                pcbWand2.Height = 0;
                            }
                            else if (pcbWand3.Image != null && pcbWand3.Visible == false)
                            {
                                brickcheck(row, cols);
                                rows1 = row;
                                col1 = cols;
                                pcbWand3.Image = null;
                                pcbWand3.Visible = true;
                                pcbWand3.Width = 0;
                                pcbWand3.Height = 0;
                            }
                            else if (pcbWand4.Image != null && pcbWand4.Visible == false)
                            {
                                brickcheck(row, cols);
                                rows1 = row;
                                col1 = cols;
                                pcbWand4.Image = null;
                                pcbWand4.Visible = true;
                                pcbWand4.Width = 0;
                                pcbWand4.Height = 0;

                            }
                            else if (pcbWand5.Visible == false)
                            {
                                brickcheck(row, cols);
                                rows1 = row;
                                col1 = cols;
                                pcbWand5.Image = null;
                                pcbWand5.Visible = true;
                                pcbWand5.Width = 0;
                                pcbWand5.Height = 0;
                            }
                            //or else nothing happens
                            else
                            {
                                oWall.mWall[row, cols].BackgroundColour = checkColour;
                                row = -1;
                                cols = -1;
                                numbricks = 0;
                            }
                        }
                    }

                    //if the magic tile is pressed the colour which is rigth of it will disappear from the whole grid
                    else
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            for (int j = 0; j < 16; j++)
                            {
                                if (oWall.mWall[i, j].BackgroundColour == Color.Green)
                                {
                                    if(j != 15)
                                    {
                                        checkColour = oWall.mWall[i, j + 1].BackgroundColour;
                                        oWall.mWall[i, j].BackgroundColour = Color.Transparent;
                                        for (int k = 0; k < 16; k++)
                                        {
                                            for (int l = 0; l < 16; l++)
                                            {
                                                brickcheck(k, l);
                                                //save the number of bricks to use to calculate points
                                                numbricks = brickcount;
                                            }
                                        }
                                    }

                                    //if it is not green you find all the bricks adjacent to the clicked one which 
                                    //are the same colour as the clicked one
                                    else
                                    {
                                        oWall.mWall[i, j].BackgroundColour = Color.Transparent;
                                        checkColour = oWall.mWall[i, 0].BackgroundColour;
                                        oWall.mWall[i, 0].BackgroundColour = Color.Transparent;
                                        for (int k = 0; k < 16; k++)
                                        {
                                            for (int l = 0; l < 16; l++)
                                            {
                                                brickcheck(k, l);
                                                numbricks = brickcount;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    this.Refresh();
                    timer1.Start();
                    rows = row;
                    columns = cols;
                    brickcount = 0;
                    //don't allow any clicks until the timer has ended
                    mouseCount = 1;
                    //constantly add points to the last number
                    points += numbricks * 10;
                    lblPoints.Text = "Points: " + points;
                    numbricks = 0;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this code is to make the clicked bricks fall
            timer1.Stop();
            if (columns > -1 && rows > -1 && mouseCount == 1)
            {
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        //create a temp variable and replace the brick it is currently on with the one below it
                        if (oWall.mWall[i, j].BackgroundColour == Color.Transparent)
                        {
                            blackcheck(i, j);
                            temp = oWall.mWall[i, j];
                            oWall.mWall[i, j] = oWall.mWall[i + counter, j];
                            oWall.mWall[i + counter, j] = temp;
                            counter = 0;
                        }
                        else
                        {
                            //just bring everything other colour up
                            for (int k = 0; k < 16; k++)
                            {
                                for (int l = 0; l < 16; l++)
                                {
                                    if (oWall.mWall[k, l].BackgroundColour == checkColour)
                                    {
                                        blackcheck(k, l);
                                        counter = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                this.Refresh();
            }
            //make nothing happen 
            else
            {
                rows1 = -1;
                col1 = -1;
                this.Refresh();
            }
            mouseCount = 0;

            //check to see if there are any columns which are completely black
            //if so, move everything to the left
            for(int k = 0; k < 2; k++)
            {
                for (int p = 0; p < 16; p++)
                {
                    if (oWall.mWall[0, p].BackgroundColour == Color.Transparent)
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            for (int j = p; j + 1 < 16; j++)
                            {
                                temp = oWall.mWall[i, j];
                                oWall.mWall[i, j] = oWall.mWall[i, j + 1];
                                oWall.mWall[i, j + 1] = temp;
                            }
                        }
                    }
                }
            }
            moveleft++;
            this.Refresh();

            //reset the grid if completed or end the game if not
            for (int i = 0; i < 16; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    if (oWall.mWall[i, j].BackgroundColour == Color.Transparent)
                        counter2++;
                    if(counter2 == 256)
                    {
                        oWall = new Wall(16, 16, 20);
                        oWall.Shuffle();
                        this.Refresh();
                    }
                }
            }
            counter2 = 0;

            //checks if there are any more moves that can be done
            //if not let the game be over and change the start button to play again
            if(pcbWand1.Image == null && pcbWand2.Image == null && pcbWand3.Image == null && pcbWand4.Image == null && pcbWand5.Image == null)
            {
                if (oWall.mWall[0, 0].BackgroundColour != Color.Transparent)
                {
                    checkColour = oWall.mWall[0, 0].BackgroundColour;
                    another++;
                    if (oWall.mWall[1, 0].BackgroundColour != checkColour)
                    {
                        if (oWall.mWall[0, 1].BackgroundColour != checkColour)
                            singlecount++;
                    }
                }
                //bottom left corner
                if (oWall.mWall[0, 15].BackgroundColour != Color.Transparent)
                {
                    checkColour = oWall.mWall[0, 15].BackgroundColour;
                    another++;
                    if (oWall.mWall[1, 15].BackgroundColour != checkColour)
                    {
                        if (oWall.mWall[0, 14].BackgroundColour != checkColour)
                            singlecount++;
                    }
                }
                //top right corner
                if (oWall.mWall[15, 0].BackgroundColour != Color.Transparent)
                {
                    checkColour = oWall.mWall[15, 0].BackgroundColour;
                    another++;
                    if (oWall.mWall[14, 0].BackgroundColour != checkColour)
                    {
                        if (oWall.mWall[15, 1].BackgroundColour != checkColour)
                            singlecount++;
                    }
                }
                //bottom right corner
                if (oWall.mWall[15, 15].BackgroundColour != Color.Transparent)
                {
                    checkColour = oWall.mWall[15, 15].BackgroundColour;
                    another++;
                    if (oWall.mWall[14, 15].BackgroundColour != checkColour)
                    {
                        if (oWall.mWall[15, 14].BackgroundColour != checkColour)
                            singlecount++;
                    }
                }
                for(int i = 1; i < 15; i++)
                {
                    //left edge
                    if (oWall.mWall[i, 0].BackgroundColour != Color.Transparent)
                    {
                        checkColour = oWall.mWall[i, 0].BackgroundColour;
                        another++;
                        checkColour = oWall.mWall[i, 0].BackgroundColour;
                        if (oWall.mWall[i, 1].BackgroundColour != checkColour)
                        {
                            if (oWall.mWall[i - 1, 0].BackgroundColour != checkColour)
                            {
                                if (oWall.mWall[i + 1, 0].BackgroundColour != checkColour)
                                    singlecount++;
                            }

                        }
                    }
                }
                for(int i = 1; i < 15; i++)
                {
                    //right edge
                    if (oWall.mWall[i, 15].BackgroundColour != Color.Transparent)
                    {
                        checkColour = oWall.mWall[i, 15].BackgroundColour;
                        another++;
                        checkColour = oWall.mWall[i, 15].BackgroundColour;
                        if (oWall.mWall[i, 14].BackgroundColour != checkColour)
                        {
                            if (oWall.mWall[i - 1, 15].BackgroundColour != checkColour)
                            {
                                if (oWall.mWall[i + 1, 15].BackgroundColour != checkColour)
                                    singlecount++;
                            }

                        }
                    }
                }
                for(int j = 1; j < 15; j++)
                {
                    //top edge
                    if (oWall.mWall[0, j].BackgroundColour != Color.Transparent)
                    {
                        another++;
                        checkColour = oWall.mWall[0, j].BackgroundColour;
                        if (oWall.mWall[1, j].BackgroundColour != checkColour)
                        {
                            if (oWall.mWall[0, j - 1].BackgroundColour != checkColour)
                            {
                                if (oWall.mWall[0, j + 1].BackgroundColour != checkColour)
                                    singlecount++;
                            }
                        }
                    }
                }
                for(int j = 1; j < 15; j++)
                {
                    //bottom edge
                    if (oWall.mWall[15, j].BackgroundColour != Color.Transparent)
                    {
                        another++;
                        checkColour = oWall.mWall[15, j].BackgroundColour;
                        if (oWall.mWall[14, j].BackgroundColour != checkColour)
                            if (oWall.mWall[15, j - 1].BackgroundColour != checkColour)
                                if (oWall.mWall[15, j + 1].BackgroundColour != checkColour)
                                    singlecount++;
                    }
                }
                //the rest of the wall
                for (int i = 1; i < 15; i++)
                {
                    for (int j = 1; j < 15; j++)
                    {
                        if (oWall.mWall[i, j].BackgroundColour != Color.Transparent)
                        {
                            another++;
                            checkColour = oWall.mWall[i, j].BackgroundColour;
                            if (oWall.mWall[i + 1, j].BackgroundColour != checkColour)
                            {
                                if (oWall.mWall[i, j + 1].BackgroundColour != checkColour)
                                {
                                    if (oWall.mWall[i - 1, j].BackgroundColour != checkColour)
                                    {
                                        if (oWall.mWall[i, j - 1].BackgroundColour != checkColour)
                                            singlecount++;
                                    }
                                }
                            }
                        }
                    }
                }
                //if the number of coloured bricks is equal to the number of the same coloured bricks adjacene to the one it is on
                //the game is over
                if (another == singlecount)
                {
                    lblEnd.Text = "Game Over!";
                    lblEnd.Visible = true;
                    btnStart.Text = "Play again!";
                    btnStart.Enabled = true;
                }
            }
            singlecount = 0;
            another = 0;
        }

        //checks if there are any bricks of the same colour that is adjacent to the clicked one
        //makes those bricks black
        public void brickcheck(int r, int c)
        {
            int row = oWall.mWall.GetLength(0);
            int cols = oWall.mWall.GetLength(1);
            if(c > -1 && r > -1 && c < cols && r < row)
            {
                if (oWall.mWall[r, c].BackgroundColour == checkColour)
                {
                    brickcount++;
                    oWall.mWall[r, c].BackgroundColour = Color.Transparent;
                    brickcheck(r - 1, c);
                    brickcheck(r, c - 1);
                    brickcheck(r + 1, c);
                    brickcheck(r, c + 1);
                }
            }
        }

        //checks to see if the brick below it is black to showcase how many
        //bricks need to "fall"
        public void blackcheck(int r, int c)
        {
            int row = oWall.mWall.GetLength(0);
            int cols = oWall.mWall.GetLength(1);
            if (c > -1 && r > -1 && c <= cols && r <= row)
            {
                if(oWall.mWall[r, c].BackgroundColour == Color.Transparent && r < 15)
                {
                    counter++;
                    blackcheck(r + 1, c);
                }
            }
        }
        //if any of the wands are clicked, turn them invisible
        private void pcbWand1_Click(object sender, EventArgs e)
        {
            if((pcbWand2.Visible == false || pcbWand3.Visible == false || pcbWand4.Visible == false || pcbWand5.Visible == false) && pcbWand1.Image != null)
                pcbWand1.Visible = true;
            else
                pcbWand1.Visible = false;
        }
        private void pcbWand2_Click(object sender, EventArgs e)
        {
            if ((pcbWand1.Visible == false || pcbWand3.Visible == false || pcbWand4.Visible == false || pcbWand5.Visible == false) && pcbWand2.Image != null)
                pcbWand2.Visible = true;
            else
                pcbWand2.Visible = false;
        }
        private void pcbWand3_Click(object sender, EventArgs e)
        {
            if (pcbWand1.Visible == false || pcbWand2.Visible == false || pcbWand4.Visible == false || pcbWand5.Visible == false && pcbWand3.Image != null)
                pcbWand3.Visible = true;
            else
                pcbWand3.Visible = false; 
        }
        private void pcbWand4_Click(object sender, EventArgs e)
        {
            if (pcbWand1.Visible == false || pcbWand2.Visible == false || pcbWand3.Visible == false || pcbWand5.Visible == false && pcbWand4.Image != null)
                pcbWand4.Visible = true;
            else
                pcbWand4.Visible = false;
        }
        private void pcbWand5_Click(object sender, EventArgs e)
        {
            if (pcbWand1.Visible == false || pcbWand2.Visible == false || pcbWand3.Visible == false || pcbWand4.Visible == false)
                pcbWand5.Visible = true;
            else
                pcbWand5.Visible = false;
        }
    }
}
