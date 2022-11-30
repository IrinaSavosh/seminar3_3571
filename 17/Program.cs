// Найти, в какой координатной плоскости находится заданная точка

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть!");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
else Console.WriteLine("Ошибка!!!");