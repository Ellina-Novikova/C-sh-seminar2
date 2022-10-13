//  Рекурсивный метод деления одного числа на другое без % и /.
// Нужен остаток  и результат от деления.
// вводим целые положительные числа

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RemainderOfDivision(int value, int divider)
{    
    if (value >= divider)
    {
        value -= divider;
        return RemainderOfDivision(value, divider);
    }
    else      
        return value;
}

int[] Division(int value, int divider)
{    
    int[] division = new int[2];
    int resultOfDivision = 0;
    while (value >= divider)
    {
        value -= divider;
        resultOfDivision++;
    }
    division[0] = resultOfDivision;
    division[1] = RemainderOfDivision(value, divider);
    return division;
}

int m = GetNumberFromConsole("Введите делимое число");
int n = GetNumberFromConsole("Введите число делитель");
if (n == 0) Console.WriteLine("На 0 делить нельзя!");
else
{
    Console.WriteLine($"{m} / {n} = {Division(value: m, divider: n)[0]}");
    Console.WriteLine($"Остаток от деления = {Division(value: m, divider: n)[1]}");
}
