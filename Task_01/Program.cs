// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();
int number = new Random().Next(10, 100);
Console.Write("Выбранное случайное число: ");
Console.WriteLine(number);
int first = number/10;
int second = number % 10;
if (first > second)
{
    System.Console.WriteLine("Первое число больше");
}
else if (second > first)
{
    System.Console.WriteLine("Второе число больше");
}
else
{
    System.Console.WriteLine("Числа равны");
}