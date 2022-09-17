/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
if (number % 2 == 0)
{
    Console.WriteLine($"число {number} четное");
}
else
{
    Console.WriteLine($"число {number} нечетное");
};
