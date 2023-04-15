// Напишите прогамму, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.Clear();
int number = new Random().Next(100, 1000);
Console.Write("Случайное трехзначное число: ");
Console.WriteLine(number);
//int a = number/100;
//int b = number % 10;
Console.Write($"Число {number} с удаленной второй цифрой: ");
Console.Write("" + number/100 + number % 10);