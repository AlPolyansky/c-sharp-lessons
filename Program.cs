using System;
using System.IO;
using System.Text;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // writeToFle();
            // writeDateToFile();
            // writeToBinaryFile();
            createEmployes();
        }

        static void writeToFle()
        {
            string str = Console.ReadLine();
            File.WriteAllText("file.txt", str);
        }

        static void writeDateToFile()
        {
            File.AppendAllText("startup.txt", $"{DateTime.Now}\n");
        }

        static void writeToBinaryFile()
        {
            Console.WriteLine("Введите число от 0 до 255");
            try
            {
                string str = Console.ReadLine();
                int numbers = Convert.ToInt32(str);

                if (numbers >= 0 && numbers < 255)
                {
                    byte[] arr = Encoding.ASCII.GetBytes(str);
                    File.WriteAllBytes("bytes.bin", arr);
                }
            }
            catch
            {
                Console.WriteLine("Допускаются числа от 0 до 255");
            }

        }

        static void createEmployes()
        {
            Employee[] employeeArray = new Employee[5];
            employeeArray[0] = new Employee("Ivanov Ivan", "Разработчик", "ivivan@mailbox.com", "892312312", 30000, 30);
            employeeArray[1] = new Employee("Краснова Дарья", "Дизайнер", "kd@mailbox.com", "892332142", 50000, 35);
            employeeArray[2] = new Employee("Петров Иван", "Разработчик", "pi@mailbox.com", "8923167777", 160000, 45);
            employeeArray[3] = new Employee("Николаев Даниил", "PO", "nd@mailbox.com", "892323423", 130000, 42);
            employeeArray[4] = new Employee("Анисимова Ольга", "Тестировщик", "ao@mailbox.com", "8922341123", 60000, 41);

            foreach(Employee employee in employeeArray)
            {
                if(employee.Age > 40)
                {
                    employee.Info();
                }
            }
        }
    }
}
