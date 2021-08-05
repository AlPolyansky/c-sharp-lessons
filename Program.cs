using System;
using System.Text;

namespace LessonApp
{

    enum Seasons
    {
        Winter = 0,
        Spring = 1,
        Summer = 2,
        Autumn = 4,
    }
    class Program
    {
        static void Main(string[] args)
        {
            // RenderUsersInfo();
            // RenderNumbersSumm();
            // RenderSeasson();
            // RenderFibonacciSeries();
            ConvertStringToWithDots();
        }

        static string GetFullName(string firstName = "", string lastName = "", string patronymic = "")
        {
            return $"{firstName} {lastName} {patronymic}";
        }

        static int getNumbersSumm(string numbersString = "")
        {
            string[] splited = numbersString.Split(" ");
            int result = 0;
            foreach (string number in splited)
            {
                result += Convert.ToInt32(number);
            }
            return result;
        }

        static Seasons GetSeason(int month)
        {
            switch (month)
            {
                case 0:
                case 1:
                case 2:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default:
                    throw new Exception("Неверное число");
            }
        }

        static string ConvertSeassonsToRu(Seasons season)
        {
            switch (season)
            {
                case Seasons.Winter:
                    return "зима";
                case Seasons.Spring:
                    return "весна";
                case Seasons.Summer:
                    return "лето";
                case Seasons.Autumn:
                    return "осень";
                default:
                    return "";
            }
        }

        public static int FibonacciSeries(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            return FibonacciSeries(number - 1) + FibonacciSeries(number - 2);
        }


        /* ======== Методы вывода ======== */

        static void RenderSeasson()
        {
            try
            {
                Console.WriteLine("Введите номер месяца");
                int month = Convert.ToInt32(Console.ReadLine());
                string seasonText = ConvertSeassonsToRu(GetSeason(month - 1));
                Console.WriteLine($"{month} {seasonText}");
            } catch
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
        }

        static void RenderUsersInfo()
        {
            string user1 = GetFullName("Иванов", "Иван", "Иванович");
            string user2 = GetFullName("Сергеев", "Максим", "Анатольевич");
            string user3 = GetFullName("Васильев", "Андрей", "Михайлович");

            Console.WriteLine(user1);
            Console.WriteLine(user2);
            Console.WriteLine(user3);
        }

        static void RenderNumbersSumm()
        {
            Console.WriteLine("Введите числа через пробел");
            string numbersString = Console.ReadLine();
            Console.WriteLine(getNumbersSumm(numbersString));
        }

        static void RenderFibonacciSeries()
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 10;

            Console.WriteLine(FibonacciSeries(num1));
            Console.WriteLine(FibonacciSeries(num2));
            Console.WriteLine(FibonacciSeries(num3));
        }

        static void ConvertStringToWithDots()
        {
            string str = " Предложение один Теперь предложение два Предложение три";
            StringBuilder stringBuilder = new StringBuilder(str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (Char.IsUpper(str[i])){
                    stringBuilder[i - 1] = '.';
                    stringBuilder.Insert(i, ' ');
                }
            }

            stringBuilder.Remove(0, 2);
            stringBuilder.Append('.');
            Console.WriteLine(stringBuilder);
        }
    }
}
