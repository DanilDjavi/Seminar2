// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    int num =0;
    num = number;
    num = num / 10;
    num = num % 10;
    Console.WriteLine(number + " -> " + num);
}
else Console.WriteLine("Некорректное число");