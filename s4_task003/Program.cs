// Произведение от 1 до N

int GetNumber()
{
    int num = 0;
    while (num <= 1)
    {
        Console.WriteLine("Введите положительное число");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int GetProizv1toA(int A)
{
    int proizv = 1;
    for (int i = 1; i <= A; i++)
    {
        proizv = proizv * i;
    }
    return proizv;
}

int A = GetNumber();
Console.WriteLine("Произведение чисел от 1 до " + A + " = " + GetProizv1toA(A));