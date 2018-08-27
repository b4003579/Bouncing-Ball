﻿using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bouncing_Ball
{
    public partial class Form1 : Form
    {
        Ball ball; // a generic ball to play with. Be aware that Ball is an abstract class.
        //the form also contains two trackbars, tbSize and tbSpeed whose values determine the size and speed of the ball.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiate the ball with some random co-ordinates
            Random rnd = new Random();
            ball = new SpinningRainbowBall(rnd.Next(1, ClientSize.Width - tbSize.Value), rnd.Next(1, ClientSize.Height - tbSize.Value));
            //refresh the form to trigger the paint event
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // wipe the form and re-draw the ball in its new position
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);
            ball.Draw(e.Graphics, tbSize.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // move the ball and refresh the form to trigger the paint event
            ball.Move(tbSize.Value, tbSpeed.Value, ClientSize.Width, ClientSize.Height);
            Refresh();
        }
    }
}

