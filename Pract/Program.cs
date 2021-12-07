// Консольная игра "Угадай число"
Console.Clear();
System.Console.WriteLine(" Привет, Игрок! Попробуй угадать число от 1 до 100. У тебя 7 попыток.");
int CreateNumber(int a, int b)
{
    return new Random().Next(a, b);
}

int requestNumber()
{
    int naturalNumber = 0; //переменная integerNumber, в данном случае, хранит число, которое ввел пользователь
    while (true)
    {
        Console.WriteLine("Введите целочисленное значение");
        if (int.TryParse((Console.ReadLine()), out int number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
        {
            if (number > 0)
            {
                naturalNumber = number;  //если получилось, запоминаем число
                Console.Clear();
                break;          //очищаем экран и выходим из цикла
            }
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
        }
    }
    return naturalNumber;        // возвращаем значение метода (функции) в программу
}

// int Read(string Name)
// {
//     Console.Write(Name + " = ");
//     return int.Parse(Console.ReadLine());
// }
int Count()

{
    int SecretNumber = CreateNumber(1, 100);
    int Flag = 0;
    for (int i = 0; i < 7; i++)
    {
        int N = requestNumber();
        if (N == SecretNumber)
        {
            Console.WriteLine("Вы выиграли!");

            return Flag;
        }
        else
        {
            if (check(N, SecretNumber))
            {
                if (i == 6) Flag = 2;
                Console.WriteLine($"Ваше число {N} больше загаданного {SecretNumber}");
            }
            else
            {
                if (i == 6) Flag = 2;
                Console.WriteLine($"Ваше число {N} меньше загаданного {SecretNumber}");
            }
        }

    }
    return Flag;
}

System.Console.WriteLine(Count());

bool check(int arg1, int arg2)
{
    return arg1 > arg2;

}