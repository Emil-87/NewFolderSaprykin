//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели от 1 до 7:");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 | a > 7)
{
    Console.WriteLine("В неделе семь дней, попробуйте снова?");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 | a == 7)
{
    Console.WriteLine("Выходной день.");
}
else
{
    Console.WriteLine("Будние дни.");
}
