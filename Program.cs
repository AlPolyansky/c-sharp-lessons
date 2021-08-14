using System;

namespace Lessons.Lesson_7
{
    class Cross
    {
        static int SIZE_WIN = 4;
        static int SIZE_X = 5;
        static int SIZE_Y = 5;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
            Console.WriteLine(field[y, x]);
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void playerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static int CheckLineToHorizontal(int vertival, int horizontal, char sym)
        {
            int count = 0;
            for (int j = horizontal; j < SIZE_WIN; j++)
            {
                if ((field[vertival, j] == sym))
                {
                    count++;
                }
            }

            return count;
        }

        private static int CheckLineToVerticle(int vertival, int horizontal, char sym)
        {
            int count = 0;
            for (int j = vertival; j < SIZE_WIN; j++)
            {
                if ((field[j, horizontal] == sym))
                {
                    count++;
                }
            }

            return count;
        }

        private static int CheckLineToDiagonalFromLeft(char sym)
        {
            int count = 0;
            for (int i = 0; i < SIZE_WIN; i++)
            {
                if ((field[i, i] == sym)) count++;
            }
            return count;
        }

        private static int CheckLineToDiagonalFromRight(int vertival, int horizontal, char sym)
        {
            int count = 0;
            for (int i = 0, j = SIZE_X - 1; i < SIZE_WIN; i++, j--)
            {
                if ((field[j, i] == sym)) count++;
            }
            return count;
        }

        private static bool CheckWin(char sym)
        {

            for (int vertival = 0; vertival < SIZE_Y; vertival++)
            {
                for (int horizontal = 0; horizontal < SIZE_X; horizontal++)
                {
                    if (CheckLineToHorizontal(vertival, horizontal, sym) >= SIZE_WIN) return true;
                    if (CheckLineToVerticle(vertival, horizontal, sym) >= SIZE_WIN) return true;
                    if (CheckLineToDiagonalFromLeft(sym) >= SIZE_WIN) return true;
                    if (CheckLineToDiagonalFromRight(vertival, horizontal, sym) >= SIZE_WIN) return true;
                }
            }
            return false;
        }

        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();
            do
            {
                playerMove();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }
    }
}
