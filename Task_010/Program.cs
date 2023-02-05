// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    int singleDigit=0;
    singleDigit=number;
    singleDigit=singleDigit/10;
    singleDigit=singleDigit%10;
    Console.WriteLine(number + " -> " + singleDigit);

}
else Console.WriteLine("Некорректное число");