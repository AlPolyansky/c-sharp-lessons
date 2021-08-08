using System;
using System.Diagnostics;

namespace LessonApp
{
    static class TaskManager
    {
        public static void Init()
        {
            RenderProcessList();
            RenderInfo();
            InitKeyWalker();
        }

        static void InitKeyWalker()
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.K)
                {
                    InitUserInput();
                }

                if (cki.Key == ConsoleKey.L)
                {
                    RenderProcessList();
                    RenderInfo();
                }
            }
            while (cki.Key != ConsoleKey.Escape);
        }

        static void InitUserInput()
        {
            Console.WriteLine("\nВведите ID процесса или имя. Чтобы выйти введите q");

            string processValue = Console.ReadLine();
            bool isProcessDigits = IsDigits(processValue);

            if(processValue.ToLower() == "q")
            {
                RenderInfo();
                return;
            }

            if (isProcessDigits)
            {
                KillProcessById(processValue);
            }
            else
            {
                KillProcessesByName(processValue);
            }
        }

        static void KillProcessById(string processValue)
        {
            try
            {
                Process currentProcess = Process.GetProcessById(Convert.ToInt32(processValue));
                currentProcess.Kill();
                Console.WriteLine($"Процесс {processValue} удален.");
            } catch
            {
                Console.WriteLine($"Процесс {processValue} не найден");
            } finally
            {
                InitUserInput();
            }

        }

        static void KillProcessesByName(string processValue)
        {
            Process[] currentProcesses = Process.GetProcessesByName(processValue);
            if (currentProcesses.Length == 0)
            {
                Console.WriteLine("Процессы не найдены.");
            }

            foreach (Process currentProcess in currentProcesses)
            {
                if (currentProcess.ProcessName == processValue)
                {
                    currentProcess.Kill();
                    Console.WriteLine($"Процессы {processValue} удалены.");
                }
            }

            InitUserInput();
        }

        static void RenderProcessList()
        {
            Process[] localAll = Process.GetProcesses();
            foreach (Process item in localAll)
            {
                Console.WriteLine($"ID: {item.Id}, Имя процесса: {item.ProcessName}");
            }
        }

        static void RenderInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите Escape (Esc) чтобы закрыть приложение:");
            Console.WriteLine("Нажмите l чтобы вывести список процессов:");
            Console.WriteLine("Нажмите k чтобы удалить процесс:");
        }

        static bool IsDigits(string str)
        {
            if (str == null || str == "") return false;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] ^ '0') > 9) 
                {
                    return false;
                }
            }
 
            return true;
        }
    }
}
