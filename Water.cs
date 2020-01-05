using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Water : Element_game
    {

        private SolidBrush color_water;


        public Water(int x, int y, int height, int width, Color color) : base(x, y, height, width)
        {
            color_water = new SolidBrush(color);
        }


        public void DrawWater(Graphics gr)
        {

            gr.FillRectangle(this.color_water, new Rectangle(this.x, this.y, this.width, this.height));
        }
    }
}
