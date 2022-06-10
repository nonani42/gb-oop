using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int _width, int _height, char sym)
        {
            wallList = new List<Figure>();
            wallList.Add(new HorizontalLine(0, _width - 2, 0, sym));
            wallList.Add(new HorizontalLine(0, _width - 2, _height - 1, sym));
            wallList.Add(new VerticalLine(0, _height - 1, 0, sym));
            wallList.Add(new VerticalLine(0, _height - 1, _width - 2, sym));

            foreach(var fig in wallList)
            {
                fig.DrawLine();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
