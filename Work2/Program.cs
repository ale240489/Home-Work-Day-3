// Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

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
            Console.WriteLine("Введите валидные координаты");
     }
     return result;
}


double distancePoint(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distanceP = Math.Sqrt (Math.Pow( x2- x1, 2) + Math.Pow( y2 - y1, 2) + Math.Pow( z2 - z1, 2));
    return distanceP;
}


//первая точка
int x1 = getNumber("Введите координату X первой точки ");
int y1 = getNumber("Введите координату Y первой точки ");
int z1 = getNumber("Введите координату Z первой точки ");
//вторая точка
int x2 = getNumber("Введите координату X второй точки ");
int y2 = getNumber("Введите координату Y второй точки ");
int z2 = getNumber("Введите координату Z второй точки ");

double final = distancePoint(x1, x2, y1, y2, z1, z2);
Console.WriteLine ($"Расстояние между точкой с координатами {x1} {y1} {z1} и точкой с координатами {x2} {y2} {z2} равно {final}");