using System.Drawing;

namespace Bouncing_Ball
{
    //Instantiable child of ball. Makes a ball that flashes all colours of the rainbow.
    class SquareRainbowBall : Ball
    {
        //A brush to play with and RGB values to tweak. dir variables define the direction and severity of tweaking
        Brush brush;
        int R = 1;
        int rDir = 1;
        int G = 2;
        int gDir = 2;
        int B = 3;
        int bDir = 3;

        //Constructor which takes starting co-orindates of the top left corner of the ball
        public SquareRainbowBall(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
        }

        //Constructor which additionally takes direction of ball
        public SquareRainbowBall(int initialX, int initialY, int initialXDir, int initialYDir)
        {
            x = initialX;
            y = initialY;
            xDir = initialXDir;
            yDir = initialYDir;
        }

        //Draw a rainbow flashing ball of the size provided, on the provided graphics object
        public override void Draw(Graphics g, int size)
        {
            //cycle through RGB values, at different speeds for each component to give a wider variance in colours produced
            if (R == 255 || R == 0)
            {
                rDir = -rDir;
            }
            R += rDir;
            if (G > 253 || G < 2)
            {
                gDir = -gDir;
            }
            G += gDir;
            if (B > 252 || B < 3)
            {
                bDir = -bDir;
            }
            B += bDir;
            //assign the colour to the brush
            brush = new SolidBrush(Color.FromArgb(255, R, G, B));
            //draw the ball
            //uses the current coordinates as the top left corner of the space the ball will occupy.
            g.FillRectangle(brush, x, y, size, size);
        }

    }
}
