// See https://aka.ms/new-console-template for more information


int num = int.Parse(Console.ReadLine());

int result = addition(num);

Console.WriteLine(result);


int x = addition(num + 1);

Console.WriteLine(x);

int addition(int number)
{
    int count = 1;
    
    for (int i = 1; i <= number; i++)
    {
        count = count * i; // count *= i;
    }

    return count;
}