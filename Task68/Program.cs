/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getDataFromUser (string message)
{
    Console.WriteLine (message);
    int result = int.Parse (Console.ReadLine()!);
    return result;
}
int Ackermann (int start, int end)
{
    if (start == 0)
    {
        return end + 1;
    }
    else if (start> 0 && end == 0)
    {
        return Ackermann(start - 1, 1);
    }
    
    else if (start > 0 && end > 0)
    {
         return Ackermann(start - 1, Ackermann(start, end - 1));
    }
    return -1; // Ошибка 
}



int DataUserStart = getDataFromUser ("Введите значение начала ряда");
int DataUserEnd = getDataFromUser ("Введите значение границы ряда");
int FunctionAckermann = Ackermann (DataUserStart, DataUserEnd);
Console.WriteLine(FunctionAckermann);


