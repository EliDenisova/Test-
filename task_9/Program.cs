// See https://aka.ms/new-console-template for more information

int[] arr = new Int32[12];

int positiveNumbersSum = 0;
int negativeNumbersSum = 0;

randomFilling(arr, -9, 9);
arrayOutput(arr);

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            negativeNumbersSum += arr[i];
        }
        else
        {
            positiveNumbersSum += arr[i];
        }
    }

Console.WriteLine();
Console.WriteLine($"сумма положительных чисел {positiveNumbersSum}, " +
                  $"сумма отрицательных чисел {negativeNumbersSum}");

int[] randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
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

