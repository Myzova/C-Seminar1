/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("введите первое число");
string aStr = Console.ReadLine();
Console.WriteLine("введите второе число");
string bStr = Console.ReadLine();
int a = int.Parse(aStr);
int b = int.Parse(bStr);
if (a > b)
{
    Console.WriteLine($"{a} больше {b}");
}
else if (b > a)
{
    Console.WriteLine($"{b} больше {a}");
}
else
{
    Console.WriteLine($"{a} равно {b}");
};
