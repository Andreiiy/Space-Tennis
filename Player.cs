using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Player : Element_game
    {

        private SolidBrush colorPlayer;

        public Player(int x, int y, int height, int width, Color colplayer) : base(x, y, height, width)
        {
            colorPlayer = new SolidBrush(colplayer);
        }


        public void DrawPlayer(Graphics gr)
        {
            gr.FillRectangle(this.colorPlayer, new Rectangle(this.x, this.y, this.width, this.height));

        }
    }
}
