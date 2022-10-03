// Задача №33. Задать массив. Определить, присутствует ли заданное число в массиве.

void FillArray(int[] arr) //Наполняем массив случ.числами от 1 до 99
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);        
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
void SerchArray(int[] array, int arg)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
            a = 1;  
    }
    if (a == 1)
        Console.WriteLine("Да есть");
    else Console.WriteLine("Нет совпадений");
}

Console.WriteLine("Введите количество элементов массива!");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите число для поиска");
int n = Convert.ToInt32(Console.ReadLine());
SerchArray(array,n);