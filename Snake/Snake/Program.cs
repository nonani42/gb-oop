using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw(p1.x, p1.y, p1.sym);
            Point p2 = new Point(2, 4, '#');
            p2.Draw(p2.x, p2.y, p2.sym);
            HorizontalLine hLine = new HorizontalLine(5, 8, 6, '%');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(4, 3, 8, '&');
            vLine.Draw();
            Console.ReadLine();
        }
    }
}
