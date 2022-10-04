// Перевернуть массив в обратном порядке. [1,2,3,4,5] в [5,4,3,2,1]

void FillArray(int[] arr) //Наполняем массив случ.числами от -10 до 10
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
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int[] SwapArray(int[] arr)   // С помощью временного массива
{
    int[] tempArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       tempArr[arr.Length-1-i] = arr[i];
    }
    return tempArr;
}

int[] SwapArrayTwo(int[] arr)  // С помощью временной переменной
{
    int swap;
    for (int i = 0; i < arr.Length / 2; i++)
    {
       swap = arr[arr.Length-1-i];
       arr[arr.Length-1-i] = arr[i];
       arr[i] = swap;
    }
    return arr;
}

int[] array = new int[5];  // инициализация массива
FillArray(array);
PrintArray(array);

Console.WriteLine("swap1");  // первый разворот
int[] arraySw1 = SwapArray(array);
PrintArray(arraySw1);    // Вывод с инициализацией нового выходного массива arraySw1
PrintArray(SwapArray(array));  // Вывод без инициализации нового массива

Console.WriteLine("swap2");  //  Второй разворот
PrintArray(SwapArrayTwo(SwapArray(array))); // Вывод без обращения к новому массиву
PrintArray(SwapArrayTwo(arraySw1));   //  Вывод с ипользованием массива arraySw1