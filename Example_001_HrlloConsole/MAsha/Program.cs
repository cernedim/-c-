﻿Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("УРА! ЭТО ЖЕ МАША!!!");
}
else
{
    Console.WriteLine("Добро пожаловать");
    Console.WriteLine(username);
}