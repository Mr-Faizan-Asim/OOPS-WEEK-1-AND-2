using System;
using System.ComponentModel;
using EZInput;

namespace game
{
    class program
    {
        static void Main(string[] args)
        {
            int[] right_bulletsX = new int[1000];
            int[] right_bulletsY = new int[1000];
            int[] left_bulletsX = new int[1000];
            int[] left_bulletsY = new int[1000];
            bool[] is_player_right_bullet_active = new bool[1000];
            bool[] is_player_left_bullet_active = new bool[1000];
            int[] count = { 0, 0 };
            int[] main_char_axis = { 22, 22 };
            box(35, 120);
            planes(20, 10, 100);
            planes(10, 15, 30);
            planes(80, 15, 110);
            planes(5, 20, 40);
            planes(75, 20, 115);
            planes(10, 25, 30);
            planes(80, 25, 110);
            planes(15, 30, 100);
            string direction = "right";
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.RightArrow) && main_char_axis[0] < 115)
                {
                    remove_char(main_char_axis);
                    main_char_axis[0] = main_char_axis[0] + 1;
                    direction = "right";
                    Character(direction, main_char_axis);

                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow) && main_char_axis[0] > 1)
                {
                    remove_char(main_char_axis);
                    main_char_axis[0] = main_char_axis[0] - 1;
                    direction = "left";
                    Character(direction, main_char_axis);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow) && main_char_axis[1] > 1)
                {
                    remove_char(main_char_axis);
                    main_char_axis[1] = main_char_axis[1] - 1;
                    Character(direction, main_char_axis);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow) && main_char_axis[1] < 31)
                {
                    remove_char(main_char_axis);
                    main_char_axis[1] = main_char_axis[1] + 1;
                    Character(direction, main_char_axis);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    bullet_generate(main_char_axis, direction, right_bulletsX, right_bulletsY, left_bulletsX, left_bulletsY, is_player_right_bullet_active, is_player_left_bullet_active, count);
                }
                if (Keyboard.IsKeyPressed(Key.Escape))
                {
                    break;
                }
                bullet_move(main_char_axis, direction, right_bulletsX, right_bulletsY, left_bulletsX, left_bulletsY, is_player_right_bullet_active, is_player_left_bullet_active, count);
                Thread.Sleep(20);
            }


        }
        static void bullet_generate(int[] axis, string player_direction, int[] right_bulletsX, int[] right_bulletsY, int[] left_bulletsX, int[] left_bulletsY, bool[] is_player_right_bullet_active, bool[] is_player_left_bullet_active, int[] count)
        {
            int x = axis[0];
            int y = axis[1];
            if (player_direction == "right")
            {
                right_bulletsX[count[0]] = x + 4;
                right_bulletsY[count[0]] = y + 1;
                is_player_right_bullet_active[count[0]] = true;
                count[0]++;
                printbullet(x + 4, y + 1);
            }
            // generating left hand side bullet
            else if (player_direction == "left")
            {
                left_bulletsX[count[1]] = x - 1;
                left_bulletsY[count[1]] = y + 1;
                is_player_left_bullet_active[count[1]] = true;
                count[1]++;
                printbullet(x - 1, y + 1);
            }

        }
        static void box(int row, int col)
        {

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (i == 0 || i == 34 || j == 0 || j == 119)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Character(string direction, int[] axis)
        {
            char[,] star_man_right = { { ' ', '0', ' ', ' ' }, { '/', '#', '>', '=' }, { '/', ')', ' ', ' ' } };
            char[,] star_man_left = { { ' ', ' ', '0', ' ' }, { '=', '<', '#', '\\' }, { ' ', ' ', '(', '\\' } };
            int x_axis = axis[0];
            int y_axis = axis[1];
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x_axis, y_axis + i);
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (direction == "right")
                    {
                        Console.Write(star_man_right[i, j]);
                    }
                    else if (direction == "left")
                    {
                        Console.Write(star_man_left[i, j]);
                    }
                }
                Console.WriteLine("");
            }

        }
        static void remove_char(int[] axis)
        {
            int x_axis = axis[0];
            int y_axis = axis[1];
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x_axis, y_axis + i);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
        static void erasebullet(int x, int y) // erases the bullet
        {

            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        static void printbullet(int x, int y) // prints the bullet
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        static void bullet_move(int[] axis, string player_direction, int[] right_bulletsX, int[] right_bulletsY, int[] left_bulletsX, int[] left_bulletsY, bool[] is_player_right_bullet_active, bool[] is_player_left_bullet_active, int[] count)
        {
            int pbulletcountR = count[0];
            int pbulletcountL = count[1];
            for (int i = 0; i < pbulletcountR; i++)
            {
                if (is_player_right_bullet_active[i] && right_bulletsX[i] < 118)
                {
                    erasebullet(right_bulletsX[i], right_bulletsY[i]);
                    right_bulletsX[i] += 1;
                    printbullet(right_bulletsX[i], right_bulletsY[i]);
                }
                else if (right_bulletsX[i] >= 118)
                {
                    erasebullet(right_bulletsX[i], right_bulletsY[i]);
                }
            }
            // for left hand side bullet
            for (int i = 0; i < pbulletcountL; i++)
            {
                if (is_player_left_bullet_active[i] && left_bulletsX[i] > 1)
                {
                    erasebullet(left_bulletsX[i], left_bulletsY[i]);
                    left_bulletsX[i] -= 1;
                    printbullet(left_bulletsX[i], left_bulletsY[i]);
                }
                else if (left_bulletsX[i] <= 1)
                {
                    erasebullet(left_bulletsX[i], left_bulletsY[i]);
                }
            }
        }
        static void planes(int x, int y, int end_x)
        {
            for (int i = x; i < end_x; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write("#");
            }
        }
    }
}