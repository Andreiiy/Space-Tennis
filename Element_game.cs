using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Tennis
{
    class Element_game
    {
        protected int x, y;
        protected int height;
        protected int width;



        public Element_game(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public void Move(int num, int num1)
        {
            this.x += num;
            this.y += num1;
        }
    }
}
