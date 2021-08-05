using System;

namespace LessonApp
{
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }

        public Employee(string fullName, string position, string email, string phone, float salary, int age)
        {
            FullName = fullName;
            Position = position;
            Email = email;
            Phone = phone;
            Salary = salary;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"ФИО: {FullName}, Должность: {Position}, email: {Email}, телефон: {Phone}, зарплата: {Salary}, возраст: {Age}.");
        }
    }
}
