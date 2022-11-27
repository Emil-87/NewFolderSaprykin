/*
//  0. Напишите программу, которая принимает число и выдает его квадрат (Число
// умноженное на само себя)
// int-это тип данных имя переменной = значение переменной;
int number = 5;
int numberSecond;
numberSecond = 8;
int result = number * number;
// Консоль, выведи результат
Console.WriteLine($"{number} * {number} = { result}");
*/
/*
int number = 6;
if (number > 10)
{
    Console.WriteLine("number up 10");
}
else 
{
    Console.WriteLine("number down 10");
}
*/
/*
int number = 5;

while (number < 10)
{
Console.WriteLine(number);
number++;
}
*/
// Задача 1. Напишите программу, которая  принимает число и возводит его в квадрат;
/*
Console.WriteLine("Input first number");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if ( numberFirst == numberSecond* numberSecond)
{
    Console.WriteLine(" Yes!");
}
else 
{
Console.WriteLine("No!");
}
*/
// Напишите программу,которая будет выдавать название дня неделети по заданному номеру 
// 3->Среда, 4->Четверг

/*
Console.WriteLine("Enter day of the week");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
     Console.WriteLine(" Monday");
}
else if(number == 2)
{
    Console.WriteLine(" Tuesday");
}
else if (number == 3)
{
    Console.WriteLine("Wednesday");
}
else if (number == 4)
{
    Console.WriteLine("Thursday");
}
else if (number == 5)
{
    Console.WriteLine(" Friday");
}
else if(number ==6)
{
    Console.WriteLine("Saturday");
}
else if(number ==7)
{
    Console.WriteLine("Sunday");
}
else 
{
    Console.WriteLine(" incorect input");
}
*/
// 5. Задача. Напишите программу вычисления значения функции возведения числа в квадрат.
/*
Console.WriteLine(" Enter number");
int number = 8; //Convert.ToInt32(Console.ReadLine());
PrintPower(number);
number = 8;
PrintPower(number);
number = -1;
PrintPower(number);
number = 0;
PrintPower(number);
number = 2;
PrintPower(number);

void PrintPower(int number)
{
    Console.WriteLine($"{number} * {number} = {number * number}");
}
*/
// 7.Задача 7.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N

/*Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int count = -number;

while (count <= number)
{
    Console.Write(count + " ");
    count++;
}
Console.WriteLine();
*/

// Задача 2. Напишите программу,которая на вход принимает два числа и выдает, какое число большее,
//а какое меньшее. a=5,б=7 макс 7

Console.Write("Enter first digit:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second digit:");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if
 (a < b) max = b;
Console.WriteLine(max);





