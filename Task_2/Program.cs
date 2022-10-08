// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите номер четверти");

int num = Convert.ToInt32(Console.ReadLine());


if (num > 0 && num < 5)
{
    if (num == 1)
    {
        Console.WriteLine("x > 0 и y > 0");
    }
    if (num == 2)
    {
        Console.WriteLine("x < 0 и y > 0");
    }
    if (num == 3)
    {
        Console.WriteLine("x < 0 и y < 0");
    }
    if (num == 4)
    {
        Console.WriteLine("x > 0 и y < 0");
    }
}
