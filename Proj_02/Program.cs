// 1. По двум заданным числам проверять является ли первое квадратом второго


Console.WriteLine ("Введите первое число");
 int a =
  Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int b = 
  Convert.ToInt32(Console.ReadLine());
  if(b*b==a)
  Console.WriteLine ($" Число {a} является квадратом {b}");

else
Console.WriteLine ($"Число {a} не является квадратом {b}");