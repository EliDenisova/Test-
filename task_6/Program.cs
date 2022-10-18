// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

int count = 0;

if (num == 0)
{
    count = 1;
}
else while(num != 0)
{
    num /= 10;
    count += 1;
}

Console.WriteLine(count);