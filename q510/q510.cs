/****************************
** q510.cs
** Orcs Have Mothers Too
** Patrick Xie, 5/10/2011
** Mothers Day Card
****************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace q510
{
    public partial class q510 : Form
    {
        /* Global Variables */
        private Bitmap myCanvas;
        private Pen myPen = new Pen(Color.Black, 3);
        private SolidBrush myBrush = new SolidBrush(Color.Black);
        private Point childLoc = new Point(350, 239);
        private Point motherLoc = new Point(112, 120);
        private Point upperLeftCorner = new Point(0,0);
        int newPosX;
        int newPosY;
        bool toMother;

        public q510()
        {
            InitializeComponent();
        }

        private void q510_Load(object sender, EventArgs e)
        {
            /*initial load settings */
            animationTimer.Start();
            newPosX = childLoc.X;
            newPosY = childLoc.Y;
            myCanvas = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.White);
            toMother = true;
            textBox1.Text = animationTimer.Interval.ToString();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myCanvas);
            if (newPosX != motherLoc.X && newPosY != motherLoc.Y)
            {
                g.Clear(Color.White);
                //draws a black circle to signify call signal from phone to phone
                g.DrawEllipse(myPen, newPosX, newPosY, 10, 10);
                g.FillEllipse(myBrush,newPosX, newPosY, 10, 10);
                //the rate of the dot moving on the line
                if (toMother)
                {
                    newPosX -= 2;
                    newPosY -= 1;
                }
                if (newPosX == motherLoc.X && newPosY == motherLoc.Y)
                {
                    toMother = false;
                }
                if (!toMother)
                {
                    newPosX += 2;
                    newPosY += 1;
                }
                if (newPosX == childLoc.X && newPosY == childLoc.Y)
                {
                    toMother = true;
                }
                this.Refresh();
            }
        }

        private void q510_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myCanvas, 0, 0, myCanvas.Width, myCanvas.Height);
            //draws the line connecting the two pictures
            g.DrawLine(myPen, childLoc, motherLoc);
        }

        private void intervalButton_Click(object sender, EventArgs e)
        {
            //sets the interval of the animation timer to what is on the textbox
            animationTimer.Interval = Int16.Parse(textBox1.Text);
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            //if animation timer is going, then stops the animation
            //and sets the text to call to restart the animation
            if (animationTimer.Enabled)
            {
                animationTimer.Stop();
                callButton.Text = "Call";
            }
            //if animation was already stopped then it will start it up
            // and set the text to hang up which stops the animation
            else
            {
                animationTimer.Start();
                callButton.Text = "Hang Up";
            }
        }

    }
}