// Напишите прогармму, которая принимает на вход два числа и проверяет, является ли одно квадратом другого

Console.Clear();
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if(a == Math.Pow(b, 2) || b == Math.Pow(a, 2))
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}