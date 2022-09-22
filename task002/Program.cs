// Вывести трехзначное число и удалить вторую цифру.

int CreateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int DelSecondDigit(int number)
{
    int Sot = number / 100;
    int Ed = number % 10;

    int numberNew = Sot *10 + Ed;
    return numberNew;
}

int a = CreateNumber();
Console.WriteLine(a);
int numberNew = DelSecondDigit(a);
Console.WriteLine(numberNew);