// See https://aka.ms/new-console-template for more information

int[] arr = new Int32[8];

randomFilling();
arrayOutput(arr);

int[] randomFilling()
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }

    return arr;
}

void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");

    }
}