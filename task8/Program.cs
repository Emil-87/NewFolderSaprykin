﻿// Задача 8. Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до N.
int N;
int index;
Console.Write("Введите число N:  ");

N = Convert.ToInt32(Console.ReadLine());
index = 1;

while (index <= N)
{
    if (index % 2 == 0) Console.Write(index + " ");
    index++;
}