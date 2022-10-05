// Программа создает копию заданного массива с помощью поэлементного копирования

void FillArray(int[] arr) //Наполняем массив 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);        
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

int[] arrayFrom = new int[10];
FillArray(arrayFrom);
PrintArray(arrayFrom);
int[] arrayTo = CopyArray(arrayFrom);
PrintArray(arrayTo);

