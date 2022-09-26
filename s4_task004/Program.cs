// Вываодит массив из 8 элем, заполненный 1 и 0 в случайном порядке
void FillArray(int[] collection)
{
        for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0,2);
    }
}


void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

// int[] arr = new int[8];
// FillArray(arr);
// PrintArray(arr);

int[] array1 = new int[] {1, 2, 3, 4};
int[] array2 = array1;
// array1[0] = 5;
PrintArray(array1);
array1[0] = 5;
Console.WriteLine();
PrintArray(array2);

