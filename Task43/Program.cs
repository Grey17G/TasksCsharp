/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int getUserValue (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}


double getPointXIntersection (double userb1, double userb2, double userk1, double userk2)
{
    double X = (userb2-userb1)/(userk1-userk2);
    return X;
}


int userb1 = getUserValue ("Введите значение b1");
int userk1 = getUserValue ("Введите значение k1");
int userb2 = getUserValue ("Введите значение b2");
int userk2 = getUserValue ("Введите значение k2");

double X = getPointXIntersection (userb1, userb2, userk1,userk2);
double Y = (userk1*X) + userb1; 
Console.WriteLine ($"Точка пересечения двух прямых равна {X};{Y}");
 
