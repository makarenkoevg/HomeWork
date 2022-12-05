// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N:");
int n = int.Parse(Console.ReadLine());
int index = 2;
while (index <= n){
    Console.WriteLine(index);
    index+=2;
}