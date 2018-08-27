using System.Drawing;

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

        //Constructor which additionally takes direction for each axis
        public RoundBall(int initialX, int initialY, int initialXDir, int initialYDir)
        {
            x = initialX;
            y = initialY;
            xDir = initialXDir;
            yDir = initialYDir;
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
