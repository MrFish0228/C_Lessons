﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

if (num % 2 == 0)
{
    Console.Write("Это четное число");
}
else
{
    Console.Write("Это нечетное число");
}