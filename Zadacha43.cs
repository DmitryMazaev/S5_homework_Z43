/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Найти точку пересения прямых y=k1*x+b1 и y=k2*x+b2");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

double [] GetArray(int size)
{
    double[] res = new double [2];
    if (k1 == k2)
    {
        Console.Write("Прямые y=k1*x+b1 и y=k2*x+b2 параллельны друг другу");
    }
    else
    {

        res[0] = Math.Round((b2 - b1)/(k1-k2), 2);
        res[1] = Math.Round((k1*res[0]+b1), 2);
        Console.Write($"Координаты точки пересечения прямых y=k1*x+b1 и y=k2*x+b2: ({res[0]}; {res[1]})");
    }
    return res;
}
double[] array = GetArray(2);