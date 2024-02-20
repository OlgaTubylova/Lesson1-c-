// //Напишите программу, которая на вход
// //принимает два целых числа и проверяет,
// //является ли первое число квадратом второго.

// // Console.Write("Введите первое число: ");
// // int number1 = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите второе число: ");
// // int number2 = Convert.ToInt32(Console.ReadLine());

// // if (number1 == number2 * number2)
// // {
// //     Console.WriteLine("Первое число является квадратом второго числа");
// // }
// // else Console.WriteLine("Первое число НЕ является квадратом второго числа");

// // if (number1 == Math.Pow(number2, 2))
// // {
// //     Console.WriteLine("Квадрат числа " + number2 + " равен " + number1);
// // }
// // else Console.WriteLine($"Квадрат числа {number2} НЕ равен {number1}");

// // if (number1 == Math.Pow(number2, 2))
// // {
// //     Console.WriteLine("Квадрат числа {0} равен {1}", number2, number1);
// // }
// // else Console.WriteLine($"Квадрат числа {number2} НЕ равен {number1}");


// // Напишите программу, которая на вход принимает
// // целое число N, а на выходе показывает все целые
// // числа в промежутке от -N до N.

// // Console.Write("Введите число: ");
// // int N1 = Convert.ToInt32(Console.ReadLine());
// // if (N1 < 0)
// // {
// //     N1 = -1 * N1;
// // }
// // int N2 = -N1;

// // while (N2 <= N1)
// // {
// //     Console.Write($"{N2} ");
// //     N2++;
// // }


// // for (int i = -N; i <= N; i++)
// // {
// //     Console.WriteLine(i);
// // }

// // Напишите программу, которая принимает на вход
// // трёхзначное целое число и на выходе показывает сумму
// // первой и последней цифры этого числа.

// // Console.Write("Введите трёхзначное число: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// // int first_number = N / 100;
// // int third_number = N % 10;
// // int sum = first_number + third_number;
// // Console.WriteLine(sum);
// // Console.WriteLine(N / 10 % 10)

// // string z = "Hello";
// // Console.WriteLine(z.Length);

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
