using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //frame
            Console.SetWindowSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            upLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            //food
            Point p1 = new Point(10, 10, '#');
            p1.DrawPoint();
            Point p2 = new Point(14, 21, '#');
            p2.DrawPoint();

            //snake
            Point tail = new Point(5, 5, '*');
            Snake snake = new Snake(tail, 3, Direction.RIGHT);
            snake.DrawLine();

            for (int i=0; i<10; i++)
            {
                snake.Move();
                Thread.Sleep(300);
            }
            Console.ReadLine();
        }
    }
}
