// 
// принимает число А и выдает количество цифр
int GetNumber()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}
    

int GetDigCount(int A)  // количество цифр в числе
{
    int count = 0;
    for(int i = 1; A > 0; i++)
    {
        A = A / 10;
        count ++;
    }
    return count;
}

// int GetDigCount(int A)  // количество цифр в числе
// {
//     int count = 0;
//     while (Math.Abs(A) > 0)
//     {
//         A = A / 10;
//         count ++;
//     }
//     return count;
// }


int B = GetNumber();
Console.WriteLine("В числе " + B + " количество цифр = " + GetDigCount(B));