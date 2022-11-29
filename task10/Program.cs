// Задача 10. Напишите прогу, при вводе 3х значного числа должна показывать 2ю цифру.

Console.WriteLine("Введите 3-х значное число:");
int a = 0;
a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999)
{
    int DecreaseByTen = a / 10;
    int LastDigit = DecreaseByTen % 10;
    Console.WriteLine("Вторая цифра числа=" + LastDigit);
}
else
{
    Console.WriteLine("Ошибка, Вы ввели неправильное число!");
}
