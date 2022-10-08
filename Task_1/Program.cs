
Console.WriteLine("Введите координаты");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Это четверть 1");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("Это четверть 2");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("Это четверть 3");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("Это четверть 4");
    }
}

