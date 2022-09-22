// 2-е число кратно 1-му?

int EnterNumber()
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
Void Kratno(int arg1, int arg2)
{
    int c = arg2 % arg1;
    if (c == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Второе число не кратно первому. Остаток от деления  " + c);
    }
}
int number1 = EnterNumber();
int number2 = EnterNumber();
Kratno(number1, number2);