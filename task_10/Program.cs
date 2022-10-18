// See https://aka.ms/new-console-template for more information

int[] array = new Int32[4];

randomFilling(array, -9, 10);
arrayOutput(array);
signChange(array);
arrayOutput(array);

void signChange(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

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
    }
    Console.WriteLine();
}