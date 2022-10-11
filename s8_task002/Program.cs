// Задача №55. Задать двумерный масив. Заменить строки на столбцы. Сообщить, если это не возможно.

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

int[,] TransponationArray(int[,] arr)
{
    int[,] transArray = InitializateArray(arr.GetLength(1),arr.GetLength(0));
    //int[,] transArray = new int[arr.GetLength(1),arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            transArray[j,i] = arr[i,j];
        }
    }
    return transArray;
}

void ChangeLinesToCollumnsArray(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
        Console.WriteLine("Невозможно поменять строки на столбцы");
    else
{
        TransponationArray(arr);
        PrintArray(TransponationArray(arr));   
}
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
ChangeLinesToCollumnsArray(array);
