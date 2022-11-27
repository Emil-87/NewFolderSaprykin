internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 6. Напишите прогу,которая на вход принимает число и выдает,
        //является ли оно четным(делится ли оно на 2 без остатка)
        int a;

        Console.Write("Введите число :");
        a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.Write("Введенное число четное");
        }
        else
        {
            Console.Write("Введенное число не четное");
        }
    }
}