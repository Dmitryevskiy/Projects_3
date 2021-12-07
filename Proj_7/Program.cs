// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

// int[] array (int a)
// {
//     return new int [a];
// }
// int[] arr(int[] array, int min, int max)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = new Random().Next(1,10);
// }
// return array;
// }
// string print (int[] array)
// {
//     string number = string.Empty;
    
//     for (int i = 0; i < array.Length; i++)
//     {
//      number+=$"{array[i]} ";
//     }
//      return number;   
// }
// int[] b = array(12);
// arr(b,5,15);
// Console.WriteLine(print(b));

// 41. Выяснить являются ли три числа сторонами треугольника

//bool examination (int a, int b, int c)
 //{
       // if ((c+b>a)&&(a+c>b)&&(a+b>c))
//     {
//         Console.WriteLine( true);
//     }
//         else
//     {
//         Console.WriteLine (false);
//     }
//  return false;
//  }
// examination (4,3,66);

//__________________________________
// 42. Определить сколько чисел больше 0 введено с клавиатуры

// 43. Написать программу преобразования десятичного числа в двоичное

// string sistem (int x)
// {
//     string count = string.Empty;

//         while(x!=0)
//        {
//            if(x%2==0)
//            {
//                 count+=$"{0} ";
//            }
//            else
//            {
//                count+=$"{1} ";
//            }
//         x=x/2;
//        }
//  return count;      
// }
// Console.Write(sistem(22));
// void newArray (string sistem)
// {
//     //int newCount = 0;
//     for (int i = sistem.Length; i < 0; i--)
//     {
//      //newCount = sistem[i];
//      Console.Write ($"sistem{i}");
//      //newCount+=$"{i} ";
//     } 
// //return  ;//newCount;
// }
// Console.Write(newArray(sistem));

// 43. Написать программу преобразования десятичного числа в двоичное


void array (int b )
{
    string count = string.Empty;
    while(b!=0)
       {
           if(b%2==0)
           {
                count=$"{0} "+count;
           }
           else
           {
               count=$"{1} "+count;
           }
        b=b/2;
       }
       Console.WriteLine (count);


}
array(212);
// string PrintArray (int[] array)
// {
//     string coup = String.Empty;
//     for (int i = array.Length; i < 0; i--)
//     {
//         coup+=$"{array[i]} ";
//     }
// return coup;
// }
// int[] d = array(22);
// Console.WriteLine(PrintArray(d));
