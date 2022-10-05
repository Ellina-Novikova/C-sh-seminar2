// Задача 44. Не используя рекурсию вывести первые N чисел Фибоначчи, с 0, 1, ...

// Фибоначчи с рекурсией

// double Fibonacci(int n)  //  Метод Fibonacci
// {
//     if (n == 1 || n ==2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);    
// }

// int N = 5;    //  Программа вызова метода Fibonacci
// for (int i = 1; i <= N; i++)
//     {
//     Console.WriteLine($"{i} F = {Fibonacci(i)}");
//     }

int GetNumber()
{
    Console.WriteLine("Введите целое положительное число!");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n <= 0)
    {
        Console.WriteLine("Введите целое положительное число!");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FibonacciSimple(double[] arr)  // Вывоодит на экран числа Фибоначчи
{     
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2)
        {
            arr[i] = i; 
            Console.WriteLine($"{i+1}F = {arr[i]}"); 
        }
        else 
        {
            arr[i] = arr[i-2] + arr[i-1];
            Console.WriteLine($"{i+1}F = {arr[i]}");
        }     
    }
}

double[] FibonacciSimpleArr(double[] arr)  // Возвращает массив с числами Фибоначчи
{    
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2)
        {
            arr[i] = i;                 
        }
        else 
        {
            arr[i] = arr[i-2] + arr[i-1];                
        }     
    }
    return arr;
}

double[] numberArr = new double[GetNumber()];
Console.WriteLine();
PrintArray(FibonacciSimpleArr(numberArr));
Console.WriteLine();
FibonacciSimple(numberArr);
