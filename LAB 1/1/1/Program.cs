using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
namespace BootingCSharp
{
    class Program
    {
        public static object Keyboard { get; private set; }

        static void Main(string[] args)
        {
            int pacmanX = 4;
            int pacmanY = 5;
            char[,] maze = new char[10, 10] {
                {'#','#','#','#','#','#','#','#','#','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#','#','#','#','#','#','#','#','#','#' },
            };
            Maze(maze);
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    move_pacman_up(maze,ref pacmanX,ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    move_pacman_down(maze, ref pacmanX, ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    move_pacman_right(maze, ref pacmanX, ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    move_pacman_left(maze, ref pacmanX, ref pacmanY);
                }
            }
        }
        static void Maze(char[,] maze)
        {
            
            for (int i = 0;i < 10; i++)
            {
                for(int j = 0; j < 10;j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static void move_pacman_left(char[,] maze,ref int pacmanX , ref int pacmanY)
        {
            if (maze[pacmanX - 1,pacmanY] == ' ' || maze[pacmanX - 1,pacmanY] == '.')
            {
                maze[pacmanX,pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanX = pacmanX - 1;
                maze[pacmanX,pacmanY] = 'P';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write("P");

            }
        }
        static void move_pacman_right(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX + 1, pacmanY] == ' ' || maze[pacmanX + 1, pacmanY] == '.')
            {
                maze[pacmanX, pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanX = pacmanX + 1;
                maze[pacmanX, pacmanY] = 'P';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write("P");

            }
        }
        static void move_pacman_up(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX , pacmanY - 1] == ' ' || maze[pacmanX - 1, pacmanY - 1] == '.')
            {
                maze[pacmanX, pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanY = pacmanY - 1;
                maze[pacmanX, pacmanY] = 'P';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write("P");

            }
        }
        static void move_pacman_down(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX, pacmanY + 1] == ' ' || maze[pacmanX , pacmanY + 1] == '.')
            {
                maze[pacmanX, pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanY = pacmanY + 1;
                maze[pacmanX, pacmanY] = 'P';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write("P");

            }
        }
    }
}