using System.Drawing;

namespace Bouncing_Ball
{
    //Generic parent class for balls. Can't be instantiated.
    public abstract class Ball
    {
        protected int x, y; // position of ball
        protected int xDir = 1, yDir = 1; // direction of ball travel on each axis

        //Draw the ball using a provided graphics object and size value. This will be diferent for each ball type and must be overridden.
        public abstract void Draw(Graphics g, int size);

        //Check for boundary collisions, and then move the ball accordingly
        public void Move(int size, int speed, int winWidth, int winHeight)
        {
            if (x + size >= winWidth || x <= 0)
            {
                xDir = -xDir;
            }
            if (y + size >= winHeight || y <= 0)
            {
                yDir = -yDir;
            }
            x += xDir * speed;
            y += yDir * speed;
        }
    }
}
