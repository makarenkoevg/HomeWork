// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("a больше b");
}
else{
    if (a < b)
    {
        Console.WriteLine("a меньше b");
    }
    else{
        Console.WriteLine("a равно b");
    }
}