using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Land : Element_game
    {

        private SolidBrush color_land;

        public Land(int x, int y, int height, int width, Color color) : base(x, y, height, width)
        {
            color_land = new SolidBrush(color);
        }

        public void DrawLand(Graphics gr)
        {
            gr.FillRectangle(this.color_land, new Rectangle(this.x, this.y, this.width, this.height));

        }



    }
}
