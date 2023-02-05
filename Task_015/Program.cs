// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    switch (n)
{
    case 1:
        Console.WriteLine("Нет");
        break;
    
    case 2:
        Console.WriteLine("Нет");
        break;

    case 3:
        Console.WriteLine("Нет");
        break;

    case 4:
        Console.WriteLine("Нет");
        break;

    case 5:
        Console.WriteLine("Нет");
        break;

    case 6:
        Console.WriteLine("Суббота, выходной день");
        break;

    case 7:
        Console.WriteLine("Воскресенье, выходной день");
        break;
    
    default:
        Console.WriteLine("Некорректный номер дня недели");
        break;
}
}