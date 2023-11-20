﻿/*
Виды трансляции:
 - Компеляций(C#, C++, Paskal...)
 - Интерпритация(Python, Javascript)

C#:(Статическая типизация данных) int n = 10; -> int - тип данных, n - имя переменной, 10 - значение переменной.
Python:(Динамическая типизация данных) n = 10 -> Тип данных определяется автоматически.
Задали имя и значение переменной.
*/

/* Ввод и вывод двнных
Console.Clear(); // Отчистка консоли.
Console.Write("Hello, World "); // Cтроки внутр C# обрамляются двоиными ковычками ("...")!!!
Console.Write("Hello, World "); // Write - Написать данные в консоль.
Console.Write("Hello, World\n"); // \n - принудительный перенос на следующую строчку.
Console.WriteLine("Hello, Ivan"); // WriteLine - выыод данных с новой строки.
// Reab - Считать данные из консоли.
*/

/*
Console.Clear(); // Отчистка консоли.
Console.Write("Введите имя: ");
string name = Console.ReadLine()!; // Волнистая линия предупреждает о каких либо нюансов. ! - Говорит программе "не переживай я в курсе"
Console.WriteLine($"Привет, {name}!"); // Форматированный выыод данных
// $ - добавляет в строку вывода переменную, если ее обрамить в ({}) - {переменная}.
*/

/*
Console.Clear();
Console.Write("Введите 1-ое число: ");
// Преобразование вводимого числа в тип данных int.
int n = int.Parse(Console.ReadLine()!); // Быстрее чем "int m = Convert.ToInt32(Console.ReadLine());"
Console.Write("Введите 2-ое число: ");
double m = int.Parse(Console.ReadLine()!);
// "465" -> 465 -> n = 465
Console.WriteLine($"{n} + {m} = {n + m}");
Console.WriteLine($"{n} - {m} = {n - m}");
Console.WriteLine($"{n} * {m} = {n * m}");
Console.WriteLine($"{n} : {m} = {n / m} (остаток {n % m})");
*/

