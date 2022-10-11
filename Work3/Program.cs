//Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

int getNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect) 
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Получены некорректные данные");
     }
     return result;
}


void coubOfNum (int a)
{
    for(int i = 1; i <= a; i++)
    {
        double coub = Math.Pow(i, 3);
        Console.Write($"{coub} ");
    }
}

int number = getNumber("Введите число");
Console.WriteLine ($"Кубы чисел от 1 до {number}");
coubOfNum(number);


