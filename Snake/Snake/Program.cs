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
            p1.DrawPoint();
            Point p2 = new Point(2, 4, '#');
            p2.DrawPoint();
            HorizontalLine hLine = new HorizontalLine(5, 8, 6, '%');
            hLine.DrawLine();
            VerticalLine vLine = new VerticalLine(4, 3, 8, '&');
            vLine.DrawLine();
            Console.ReadLine();
        }
    }
}
