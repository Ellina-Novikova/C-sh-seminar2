// Вывести заданную цифру числа
int GetNumber()
{
    int num = 0;
    while (LengthNum(num) <= 2)
    {
        Console.WriteLine("Введите число!");
        num = Convert.ToInt32(Console.ReadLine());
    }    
    return num;
}

int LengthNum(int Number) // Получение количества цифр в числе
{
    int DigCount=0;
    while(Math.Abs(Number)>0)
    {
        Number=Number/10;
        DigCount++;
    }
    return DigCount;
}

int GetDigitFromNumber(int number, int index)
{
    int num = number/Convert.ToInt32(Math.Pow(10,LengthNum(number)-index))%10;
    return num;
}

int num = GetNumber();
Console.WriteLine("Первая цифра: " + GetDigitFromNumber(num,1));
Console.WriteLine("Вторая цифра: " + GetDigitFromNumber(num,2));
Console.WriteLine("Третья цифра: " + GetDigitFromNumber(num,3));
Console.WriteLine("Четвертая цифра: " + GetDigitFromNumber(num,4));
Console.WriteLine("Пятая цифра: " + GetDigitFromNumber(num,5));
