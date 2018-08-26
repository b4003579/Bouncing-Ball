using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Ball
{
    //Instantiable child of ball. Makes a plain round blue ball.
    class RoundBall : Ball
    {
        //Constructor which takes starting co-orindates of the top left corner of the ball
        public RoundBall(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
        }
        //Draw a round blue ball of the size provided, on the provided graphics object
        public override void Draw(Graphics g, int size)
        {
            //uses the current coordinates as the top left corner of the space the ball will occupy.
            //(This is significant because it means the ball is "physically" rectangular, although it will look round.)
            g.FillEllipse(Brushes.Blue, x, y, size, size);
        }

    }
}
