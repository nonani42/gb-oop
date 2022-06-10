using System;
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
            Walls walls = new Walls(Console.WindowWidth, Console.WindowHeight, '#');

            //food
            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth, Console.WindowHeight, '$');
            Point food = foodCreator.CreateFood();
            food.DrawPoint();

            //snake
            Point tail = new Point(5, 5, '*');
            Snake snake = new Snake(tail, 3, Direction.RIGHT);
            snake.DrawLine();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.DrawPoint();
                }
                else
                {
                    snake.Move();

                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    snake.KeyInput(key);
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) - 1);
            Console.WriteLine("==============================");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 7, (Console.WindowHeight / 2));
            Console.WriteLine("G A M E  O V E R");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) + 1);
            Console.WriteLine("==============================");

            Console.ReadKey();
        }
    }
}
