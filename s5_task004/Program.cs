// Задача №35. Задать массив из 123 случ чисел. Определить, сколько элементов в диапазоне[10, 99].

void FillArray(int[] arr) //
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200, 201);        
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

// Вар1. Поиск количества элементов массива в диапазоне [10, 99]
void SerchArray(int[] array)  
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
            count ++;  
    }
    Console.WriteLine("Количество элементов массива от 10 до 99 = " + count);
}

// Вар2. Поиск количества элементов массива в диапазоне [arg1, arg2]
void SerchIntervalArray(int[] array, int arg1, int arg2)  
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= arg2 && array[i] >= arg1)
            count ++;  
    }
    Console.WriteLine($"Количество элементов массива от {arg1} до {arg2} = " + count);
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
SerchArray(array);  // Вывод для Вар1.
SerchIntervalArray(array, 10, 99); // Вывод для Вар2.
