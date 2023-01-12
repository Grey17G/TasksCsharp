/*Задача 17. Напишите программу, которая принимает на вход координаты точки (X,Y)
причем x≠0<y≠0, и выдает номер четверти плоскости, в которой находится эта точка*/

int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if(x>0 && y>0)
    {
        quarter =1;
    }
    else if (x<0 && y>0)
    {
        quarter =2;
    }
    else if (x<0 && y<0)
    {
        quarter =3;
    }
    else if (x<0 && y>0)
    {
        quarter =4;
    }
    return quarter;
}

void showQuarter(int x, int y)
{
    if(x !=0 && y != 0)
    {
        int quarter = getQuarterNumber(x,y);
        Console.WriteLine ($"точка {x},{y} находится в {quarter} четверти");
    }
    else
    {
        Console.WriteLine ($"точка {x},{y} находится на оси координат");
    }   
}

int userX = getUserValue ("Введите X");
int userY = getUserValue ("Введите Y");
showQuarter( userX, userY);





