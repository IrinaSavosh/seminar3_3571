// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть ");
int qw = Convert.ToInt32(Console.ReadLine());

if (qw == 1)
{
    Console.Write("x > 0; y > 0");
}
else if (qw == 2)
{
    Console.Write("x < 0; y > 0");
}
else if (qw == 3)
{
    Console.Write("x < 0; y < 0");
}
else if (qw == 4)
{
    Console.Write("x > 0; y < 0");
}
else Console.WriteLine("Нет такой четверти!");
