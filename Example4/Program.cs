/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("введите число");
String nStr = Console.ReadLine();
int n = int.Parse(nStr);
for (int i = 1; i < n; i++)
    if (i % 2 == 0 && !(i == 1))
    {
        Console.Write($"{i} ");
    };