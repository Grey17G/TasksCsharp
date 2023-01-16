/*Задача 24. Напишите программу, которая принимает на вход число (А), и выдает
сумму чисел от 1 до А.
7-28
4-10
8-36
*/

int getUserData (string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getSumofRange (int start, int end)
{
    int Sum = 0;
    for(int i= start; i<=end; i++)
    {
        Sum +=i; //Sum = Sum +i;
    }
    return Sum;
}

int end = getUserData ($"Введите число A для получения суммы");
int sum = getSumofRange (1, end);
Console.WriteLine ($"Сумма чисел от 1 до {end} равен {sum}");
