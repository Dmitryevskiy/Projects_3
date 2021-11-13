// 0. Вывести квадрат числа
// 1. По двум заданным числам проверять является ли первое квадратом второго
// 2. Даны два числа. Показать большее и меньшее число
// 3. По заданному номеру дня недели вывести его название
// 4. Найти максимальное из трех чисел
// 5.** Написать программу вычисления значения функции y = f(a)
// 6. Выяснить является ли число чётным
// 7. Показать числа от -N до N
// 8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числ
// 10. Показать вторую цифру трёхзначного числа

// 0. Вывести квадрат числа
// int namber(int a)
// {
//     return a*a;
    
// }
                
// Console.WriteLine(namber(344));

//___________________________________

//По двум заданным числам проверять является ли первое квадратом второго
// int a = 300;
// int b = 20;
// int namber(int a, int b) 
// {
//   if (a == b * b)
//   {
//     Console.WriteLine ($"{a} является квадратом {b}");
//   }
//    else
//    {
//     Console.WriteLine ($"{a} не является квадратом {b}");
//    }
// return a;
// }
// namber (a,b);
//_________________________________________________________

//2. Даны два числа. Показать большее и меньшее число

// int Rand(int a, int b)
// {
//   if (a>b)
//   {
//      Console.WriteLine($"наибольшее число {a}");
//   }
//   else
//   {
//      Console.WriteLine($"наибольшее число {b}");
//   }
// return (a);
// }
// Rand(33,45);
//_____________________________________

//3. По заданному номеру дня недели вывести его название

// int day (int a)
// {
//      if(a==1)
// Console.WriteLine ("Сегодня понедельник");
// if(a==2)
// Console.WriteLine ("Сегодня вторник");
// if(a==3)
// Console.WriteLine ("Сегодня среда");
// if(a==4)
// Console.WriteLine ("Сегодня четверг");
// if(a==5)
// Console.WriteLine ("Сегодня пятница");
// if(a==6)
// Console.WriteLine ("Сегодня суббота");
// if(a==7)
// Console.WriteLine ("Сегодня воскресенье");
// return a;
// }
// Console.WriteLine(day(2));
//___________________________________________

//4. Найти максимальное из трех чисел

// int max(int a, int b, int c)
// {
//     int Max = a;
//     if (b>Max)
//     {
//         Max=b;
//     }
//     if (c>Max)
//     {
//         Max = c;
//     }
// return Max;
// }
// Console.WriteLine($"Максимальное число {max(5,35,18)}");
//______________________________________________________________
//6. Выяснить является ли число чётным

// int namber (int a)
// {
//     if (a%2==0)
//     {
//         Console.WriteLine($"Число {a} чётное");
//     }
//     else
//     {
//         Console.WriteLine($"Число {a}  не чётное");
//     }
// return a;
// }
// namber(9);
//___________________________________________________

// 7. Показать числа от -N до N

//  int nambers (int min, int max)
//   {
//    for(int nextElement = min;nextElement<=max;nextElement++)
//    {
//      Console.WriteLine (nextElement);
//    }
//   return min;
//   }
// nambers(-5,10);
//___________________________

// 8. Показать четные числа от 1 до N

// int nambers (int a, int b)
// {
//     for (int min = a; min < b; min++)
//     {
//         if (min%2==0)
//         {
//             Console.WriteLine(min);
//         }
//     }
// return b;
// }
// nambers(1,22);
//____________________________________

// 9. Показать последнюю цифру трёхзначного числ

// int namber (int minValue, int maxValue)
// {
//     int rand = new Random().Next(minValue, maxValue);
//     return rand;
// }
// int nextElement(int a)
// {
//     int N = a%10;
//     return N;
// }
// int b = namber (100,1000);
// Console.WriteLine($"Последняя цифра числа {b} = {nextElement (b)} ");
//________________________________________

// 10. Показать вторую цифру трёхзначного числа

int namber (int minValue, int maxValue)
{
    int rand = new Random().Next(minValue, maxValue);
    return rand;
}
int nextElement(int a)
{
    int N = a/10;
    int e = N%10;
    return e;
}
int b = namber (100,1000);
Console.WriteLine($"Средняя цифра числа {b} = {nextElement (b)} ");