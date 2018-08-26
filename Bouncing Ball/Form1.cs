using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_Ball
{
    public partial class Form1 : Form
    {
        Ball ball; // a generic ball to play with. Be aware that Ball is an abstract class.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiate the ball with some co-ordinates
            ball = new RoundBall(40,40); 
            //refresh the form to trigger the paint event
            Refresh(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // wipe the form re-draw the ball in its new position
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);
            ball.Draw(e.Graphics, tbSize.Value*10);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // move the ball and refresh the form to trigger the paint event
            ball.Move(tbSize.Value*10,tbSpeed.Value,ClientSize.Width,ClientSize.Height);
            Refresh();
        }
    }
}

