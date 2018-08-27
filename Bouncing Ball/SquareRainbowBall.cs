using System.Drawing;

namespace Bouncing_Ball
{
    //Instantiable child of ball. Makes a ball that flashes all colours of the rainbow.
    //The effect is slightly aggressive
    class SquareRainbowBall : Ball
    {
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
            if (R == 255 || R == 0) {
                rDir = -rDir; }
            R += rDir;
            if (G > 253 || G < 2) {
                gDir = -gDir; }
            G += gDir;
            if (B > 252 || B < 3) {
                bDir = -bDir; }
            B += bDir;

            brush = new SolidBrush(Color.FromArgb(255,R,G,B));
            //uses the current coordinates as the top left corner of the space the ball will occupy.
            g.FillRectangle(brush, x, y, size, size);
        }

    }
}
