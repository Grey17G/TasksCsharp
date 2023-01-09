// Задача 12:  Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine()!);

if(number1%number2== 0)
{
    Console.WriteLine("число кратно");
}
else
{
    int ostatok = number1%number2;
    Console.WriteLine($"число некратно, остаток равно {ostatok}");
}
