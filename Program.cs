using System;
using ConsoleTable;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // getMiddleTemperature();
            // getMonth();
            // isEvenNumber();
            getCheckList();
        }

        static void getMiddleTemperature()
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            string minTemperature = Console.ReadLine();

            Console.WriteLine("Введите максимальную температуру за сутки");
            string maxTemperature = Console.ReadLine();

            int middlteTemperature = (Convert.ToInt32(minTemperature) + Convert.ToInt32(maxTemperature)) / 2;

            Console.WriteLine($"Cреднесуточная температура: {middlteTemperature}");
        }

        static void getMonth()
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int monthIndex = Convert.ToInt32(Console.ReadLine());
            string result = "";
            switch(monthIndex)
            {
                case 1:
                    result = "Январь";
                    break;
                case 2:
                    result = "Февраль";
                    break;
                case 3:
                    result = "Март";
                    break;
                case 4:
                    result = "Апрель";
                    break;
                case 5:
                    result = "Май";
                    break;
                case 6:
                    result = "Июнь";
                    break;
                case 7:
                    result = "Июль";
                    break;
                case 8:
                    result = "Август";
                    break;
                case 9:
                    result = "Сентябрь";
                    break;
                case 10:
                    result = "Октябрь";
                    break;
                case 11:
                    result = "Ноябрь";
                    break;
                case 12:
                    result = "Декабрь";
                    break;
                default:
                    break;
            }

            Console.WriteLine(result != "" ? $"Это {result}" : "Порядковый номер не верный");
        }

        static void isEvenNumber()
        {
            Console.WriteLine("Введите число");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            string result = Convert.ToBoolean(userNumber % 2) ? "нечетное" : "четное";

            Console.WriteLine($"Это число {result}");
        }


        static void getCheckList()
        {
            int priceProduct1 = 100;
            int priceProduct2 = 50;
            int resultPrice = priceProduct1 + priceProduct2;

            string productName1 = "Товар 1";
            string productName2 = "Товар 2";

            Table.PrintLine();
            Table.PrintRow("", "Цена", "Товар");
            Table.PrintLine();
            Table.PrintRow("", Convert.ToString(priceProduct1), productName1);
            Table.PrintRow("", Convert.ToString(priceProduct2), productName2);
            Table.PrintLine();
            Table.PrintRow("Итого", Convert.ToString(resultPrice), "");
            Console.ReadLine();
        }
    }
}
