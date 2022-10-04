// Принимает 3 числа и проверяет, может ли существовать 
// треугольник с такими сторонами.
void FillArray(int[] arr) //Наполняем массив 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} числo");
        arr[i] = Convert.ToInt32(Console.ReadLine());        
    }
}

// Вариант 1. Ищет мах число, проверяет, что оно меньше, чем сумма остальных
void CheckArray(int[] arr)  
{
    int max = arr[0];
    int indMax = 0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];          
        if (arr[i] > max)
        {
            max = arr[i];
            indMax = i;         
        }            
    }    
    sum = sum - arr[indMax];    
    if (arr[indMax] < sum)
        Console.WriteLine("Да! Такой треугольник может существовать");
    else 
        Console.WriteLine("Нет! Такой треугольник не может существовать");
}

// Вариант 2.  Сравниваем суммы каждой пары сторон с третьей
void CheckTriArr(int[] arr)
{
    if (arr[0] + arr[1] > arr[2] && 
        arr[1] + arr[2] > arr[0] && 
        arr[2] + arr[0] > arr[1])
        Console.WriteLine("Да! Такой треугольник может существовать");
    else 
        Console.WriteLine("Нет! Такой треугольник не может существовать");
}

int[] array = new int[3];
FillArray(array);
CheckArray(array);
Console.WriteLine();
CheckTriArr(array);










