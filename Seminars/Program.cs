//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Первое число является квадратом второго числа");
// }
// else Console.WriteLine("Первое число НЕ является квадратом второго числа");

// if (number1 == Math.Pow(number2, 2))
// {
//     Console.WriteLine("Квадрат числа " + number2 + " равен " + number1);
// }
// else Console.WriteLine($"Квадрат числа {number2} НЕ равен {number1}");

// if (number1 == Math.Pow(number2, 2))
// {
//     Console.WriteLine("Квадрат числа {0} равен {1}", number2, number1);
// }
// else Console.WriteLine($"Квадрат числа {number2} НЕ равен {number1}");


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

// Console.Write("Введите число: ");
// int N1 = Convert.ToInt32(Console.ReadLine());
// if (N1 < 0)
// {
//     N1 = -1 * N1;
// }
// int N2 = -N1;

// while (N2 <= N1)
// {
//     Console.Write($"{N2} ");
//     N2++;
// }


// for (int i = -N; i <= N; i++)
// {
//     Console.WriteLine(i);
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

// Console.Write("Введите трёхзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int first_number = N / 100;
// int third_number = N % 10;
// int sum = first_number + third_number;
// Console.WriteLine(sum);
// Console.WriteLine(N / 10 % 10)

// string z = "Hello";
// Console.WriteLine(z.Length);

// Console.Write("Введите трёхзначное число: ");
// string a = Console.ReadLine()!;
// if (a.Length == 3)
// {
//     Console.WriteLine(Convert.ToInt32(Convert.ToString(a[0])) + Convert.ToInt32(Convert.ToString(a[2])));

// }
// else
// {
//     Console.WriteLine("Число не трехзначное");
// }

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num = new Random().Next(50, 2000);
// Console.WriteLine(num);
// if (num <= 999 && num >= 100)
// {
//     int num1 = num / 100;
//     int num3 = num % 10;
//     Console.WriteLine(num1 * 10 + num3);
// }
// else
// {
//     Console.WriteLine("Введено не трехзачное число");
// }

// int num = new Random().Next(50, 1000);
// Console.WriteLine(num);

// string num_str = Convert.ToString(num);

// if (num_str.Length == 3)
// {
//     int num1 = Convert.ToInt32(Convert.ToString(num_str[0]));
//     int num3 = Convert.ToInt32(Convert.ToString(num_str[2]));
//     Console.WriteLine(num1 * 10 + num3);
// }
// else
// {
//     Console.WriteLine("Введено не трехзачное число");
// }

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int second_num = num / 10 % 10;
// int third_number = num % 10;
// Console.WriteLine(Math.Pow(second_num, third_number));

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine($"Нет, остаток от деления = {num1 % num2}");
// }

// Напишите программу, которая выводит третью цифру с
// слева или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     Console.WriteLine(num % 10);
// }
// ВТОРОЕ РЕШЕНИЕ:
// string num_str = Convert.ToString(num);
// if (num_str.Length < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else Console.WriteLine(num_str[2]);

