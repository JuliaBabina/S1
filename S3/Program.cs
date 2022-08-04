// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Console.Write("Input number of the day: ");

// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//  Console.Write("Incorrect number");
//}
// else
// {
// if (day == 1)
// {
//     Console.Write("Monday");
// }
//if (day == 2)
//{
//    Console.Write("Tuesday");
// }
// }

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Некорректный номер");
}

else
{
    if (day == 1)
    {
        Console.Write("Понедельник");

    }

    if (day == 2)
    {
        Console.Write("Вторник");
    }

    if (day == 3)
    {
        Console.Write("Среда");
    }

    if (day == 4)
    {
        Console.Write("Четверг");
    }

    if (day == 5)
    {
        Console.Write("Пятница");
    }

    if (day == 6)
    {
        Console.Write("Суббота");
    }

    if (day == 7)
    {
        Console.Write("Воскресенье");
    }
}


