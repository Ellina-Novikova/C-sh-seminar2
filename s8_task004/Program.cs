// Частотный словарь двумерного массива

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

void PrintArrayUno(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintArrayString(string[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int[] ArrayDuoToUno(int[,] arr)
{
    int[] arrDuoToUno = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arrDuoToUno[k] = arr[i,j];
            k++;
        }
    }
    return arrDuoToUno;
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int CountDisting(int[] arr)
{    
    SelectionSort(arr);
    int count = 1; 
    for(int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != arr[i + 1]) count++; 
    }
    return count;
}

string[] Dictionary(int[,] arr)
{
    int[] arrayUno = ArrayDuoToUno(arr);
    SelectionSort(arrayUno);
    PrintArrayUno(arrayUno);
    Console.WriteLine("Частотный словарь заданного массива");
    Console.WriteLine();
    string[] dictionary = new string[CountDisting(arrayUno)];
    int i = 0;
    int k = 0;
    int count = 1;
    while (i < arrayUno.Length - 1)
    {
        if (arrayUno[i] == arrayUno[i + 1]) count++;
        else 
        {
            dictionary[k] = $"Элемент {arrayUno[i]} встречается {count} раз";
            k++;
            count = 1;
        }
        i++;
    }
    dictionary[k] = $"Элемент {arrayUno[i]} встречается {count} раз";
    return dictionary;  
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
PrintArrayString(Dictionary(array));
