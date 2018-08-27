using System.Drawing;

namespace Bouncing_Ball
{
    //Instantiable child of ball. Makes a ball that flashes all colours of the rainbow.
    class SpinningRainbowBall : Ball
    {
        public Brush[] brushes;
        int currentBrush = 0;
        //Constructor which takes starting co-orindates of the top left corner of the ball
        public SpinningRainbowBall(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
            //set up an array of brushes to provide support for the 'Rainbow' effect
            brushes = new Brush[]
            {
                Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Indigo, Brushes.Violet
            };

        }
        //Draw a round blue ball of the size provided, on the provided graphics object
        public override void Draw(Graphics g, int size)
        {
            //uses the current coordinates as the top left corner of the space the ball will occupy.
            g.FillRectangle(brushes[currentBrush], x, y, size, size);
            if (currentBrush == 6)
                currentBrush = 0;
            else currentBrush++;
        }

    }
}
