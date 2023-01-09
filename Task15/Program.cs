// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine ("введите цифру");
int Daynumber = int.Parse (Console.ReadLine ()!);

   if(Daynumber == 6 || Daynumber ==7)
    {
        Console.WriteLine("этот день выходной");
    }
    else if(Daynumber <1 || Daynumber >7)
    {
        Console.WriteLine("это не день недели");
    }
    else
    {
        Console.WriteLine("этот день не выходной");
    }

