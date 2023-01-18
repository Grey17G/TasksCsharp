/*Задача 25. Напишите программу, которая на вход принимает 2 числа (А и В) и 
возводит число А в натуральную степень В

3,5- 243 (3 в пятой степени
2,4 - 16 (2 в четвертой степени)
 */

 int getUserValue (string message)
 {
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine ()!);
    return result;
 }

 int Pow (int num, int n)
 {
    int res = num;
    for ( int i = 1; i < n; i++ )
    {
        res *= num;
    }
    return res;
 }

 int UserA = getUserValue ("Введите А");
 int UserB = getUserValue ("Введите B");

int DegreeofNumber = Pow (UserA, UserB);
Console.WriteLine ($"Результат возедения числа {UserA} в степень числа {UserB} равен {DegreeofNumber}");

