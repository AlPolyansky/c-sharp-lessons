using System;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 3;
            int y = 4;
            int[,] matrix = sortMatrix(y, x);
            renderMatrix(matrix, y, x);
        }

        static void renderMatrix(int[,] matrix, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("|");
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matrix[i, j] + "|");
                }

                Console.WriteLine();
            }
        }

        static int[,] sortMatrix(int y, int x)
        {
            int[,] matrix = new int[y, x];

            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int numberOfTurns = 0;
            int visits = x;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                visits--;
                if (visits == 0)
                {
                    visits = x * (numberOfTurns % 2) + y * ((numberOfTurns + 1) % 2) - ((numberOfTurns / 2) - 1) - 2;

                    // Поворот по часовой стрелке
                    int temp = dx;
                    dx = -dy;
                    dy = temp;

                    numberOfTurns++;
                }

                col += dx;
                row += dy;
            }

            return matrix;
        }
    }
}
