// 21. Программа проверяет пятизначное число на палиндромом.
//// 22. Найти расстояние между точками в пространстве 2D/3D
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// 21. Программа проверяет пятизначное число на палиндромом.

// int rezalt (int a)
// {
//    int  b = a;
//    int number = 0;
//     while (a>0)
//     { 
//      number = number *10 + a % 10;
//      Console.WriteLine(number);
//     a = a / 10;
//     }
//     Console.WriteLine(number);
//       if ( number == b)
//       {
//        Console.WriteLine($"Число {number} является полиндромом");
//       }
//      if (number != b)
//      {
//        Console.WriteLine(a);
//        Console.WriteLine($"Число {number} не является полиндромом");
//       }
// return number;
// }

// bool rezalt2(int a)
// {
//     int b = a;
//     int number = 0;
//     while (a > 0)
//     {
//         number = number * 10 + a % 10;
//         a = a / 10;
//     }

//     return number == b;
// }
// Console.WriteLine($"pol = {rezalt2(12321)}");
// rezalt ( 112211);

//// 22. Найти расстояние между точками в пространстве 2D/3D





// // 23. Показать таблицу квадратов чисел от 1 до N 

// // void nambers (int A, int N)
// // {
// //   for( int rezalt = 0; A<=N; A++)
// //   {
// //     rezalt = A * A;
// //     Console.WriteLine($"квадрат {A} = {rezalt}");
// //   }
// }
// nambers(1,20);
//___________________________________________________-

// 24. Найти кубы чисел от 1 до N

// void nambers (int A, int N)
// {
//   for( int rezalt = 0; A<=N; A++)
//   {
//     rezalt = A * A *A;
//     Console.WriteLine($"Куб числа {A} = {rezalt}");
//   }
// }
// nambers(1,20);
//_______________________________________

// 25. Найти сумму чисел от 1 до А

// int summa (int A)
// {
// int a = 1;
// int sum = a;
// while ( a <A )
// {
// sum = sum + (a +1);
// a++;
// }
// return sum;
// }
// Console.WriteLine($"Cymma = {summa (33)}");
//____________________________________________

// 26. Возведите число А в натуральную степень B используя цикл

// void namber (int a)
// {


// }

// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// void number (int  a)
// {
// int c = a;
// int count = 0;
// int summa = 0;
// int work = 1;
// int cube = 0;
//     while (a!=0)
//     {
//         summa = (a%10)+ summa;
//             if ( a%2==0) 
//             {
//                 cube=a%10;
//                 cube =  cube* cube * cube;
//                 Console.WriteLine ($"{a%10} в кубе = {cube}");
//             }
//         work = (a%10) * work;
//         a = a/10;
//         count ++;
//     }
// Console.WriteLine ($" Колличество цифр в числе {c} = {count} Сумма чисел = {summa} Произведение чисел = {work}");
// }
// number (135727);


int[] array (int number)
{
    return new int [number];
} 
int[] arr (int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (0,10);
    }
return array;
}
string print (int[] array)
{
    string numbers = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            numbers = numbers+$"{array[i]} ";
        }
return numbers;
}
int[] b = array(12);
arr(b,0,12);
Console.WriteLine(print(b));
string sum (int[] c) 
{
    string rez = String.Empty;
        for (int i = 0; i < b.Length+1; i++)
        {
        int rezult = b[i] + b[i++];
        rez = rez+$"{rezult} ";
        }
    return rez;
}
Console.WriteLine(sum(b));