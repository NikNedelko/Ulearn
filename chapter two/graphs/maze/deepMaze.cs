using System;
using System.Collections.Generic;
using System.Drawing;
namespace maze2
{
    enum State
    {
        Empty,
        Wall,
        Visited
    };

    public class Program
    {
        static void Visit(State[,] map, int x, int y)
        {
            if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1)) return;
            if (map[x, y] != State.Empty) return;
            map[x, y] = State.Visited;
            for (int dx = 0; dx <= 1; dx++)
                for (int dy = -1; dy <= 1; dy++)
                    if (Math.Abs(dx) + Math.Abs(dy) != 1) continue;
                    else Visit(map, x + dx, y + dy);


        }

        static void Main()
        {
            var map = new State[labyrinth[0].Length, labyrinth.Length];

                        for (int x = 0; x < map.GetLength(0); x++)
                            for (int y = 0; y < map.GetLength(1); y++)
                                map[x, y] = labyrinth[y][x] == ' ' ? State.Empty : State.Wall;

            var stack = new Stack<Point>();
            stack.Push(new Point(0, 0));
            while (stack.Count != 0)
            {
                var point = stack.Pop();
                if (point.X < 0 || point.X >= map.GetLength(0) || point.Y < 0 || point.Y >= map.GetLength(1)) return;
                if (map[point.X, point.Y] != State.Empty) return;
                map[point.X, point.Y] = State.Visited;
                for (int dx = 0; dx <= 1; dx++)
                    for (int dy = -1; dy <= 1; dy++)
                        if (Math.Abs(dx) + Math.Abs(dy) != 1) continue;
                        else stack.Push(new Point(point.X+dx,point.Y+dy));
            }

            Print(map);
            Visit(map, 0, 0);
        }

        static string[] labyrinth = new string[]
        {
        " X   X    ",
        " X XXXXX X",
        "      X   ",
        "XXXX XXX X",
        "         X",
        " XXX XXXXX",
        " X        ",
        };

        static void Print(State[,] map)
        {
            return;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            for (int x = 0; x < map.GetLength(0) + 2; x++)
                Console.Write("X");
            Console.WriteLine();
            for (int y = 0; y < map.GetLength(1); y++)
            {
                Console.Write("X");
                for (int x = 0; x < map.GetLength(0); x++)
                    switch (map[x, y])
                    {
                        case State.Wall: Console.Write("X"); break;
                        case State.Empty: Console.Write(" "); break;
                        case State.Visited: Console.Write("."); break;
                    }
                Console.WriteLine("X");
            }
            for (int x = 0; x < map.GetLength(0) + 2; x++)
                Console.Write("X");
            Console.ReadKey();
        }
    }
}
