// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число: ");
// string numbers = Console.ReadLine()!;

// if (numbers.Length<3) Console.WriteLine("Введено неверное число.");
// else Console.WriteLine($"Вторая цифра введённого числа - {numbers[1]}.");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число (до 100 000): ");
// string numbers = Console.ReadLine()!;
// if (numbers.Length>5) Console.WriteLine("Введённое число не соответствует условию до 100 000.");
// else 
// {
//     if (numbers.Length<3) Console.WriteLine("Третьей цифры в введённом числе нет.");
// else Console.WriteLine($"Третья цифра введённого числа - {numbers[2]}.");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number>=1 && number<=5) Console.WriteLine("Нет (день не является выходным).");
// else 
// {
//     if (number>5 && number<=7) Console.WriteLine("Да (день является выходным).");
//     else Console.WriteLine("Введено неверное число.");
// }
