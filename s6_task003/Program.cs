// Перевод числа из 10 системы в двоичную

int GetNumber()
{
    Console.WriteLine("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Binar(int number)
{
    int index = 0;
    int tempN = number;
    while (tempN > 0)
    {
        index++;
        tempN /= 2;
    }
    int[] bit = new int[index];
    for (int i = 0; i < index; i++)
    {        
        bit[index - 1-i] = number % 2;
        number /= 2;
    }
    return bit;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



int a = GetNumber();
int[] binArray = Binar(a);
PrintArray(binArray);
PrintArray(Binar(a));