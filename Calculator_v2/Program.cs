using System;
using System.Security.Cryptography.X509Certificates;

while (true)
{
    Console.WriteLine("Выберите операцию");
    Console.WriteLine("1." + "Сложить 2 числа ");
    Console.WriteLine("2." + "Вычесть первое из второго");
    Console.WriteLine("3." + "Перемножить два числа");
    Console.WriteLine("4." + "Разделить первое на второе");
    Console.WriteLine("5." + "Найти квадратный корень из числа");
    Console.WriteLine("6." + "Найти 1 процент из числа");
    Console.WriteLine("7." + "Найти факториал");
    Console.WriteLine("8." + "Возвести в степень N первое число");
    Console.WriteLine("9." + "Выйти из программы");

    Console.Write("Введите номер операции:");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 9)
    {
        Console.WriteLine("Программа завершена.");
        break;
    }


    double total = 0;

    while (choice != 9)
    {
        if (choice == 1)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            total = num1 + num2;
            Console.WriteLine("Результат:" + total);
            break;
        }
        if (choice == 2)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            total = num1 - num2;
            Console.WriteLine("Результат:" + total);
            break;
        }
        if (choice == 3)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            total = num1 * num2;
            Console.WriteLine("Результат:" + total);
            break;
        }
        if (choice == 4)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            total = num1 / num2;
            if (num2 == 2) ;
            {
                Console.WriteLine("Нельзя делить на ноль!");
                break;
            }
            Console.WriteLine("Результат:" + total);
            break;

        }
        if (choice == 5)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат:" + Math.Sqrt(num1));



            break;
        }
        if (choice == 6)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            total = num1 / 100;
            Console.WriteLine("Результат:" + total);
            break;
        }
        if (choice == 7)
        {

            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact *= x;
            }
            Console.WriteLine("Результат:" + fact);
            break;

        }
        if (choice == 8)
        {
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите степень:");
            double n = double.Parse(Console.ReadLine());
            total = Math.Pow(num1, n);
            Console.WriteLine("Результат:" + total);
            break;
        }

    }



}

