using System.Drawing;

namespace Bouncing_Ball
{
    //Instantiable child of ball. Makes a ball that flashes all colours of the rainbow.
    //The effect is slightly aggressive
    class SquareRainbowBall : Ball
    {
        public Brush[] brushes;
        int currentBrush = 0;
        //Constructor which takes starting co-orindates of the top left corner of the ball
        public SquareRainbowBall(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
            //set up an array of brushes to provide support for the 'Rainbow' effect
            brushes = new Brush[]
            {
                Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Indigo, Brushes.Violet
            };

        }

        public SquareRainbowBall(int initialX, int initialY, int initialXDir, int initialYDir)
        {
            x = initialX;
            y = initialY;
            xDir = initialXDir;
            yDir = initialYDir;
            brushes = new Brush[]
            {
                Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Indigo, Brushes.Violet
            };
        }

        //Draw a rainbow flashing ball of the size provided, on the provided graphics object
        public override void Draw(Graphics g, int size)
        {
            //uses the current coordinates as the top left corner of the space the ball will occupy.
            g.FillRectangle(brushes[currentBrush], x, y, size, size);
            if (currentBrush >= brushes.Length - 1)
                currentBrush = 0;
            else currentBrush++;
        }

    }
}
