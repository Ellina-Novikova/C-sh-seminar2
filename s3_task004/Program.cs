// Вводим число N и выводим таблицу квадратов от 1 до N
int GetNumber()
{
    Console.WriteLine("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintPow(int number)
{
int count = 1;
while (count <= number)
{
    Console.WriteLine("Квадрат " + count + " = " + Math.Pow(count, 2));
    count ++;
}
}

PrintPow(GetNumber());
