// 0. Вывести квадрат числа 
// 1. По двум заданным числам проверять является ли первое квадратом второго 
// 2. Даны два числа. Показать большее и меньшее число 
// 3. По заданному номеру дня недели вывести его название 
// 4. Найти максимальное из трех чисел 
// 5. Написать программу вычисления значения функции y=f(a)

// 0. Вывести квадрат числа

//Console.WriteLine ("Введите число, квадрат которого хотите получить");
 //int a =
  //Convert.ToInt32(Console.ReadLine());
//int b = a * a;
//Console.WriteLine ($"Квадрат {a} = {b}");
//__________________________________________________________________________

// 1. По двум заданным числам проверять является ли первое квадратом второго 

//Console.WriteLine ("Введите первое число");
 //int a =
  //Convert.ToInt32(Console.ReadLine());

//Console.WriteLine ("Введите второе число");
//int b = 
  //Convert.ToInt32(Console.ReadLine());
  //if(b*b==a)
  //Console.WriteLine ($" Число {a} является квадратом {b}");

//else
//Console.WriteLine ($"Число {a} не является квадратом {b}");
//__________________________________________________________

// 2. Даны два числа. Показать большее и меньшее число 
//Console.WriteLine ("Введите первое число");
//int a =
//Convert.ToInt32(Console.ReadLine());

//Console.WriteLine ("Введите второе число");
//int b = 
//Convert.ToInt32(Console.ReadLine());

//if(a>b)
// Console.WriteLine($"Большее число {a}");
//Console.WriteLine();
//if(a<b)
//Console.WriteLine ($"Большее число {b}");
//Console.WriteLine();
//if(a==b)
//Console.WriteLine("Числа одинаковые");

//_______________________________________________

// 3. По заданному номеру дня недели вывести его название 

//Console.WriteLine ("Введите номер дня недели");
//int a = 
//Convert.ToInt32(Console.ReadLine());

//if(a==1)
//Console.WriteLine ("Сегодня понедельник");
//if(a==2)
//Console.WriteLine ("Сегодня вторник");
//if(a==3)
//Console.WriteLine ("Сегодня среда");
//if(a==4)
//Console.WriteLine ("Сегодня четверг");
//if(a==5)
//Console.WriteLine ("Сегодня пятница");
//if(a==6)
//Console.WriteLine ("Сегодня суббота");
//if(a==7)
//Console.WriteLine ("Сегодня воскресенье");

//_______________________________________

// 4. Найти максимальное из трех чисел


//Console.WriteLine ("Введите первое число");
//int a = 
//Convert.ToInt32(Console.ReadLine());

//Console.WriteLine ("Введите второе число");
//int b = 
//Convert.ToInt32(Console.ReadLine());

//Console.WriteLine ("Введите третье число");
//int c = 
//Convert.ToInt32(Console.ReadLine());

//if (a>b)
//{
    //if (a>c)
    //{
       // Console.WriteLine($"Большее число {a}");
    //}
//}
//if (b>a)
//{
   //if (b>c)
   //{
       //Console.WriteLine($"Большее число {b}");
  // } 
//}

//if (c>a)
//{
   //if (c>b)
   //{
    //   Console.WriteLine($"Большее число {c}");
  // } 
//}

// 5. Найти максимальное из 10 чисел

int[] array = new int [10];
int index = 0;
while(index<10)
{
  array[index] = new Random().Next(20,100);
  index++;  
}

index= 0;
while(index <= 9)
{
int val = array[index];
Console.WriteLine(val);
  index++;
}
//ищем максимальное число
int max = array[0];
index = 1;
while(index<9) 
{
  if (array[index] > max)
  {
    max = array[index];
  }
  index++;
}
Console.WriteLine("Максимальное значение равно");
Console.WriteLine(max);
