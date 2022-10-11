// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

int getNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect) 
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не пятизначное число");
     }
     return result;
}


void checkingPalindrome(int a)
{
    string num = a.ToString();
    int one = int.Parse(num[0].ToString());
    int two = int.Parse(num[1].ToString());
    int foure = int.Parse(num[3].ToString());
    int five = int.Parse(num[4].ToString());

    if(one == five && two == foure)
        Console.WriteLine($"Число {a} является ПАЛИНДРОМОМ");
    else
        Console.WriteLine($"Число {a} не является ПАЛИНДРОМОМ");

}

int e = getNumber("Введите пятизначное число");
checkingPalindrome(e);
