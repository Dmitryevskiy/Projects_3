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

// int namber (int minValue, int maxValue)
// {
//     int rand = new Random().Next(minValue, maxValue);
//     return rand;
// }
// int nextElement(int a)
// {
//     int N = a/10;
//     int e = N%10;
//     return e;
// }
// int b = namber (100,1000);
// Console.WriteLine($"Средняя цифра числа {b} = {nextElement (b)} ");
//_________________________________________________________
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// **  20. Задать номер четверти, показать диапазоны для возможных координат

//______________________________________________________________
//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int namber (int minValue, int maxValue)
// {
//     int arrNew = new Random().Next(minValue, maxValue);
//     return arrNew;
// }
// int calk (int a)
// {
//    int r = a%10;
//    int n = a/10;
   
//     int max = r;
//     if (n>max)
//       {
//           max = n;
//       }
// return max;
// }
// int N = namber (10,99);
// Console.WriteLine($"Наибольшая цифра числа {N} = {calk(N)}");       
//_________________________________________________________

// 12. Удалить вторую цифру трёхзначного числа
// int rand (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int A =  rand (99,999);
// Console.WriteLine($"Первая и последняя цифры числа {A}");

// int N (int A)
// {
//   int b =  A % 10;
//   int f = A/100;
//  Console.WriteLine($" {f} {b}");
//  return A;
// }
// N (A);
//_________________________________
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// void rand (int a, int b)
// {
//     if (a%b==0)
//     {
//         Console.WriteLine($"Число {b} кратно {a}");
//     }
//     else
//     {
//         Console.WriteLine($"Число {b} не кратно {a} остаток от деления = {a%b}");
//     }
// }
// rand (6,4);

// // int A =  rand (99,999);
// // int newRand (int minValue, int maxValue)
// // {
// //     int name = new Random().Next(minValue,maxValue);
// //     return  name;
// // }
// // int B =  newRand (99,999);
// // int rezalt (int a, int b)
// // {
// //     if (a%b==0)
// //     {
// //         Console.WriteLine($"Число {b}кратно заданному {a}");
// //     }
// //     else
// //     {
// //         int c = a%b;
// //         Console.WriteLine($"Число {b} не кратно заданному  {a} остаток от деления равен {c}");
// //     }
// // return a;
// // }
// // rezalt(A,B);
//______________________________________________________

// 14. Найти третью цифру числа или сообщить, что её нет

// int faind (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int A =  faind (0,999);
// void rezalt (int a)
// {
//     if (a/100>0)
//     {
//         int c = a%10;
//         Console.WriteLine($"Третья цифра числа {a} = {c}");
//     }
//     else
//     {
//         Console.WriteLine("Третьeй цифры нет");
//     }
// }
// rezalt(A);
//____________________________________

// 15. Дано число. Проверить кратно ли оно 7 и 23

// int faind (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int A =  faind (23,999);
// void nambers (int a)
// {
// if (a%7==0)
// {
//     Console.WriteLine($"Число {a} кратно {7}");
// }
// else
// {
//     Console.WriteLine($"Число {a} не кратно {7}");
// }
// if (a%23==0)
// {
//     Console.WriteLine($"Число {a} кратно {23}");
// }
// else
// {
//     Console.WriteLine($"Число {a} не кратно {23}");
// }
// }
// nambers(A);
//_________________________________

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// int namber (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int A =  namber (1,8);
// void day (int n)
// {
//     if (n==6)
//     {
//         Console.WriteLine($"{n}-й день недели - Выходной");
//     }
//     if (n==7)
//     {
//         Console.WriteLine($"{n}-й день недели - Выходной");
//     }
//     if (n<6)
//     {
//         Console.WriteLine($"{n}-й день недели - не выходной");
//     }
// }   
// day(A);
//_______________________________________________

// 17. По двум заданным числам проверять является ли одно квадратом другого

// int namber (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int A =  namber (2,2);
// int namb (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int B =  namb (4,4);
// void newNambers (int a, int b)
// {
//     if (a*a ==b)
//     {
//         Console.WriteLine($"Число {b} является квадратом {a}");
//     }
//     else
//     {
//         Console.WriteLine($"Число {b} не является квадратом {a}");
//     }
//    if (b*b ==a)
//     {
//         Console.WriteLine($"Число {a} является квадратом {b}");
//     }
//     else
//     {
//         Console.WriteLine($"Число {a} не является квадратом {b}");
//     }
// }
// newNambers(A,B);
//___________________________

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//  int namber (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int X =  namber (-100,100);
// int namberOne (int minValue, int maxValue)
// {
//     int name = new Random().Next(minValue,maxValue);
//     return  name;
// }
// int Y =  namberOne (-100,100);
// Console.WriteLine($"X = {X} Y = {Y}");
// void rezalt (int x, int y)
// {
//     if (x >0 && y>0)
//     {
//         Console.WriteLine($"Точка находится в {1}-й четверти");
//     }
//     if (x <0 && y<0)
//     {
//         Console.WriteLine($"Точка находится в {3}-й четверти");
//     }
//     if (x >0 && y<0)
//     {
//         Console.WriteLine($"Точка находится в {4}-й четверти");
//     }
//     if (x <0 && y>0)
//     {
//         Console.WriteLine($"Точка находится вo {2}-й четверти");
//     }
// }
// rezalt(X,Y);
//_______________________________________________________________

// 20. Задать номер четверти, показать диапазоны для возможных координат

