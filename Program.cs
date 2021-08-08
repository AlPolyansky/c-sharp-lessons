using System;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskManager.Init();
            // InitGetSumFromArray();
        }

        static int GetSumFromArray(string[,] array)
        {
            if(array.Length != 16)
            {
                throw new CustomExceptions(CustomExceptions.ErrorCodes.MyArraySizeException);
            }

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    try
                    {
                        result += Convert.ToInt32(array[i, j]);
                    }
                    catch
                    {
                        Console.WriteLine($"Ошибка в массиве. Cтрока: {i}, колонка: {j}, значение: {array[i, j]}");
                        throw new CustomExceptions(CustomExceptions.ErrorCodes.MyArrayDataException);
                    }
                }
            }

            return result;
        }

        static void InitGetSumFromArray()
        {
            string[,] array2Db = new string[,] {
                { "1", "2", "3", "4" },
                { "5", "6", "7", "8" },
                { "9", "10", "11", "12" },
                { "13", "14", "15", "16" },
            };

            try
            {
                int result = GetSumFromArray(array2Db);
                Console.WriteLine($"GetSumFromArray result: {result}");
            }
            catch (CustomExceptions ex) when (ex.Code == CustomExceptions.ErrorCodes.MyArrayDataException)
            {
                Console.WriteLine("Ошибка преобразования string к int");
                Console.WriteLine(ex);
            }
            catch (CustomExceptions ex) when (ex.Code == CustomExceptions.ErrorCodes.MyArraySizeException)
            {
                Console.WriteLine("Массив должен быть двумерный и содержать 16 элементов");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
