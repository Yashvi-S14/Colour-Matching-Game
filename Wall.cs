using System;
using System.Drawing;

namespace FinalCPT
{
    class Wall
    {
        public Brick[,] mWall;
        private int mRows, mColumns, mBrickSize;

        //properties
        public int Rows
        {
            set { this.mRows = value; }
            get { return this.mRows; }
        }
        public int Columns
        {
            set { this.mColumns = value; }
            get { return this.mColumns; }
        }
        public int BrickSize
        {
            set { this.mBrickSize = value; }
            get { return this.mBrickSize; }
        }

        //constructors

        public Wall(int Rows, int Columns, int BrickSize)
        {
            this.mBrickSize = BrickSize;
            this.mColumns = Columns;
            this.mRows = Rows;

            //create the grid array
            mWall = new Brick[this.mRows, this.mColumns];

            //the special brick will only come up if the random generator picks a 1
            Random num = new Random();
            int special = num.Next(0, 2);
            if (special == 0)
            {
                //distribute the colours evenly along the grid}
                for (int i = 0; i < this.mRows; i++)
                {
                    for (int j = 0; j < this.mColumns; j++)
                    {
                        if (i >= 0 && i < 4 && j >= 0)
                            mWall[i, j] = new Brick(this.mBrickSize, Color.Aqua, Color.White);
                        else if (i >= 4 && i < 8 && j >= 0)
                            mWall[i, j] = new Brick(this.mBrickSize, Color.DeepPink, Color.White);
                        else if (i >= 8 && i < 12 && j >= 0)
                            mWall[i, j] = new Brick(this.mBrickSize, Color.Lime, Color.White);
                        else
                            mWall[i, j] = new Brick(this.mBrickSize, Color.DarkOrange, Color.White);
                    }
                }
            }
            else if(special == 1)
            {
                //integrate the special one if a 1 is selected
                for (int i = 0; i < this.mRows; i++)
                {
                    for (int j = 0; j < this.mColumns; j++)
                    {
                        mWall[0, 0] = new Brick(this.mBrickSize, Color.Green, Color.White);
                        if (i >= 0 && i < 4 && j >= 0 && mWall[i, j] != mWall[0, 0])
                            mWall[i, j] = new Brick(this.mBrickSize, Color.Aqua, Color.White);
                        else if (i >= 4 && i < 8 && j >= 0 && mWall[i, j] != mWall[0, 0])
                            mWall[i, j] = new Brick(this.mBrickSize, Color.DeepPink, Color.White);
                        else if (i >= 8 && i < 12 && j >= 0 && mWall[i, j] != mWall[0, 0])
                            mWall[i, j] = new Brick(this.mBrickSize, Color.Lime, Color.White);
                        else
                            mWall[i, j] = new Brick(this.mBrickSize, Color.DarkOrange, Color.White);
                    }
                }
            }
        }

        public void Shuffle()
        {
            //create a random number and square variable
            Random num1 = new Random();
            Brick Temp = new Brick();

            //create 2 random numbers and make that the new location for the current colour on the grid and switch the two colours
                for (int i = 0; i < mRows; i++)
                {
                    for (int j = 0; j < mColumns; j++)
                    {
                        int rowRand = num1.Next(0, 16);
                        int coluRand = num1.Next(0, 16);
                        Temp = mWall[i, j];
                        mWall[i, j] = mWall[rowRand, coluRand];
                        mWall[rowRand, coluRand] = Temp;
                    }
                }
        }
        public void Draw(Graphics g, int X, int Y)
        {
            //draw the grid starting from (X, Y) top left corner
            int pX = X;
            int pY = Y;

            for (int i = 0; i < this.mRows; i++)
            {
                pY = Y + (i * this.mBrickSize);
                for (int j = 0; j < this.mColumns; j++)
                {
                    pX = X + (j * this.mBrickSize);
                    mWall[i, j].Draw(g, pX, pY);
                }
            }
        }
    }
}
