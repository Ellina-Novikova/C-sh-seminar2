// Задача №31. Задать массив из 12 элем.(случайные числа [-9, 9]).
// Найти сумму положительных и сумму отрицательных элементов.

void FillArray(int[] arr) //Наполняем массив случ.числами от 1 до 99
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);        
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int GetSummPositiv(int[] arr)  // Для В1. Сумма положительных
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}

int GetSummNegativ(int[] arr)  // Для В1. Сумма отрицательных
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}

int[] GetSums(int[] arr)    // В2. Суммы положительных и отрицательных
{
    int[] sumArray = new int[2];
    sumArray[0] = 0;
    sumArray[1] = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumArray[0] += arr[i];
        if (arr[i] < 0)
            sumArray[1] += arr[i];
    }
    return sumArray;
}

int[] massiv = new int [12];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Сумма положительных элементов = " + GetSummPositiv(massiv)); // Вывод для Вар1
Console.WriteLine("Сумма отрицательных элементов = " + GetSummNegativ(massiv));

// int[] outMassiv = new int[2];
// outMassiv = GetSums(massiv);
Console.WriteLine("Сумма положительных элементов = " + GetSums(massiv)[0]);  // Вывод для Вар2
Console.WriteLine("Сумма отрицательных элементов = " + GetSums(massiv)[1]);