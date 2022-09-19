// 2-е число кратно 1-му?

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int Ost ()
{
   int a = number2 % number1; 
   return a;
}
int b = Ost();
if (b ==0)
{
  Console.WriteLine("Второе число кратно первому");  
}
else Console.WriteLine("Второе число не кратно первому. Остаток от деления  " +b);