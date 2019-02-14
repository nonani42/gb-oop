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
            Point p2 = new Point(4, 5, '#');
            p2.Draw(p2.x, p2.y, p2.sym);
            Point p3 = new Point(6, 13, '`');
            p3.Draw(p3.x, p3.y, p3.sym);
            Point p4 = new Point(8, 8, '^');
            p4.Draw(p4.x, p4.y, p4.sym);
            Point p5 = new Point(9, 7, '%');
            p5.Draw(p5.x, p5.y, p5.sym);
            Point p6 = new Point(15, 23, '~');
            p6.Draw(p6.x, p6.y, p6.sym);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('`');
            charList.Add('~');
            charList.Add('%');

            foreach(char i in charList)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
