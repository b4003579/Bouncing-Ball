using System.Drawing;

namespace Bouncing_Ball
{
    //Generic parent class for balls. Can't be instantiated.
    public abstract class Ball
    {
        protected int x, y; // position of ball
        protected int xDir = 1, yDir = 1; // direction of ball travel on each axis, set to negative to move left and/or down.

        public int GetX()
        {
            return x;
        }

        public int GetXDir()
        {
            return xDir;
        }


        public int GetY()
        {
            return y;
        }

        public int GetYDir()
        {
            return yDir;
        }

        //Check for boundary collisions, and then move the ball accordingly
        //It's still possible for the ball to get stuck if its size is increased while near the left or bottom of the window!
        public void Move(int size, int speed, int winWidth, int winHeight)
        {
            if (x <= 0)
            {
                //if the ball has been forced into a wall (i.e. by a resize), we need to 'spit it out'
                x = 0;
                //then change the direction
                xDir = -xDir;
            }
            if (x + size >= winWidth)
            {
                x = winWidth - size;
                xDir = -xDir;
            }
            if (y <= 0)
            {
                y = 0;
                yDir = -yDir;
            }
            if (y + size >= winHeight)
            {
                y = winHeight - size;
                yDir = -yDir;
            }
            x += xDir * speed;
            y += yDir * speed;
        }

        //Draw the ball using a provided graphics object and size value. This will be diferent for each ball type and must be overridden.
        public abstract void Draw(Graphics g, int size);

    }
}
