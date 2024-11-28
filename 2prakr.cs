using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Console.WriteLine("Поддерживаемые операции: +, -, *, /, maf1 - maf10");

            while (true)
            {
                try
                {
                    // Ввод первого числа
                    Console.WriteLine("Введите первое число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Ввод операции
                    Console.WriteLine("Введите операцию:");
                    string operation = Console.ReadLine().ToLower();

                    // Ввод второго числа
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // Обработка операции
                    double result = operation switch
                    {
                        "+" => num1 + num2,
                        "-" => num1 - num2,
                        "*" => num1 * num2,
                        "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Деление на ноль невозможно."),
                        "maf1" => num1 % num2,                                 // Остаток от деления
                        "maf2" => Math.Pow(num1, num2),                       // Возведение в степень
                        "maf3" => Math.Sin(num1),                             // Синус первого числа
                        "maf4" => Math.Cos(num1),                             // Косинус первого числа
                        "maf5" => Math.Tan(num1),                             // Тангенс первого числа
                        "maf6" => Math.Log(num1, num2),                       // Логарифм num1 по основанию num2
                        "maf7" => num1 * num2 + num1 - num2,                  // Сложная арифметическая операция
                        "maf8" => Math.Exp(num1) - Math.Exp(num2),            // Разность экспонент
                        "maf9" => Math.Sqrt(Math.Abs(num1 - num2)),           // Корень из абсолютной разности
                        "maf10" => Math.Round(num1 / num2, 2),                // Деление с округлением до двух знаков
                        _ => throw new InvalidOperationException("Неизвестная операция.")
                    };

                    // Вывод результата
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}