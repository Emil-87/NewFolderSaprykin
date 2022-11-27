// Задача 4. Напишите программу, которая принимает на вход три числа
// и выдает максимальное из этих чисел.
int a, b, c;
Console.WriteLine("Введите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b) max = b;
if (c > b) max = c;
{
    Console.WriteLine("Максимальное число равно " + max + "");
}



