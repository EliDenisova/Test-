// See https://aka.ms/new-console-template for more information

int[] array = new Int32[10];

randomFilling(array,  0, 100);
arrayOutput(array);

Console.WriteLine("введите число, которое надо найти.");
int number = Convert.ToInt32(Console.ReadLine());
string result = search(array, number)
    ? $"число {number} содержится в массиве."
    : $"число {number} не содержится в массиве.";
Console.WriteLine(result);

void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        Console.Write("");
    }
}

bool search(int[] array, int searchNumber)
{
    bool found = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (searchNumber == array[i])
        {
            found = true;
            break;
        }
    }

    return found;
}