//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c:");
int c = int.Parse(Console.ReadLine());
if (a>b){
    if (a>c){
        Console.Write("Число a - наибольшее из них");
    }
    else{
        Console.Write("Число c - наибольшее из них");
    }
}
else{
    if (b>c){
        Console.Write("Число b - наибольшее из них");
    }
    else{
        Console.Write("Число c - наибольшее из них");
    }
}