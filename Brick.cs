using System;
using System.Drawing;

namespace FinalCPT
{
    class Brick
    {
        //private member variables
        private int mSize;
        private Color mBackgroundColour;
        private Color mBorderColour;

        //constructers
        public Brick()
        {
            //default to white cell and black border
            this.mSize = 20;
            this.mBackgroundColour = Color.Black;
            this.mBorderColour = Color.White;
        }

        public Brick(int Size, Color BackgroundColor, Color BorderColor)
        {
            this.mSize = Size;
            this.mBorderColour = BorderColor;
            this.mBackgroundColour = BackgroundColor;
        }

        //properties
        public int Size
        {
            set { this.mSize = value; }
            get { return this.mSize; }
        }

        public Color BackgroundColour
        {
            set { this.mBackgroundColour = value; }
            get { return this.mBackgroundColour; }
        }

        public Color BorderColour
        {
            set { this.mBorderColour = value; }
            get { return this.mBorderColour; }
        }

        //methods
        public void Draw(Graphics g, int X, int Y)
        {
            //create a Pen and a Brush
            Pen BorderPen = new Pen(this.mBorderColour);
            Brush BackBrush = new SolidBrush(this.mBackgroundColour);

            //draw the cell
            g.FillRectangle(BackBrush, X, Y, this.mSize, this.mSize);
            g.DrawRectangle(BorderPen, X, Y, this.mSize, this.mSize);

            //dispose drawing tools
            BorderPen.Dispose();
            BackBrush.Dispose();
        }
    }
}
