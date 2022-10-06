// задача 51. Сумма элементов главной диагонали [0,0], [1,1],[2,2]

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

int SummArrayDiagonal(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i,j];
            }            
        }
    }
    return sum;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cумма элементов главной диагонали = {SummArrayDiagonal(array)}");
