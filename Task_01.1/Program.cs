// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа с помощью методов

System.Console.WriteLine("min");
int min = ReadInt();

System.Console.WriteLine("max");
int max = ReadInt();

int ReadInt()
{return int.Parse(Console.ReadLine());}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int number = GetRandomNumber(min, max);
System.Console.WriteLine(number);

if (GetFirstDigit(number) > GetSecondDigit(number))
{
    System.Console.WriteLine("first");
}
else
{
    System.Console.WriteLine("second");
}

int GetFirstDigit(int number){return number/10;}

int GetSecondDigit(int number){return number % 10;}