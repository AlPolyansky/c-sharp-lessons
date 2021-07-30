using System;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // createDiagonalArray();
            // createPhonebook();
            // revertText();
            createSeaBattle();
        }

        static void createDiagonalArray()
        {
            int[,] matrix = new int[10, 10];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   if(i == j)
                   {
                        matrix[i, j] = j;
                        Console.Write($"{matrix[i, j]} ");
                   } 
                   else
                   {
                        Console.Write(" ");
                   }
                }
                Console.WriteLine();
            }
        }

        static void createPhonebook()
        {
            string[,] phonebookArray = new string[5,2] { 
                { "Петров", "89642345454/agnh@ggg.com" }, 
                { "Сидоров", "89999999999/hello@world.io" }, 
                { "Иванов", "+78584949598/test@gfg.com" },
                { "Петров", "+78584949444/araf@gfg.com" },
                { "Смирнов", "390(30)349-47-35/fgaab@mailpluss.com" },
            };

            for (int i = 0; i < phonebookArray.GetLength(0); i++)
            {
                for (int j = 0; j < phonebookArray.GetLength(1); j++)
                {
                    Console.Write($"{phonebookArray[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        static void revertText()
        {
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(charArray);
        }

        static void createSeaBattle()
        {
            int[,] field = new int[10, 10] {
                { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0 },
            };

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    int currentValue = field[i, j];
                    string fieldItem = currentValue == 1 ? "X" : "O";
                    Console.Write($"{fieldItem} ");
                }
                Console.WriteLine();
            }
        }
    }
}
