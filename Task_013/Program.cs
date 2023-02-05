// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    if (number > 99)
    {
        int num =0;
        num = number;
        num = num % 10;
        Console.WriteLine(number + " -> " + num);
    }
    else Console.WriteLine(number + " -> Третьей цифры нет");
}

else Console.WriteLine("Некорректное число");
