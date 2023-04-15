// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0)
{
    Console.WriteLine($"Число {a} кратно 7 и 23");
}
else if (a % 7 == 0)
{
    Console.WriteLine($"Число {a} кратно 7, но не кратно 23");
}
else if (a % 23 == 0)
{
    Console.WriteLine($"Число {a} не кратно 7, но кратно 23");
}
else
{
    Console.WriteLine($"Число {a} не кратно 7 и не кратно 23");
}

