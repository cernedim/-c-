﻿// Виды трансляции:
//  - Компеляций(C#, C++, Paskal...)
//  - Интерпритация(Python, Javascript)

// C#:(Статическая типизация данных) int n = 10; -> int - тип данных, n - имя переменной, 10 - значение переменной.
// Python:(Динамическая типизация данных) n = 10 -> Тип данных определяется автоматически.
// Задали имя и значение переменной.


//  Ввод и вывод двнных
// Console.Clear(); // Отчистка консоли.
// Console.Write("Hello, World "); // Cтроки внутр C# обрамляются двоиными ковычками ("...")!!!
// Console.Write("Hello, World "); // Write - Написать данные в консоль.
// Console.Write("Hello, World\n"); // \n - принудительный перенос на следующую строчку.
// Console.WriteLine("Hello, Ivan"); // WriteLine - выыод данных с новой строки.
// // Reab - Считать данные из консоли.


// Console.Clear(); // Отчистка консоли.
// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!; // Волнистая линия предупреждает о каких либо нюансов. ! - Говорит программе "не переживай я в курсе"
// Console.WriteLine($"Привет, {name}!"); // Форматированный выыод данных
//  // $ - добавляет в строку вывода переменную, если ее обрамить в ({}) - {переменная}.



// Console.Clear();
// Console.Write("Введите 1-ое число: ");
//  // Преобразование вводимого числа в тип данных int.
// int n = int.Parse(Console.ReadLine()!); // Быстрее чем "int m = Convert.ToInt32(Console.ReadLine());"
// Console.Write("Введите 2-ое число: ");
// double m = int.Parse(Console.ReadLine()!);
//  // "465" -> 465 -> n = 465
// Console.WriteLine($"{n} + {m} = {n + m}");
// Console.WriteLine($"{n} - {m} = {n - m}");
// Console.WriteLine($"{n} * {m} = {n * m}");
// Console.WriteLine($"{n} : {m} = {n / m} (остаток {n % m})");


//  Звдвние 1.
// Напишите программу, которая на взод
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10   => нет
// a = 9, b = -3   => да
// a = -3, b = 9   => нет

//  Задача 1 - Решение.

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
//  = - деиствие присвоения значения.
//  == - проверка на раыенство значений.
//  != - проверка на неравенство.
// if (m * m == n) // ; Запрещено ставить в конце if, else, while.
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");
//  Фигурныескобки нкжно стравить когда внутри конструкции выполняется 2 или более строчки.


//  Задача 2

//  Напишите программу, котораяна вход принимает 
//  целое число N, а на выходе показывает все целые 
//  числа в промежутке от -N до N.

// Задача 2 (Решение 1)
// Console.Clear();
// int n = int.Parse(Console.ReadLine()!);
//  //for(begin, condition, step) begin - начальное значение с которого мы идем.
//                              condition - условие до которого мы идем.
//                              step - шаг с которым мы идем.
// for (int i = -n; i <= n; i++)// (i = -n i) == (i = (-1) * n)
// Console.Write($"{i} ");

// Задача 2 (Решение 2)
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int i = -n;
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }

//  Задача 3

//  Напишите программу, которая принимает на вход
//  трехначное целое число и на выходе показывает сумму
//  первой и последней цифры этого числа.
//  пример:
//  456 => 10.
//  782 => 9.
//  312 => 5.

// //  Задача 3 (Решение)
// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// // 456 : 10 = 45 (остаток 6)
// // 456 : 100 = 4 (остаток 56)
// int n3 = n % 10;
// int n1 = n / 100;
// Console.Write(n1 + n3);

// // ДЗ
// public class Answer
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber < secondNumber)
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         else if (firstNumber > secondNumber)
//             Console.WriteLine($"Второе число `{secondNumber}` меньше чем первое число `{firstNumber}`");
//         else
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 9;
//             secondNumber = 6;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// Console.WriteLine("Число " + {num} +" нечётное");
Console.Clear();
Console.WriteLine(«Введите число»);
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
     Console.WriteLine($"Число `{a}` чётное");
}
else
{
    Console.WriteLine($"Число `{a}` нечётное");
}