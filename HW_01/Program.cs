﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse((Console.ReadLine()));
if(a >= 100 & a < 1000)
{
    Console.Write($"Вторая цифра в числе {a}: ");
    Console.Write((a/10) % 10);
}
else
{
    Console.WriteLine("Введено неверное число. Введите трехзначное");
}
