using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int width;
        int height;
        char sym;
        Random r;

        public FoodCreator(int _width, int _height, char _sym)
        {
            width = _width;
            height = _height;
            sym = _sym;
            r = new Random();
        }
        public Point CreateFood()
        {
            return new Point(r.Next(2, width-2), r.Next(2, height-2), sym);
        }
    }
}
