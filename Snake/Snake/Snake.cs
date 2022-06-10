using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i=0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.DrawPoint();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public bool Eat(Point point)
        {
            Point head = GetNextPoint();
            if(head.IsHit(point))
            {
                point.sym = head.sym;
                pList.Add(point);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void KeyInput(ConsoleKey key)
        {
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        direction = Direction.LEFT;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.RIGHT;
                        break;
                    case ConsoleKey.UpArrow:
                        direction = Direction.UP;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.DOWN;
                        break;
                }
        }

        public bool IsHitTail()
        {
            Point head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
