/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("введите первое число");
string aStr = Console.ReadLine();
Console.WriteLine("введите второе число");
string bStr = Console.ReadLine();
Console.WriteLine("введите третье число");
string cStr = Console.ReadLine();
int a = int.Parse(aStr);
int b = int.Parse(bStr);
int c = int.Parse(cStr);
if (a > b && a > c)
{
    Console.WriteLine($"большее число {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"большее число {b}");
}
else
{
    Console.WriteLine($"большее число {c}");
};

