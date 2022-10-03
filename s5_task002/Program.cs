// // Задача №32. Замена элементов массива. положительные на соответств отриц. и наоборот.

void FillArray(int[] arr) //Наполняем массив случ.числами от -10 до 11
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);        
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

void ChangeArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;        
    }
}

Console.WriteLine("Введите количество элементов массива!");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);


