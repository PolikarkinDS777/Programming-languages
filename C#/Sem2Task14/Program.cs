﻿//========================================================================
// # Задача 14 Напишите программу, которая принимает на вход число и 
// и проверяет, кратно ли оно одновременно 7 и 23. 
//========================================================================

Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);

    if(inputNumberA%7==0 && inputNumberA%23==0)
    {
        Console.Write("Число кратно одновременно 7 и 23");
    }
    else
    {
        Console.Write("Число не кратно одновременно 7 и 23");
    }
}