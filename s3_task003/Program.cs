// Вводим координаты двух точек и 
// вычисляем расстояние между ними в 2d пространстве

double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double GetDistance(double x1, double y1, double x2, double y2)
{
return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)); 
}

double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
Console.WriteLine("Расстояние между точками равно " + GetDistance(x1, y1, x2,y2));
