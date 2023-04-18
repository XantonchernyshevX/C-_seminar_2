// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным

Console.Clear();
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
bool validate (int day)
{
    if (day < 1 || day > 7)
    {
        Console.Write("Это не день недели");
        return false;
    }
    return true;
}
bool weekend(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной");
        return true;
    }
    Console.WriteLine("Это будний день");
    return false;

}
if (validate(day))
{
    weekend(day);
}