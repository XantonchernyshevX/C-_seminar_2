// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.Write("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));

int GetThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(GetThirdDigit(number));
}