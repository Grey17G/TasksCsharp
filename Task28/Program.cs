/*Задача 28. Напишите программу, которая принимает на вход число N и
выдает произведение чисел от 1 до N

4 -24
5 -120
*/

Console.Write("введите число ");
int Num = int.Parse(Console.ReadLine()!);

int getSumNum(int end)
{
    int sum =1;
        for( int i = 1; i<=end; i++)
        {
            sum =sum*i;
        }
        return sum;
}
int Sum = getSumNum (Num);
Console.WriteLine (Sum);
