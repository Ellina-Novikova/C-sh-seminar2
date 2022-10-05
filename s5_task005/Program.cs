// Задача №37. Найти произведение пар чисел в массиве 
//(первый и посл элемент, второй и предпоследний и т.д.).
// Результат записать в новом массиве.

void FillArray(int[] arr) //Наполняем массив случ.числами от 1 до 99
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);        
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

int[] PairProd(int[] arr)    // Массив из произведений пар входного массива
{
    int length = 0;     // Определяем длину нового массива
    if (arr.Length % 2 == 0)
        length = arr.Length / 2;
    else 
        length = arr.Length / 2 + 1;

    int[] pairProd = new int[length];   // Наполняем новый массив
    for (int i = 0; i < arr.Length - i; i++)
    {
        if (i == arr.Length - 1 - i)
            pairProd[i] = arr[i];
        else
            pairProd[i] = arr[i] * arr[arr.Length -1 - i];     
    }
    return pairProd;
}

Console.WriteLine("Введите количество элементов массива!");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array);
PrintArray(array);
int[] prod = PairProd(array);
PrintArray(prod);
// PrintArray(PairProd(array));
