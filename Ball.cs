using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Ball : Element_game
    {
        private SolidBrush color_ball;

        public Ball(int x, int y, int height, int width, Color color) : base(x, y, height, width)
        {
            color_ball = new SolidBrush(color);

        }


        public void DrawBall(Graphics gr)
        {
            gr.FillEllipse(this.color_ball, new Rectangle(this.x, this.y, this.width, this.height));

        }
    }
}
