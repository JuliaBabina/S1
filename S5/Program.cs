// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// От Максима Шульги

// Console.Write("Input random number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(num) < 100)
// {
//     Console.Write("There is no third digit");
// }

// else
// {
//     while (Math.Abs(num) >= 1000)
//     {
//         num = num / 10;
//     }
//     Console.Write(Math.Abs(num % 10));
// }

// От Гаи Акопян

// Console.WriteLine("Enter some number: ");
// int usersNumber = Convert.ToInt32(Console.ReadLine());
// int cycle = 0;

// while (cycle < usersNumber) {
//     if (usersNumber > 999) 
//     {
//         usersNumber = usersNumber / 10;
//     }
//     cycle++;
// }

// if (usersNumber > 99 && usersNumber < 1000) 
// {
//     Console.Write("The third digit is: ");
//     Console.WriteLine(usersNumber % 10);
// }

// else 
// {
//  Console.WriteLine("There's no third digit in your number.");
// }

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


// Console.Clear();

// Console.WriteLine("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.Write("Находится в 1 четверти");
// }

// if (x<0 && y>0)
// {
//     Console.Write("Находится в 2 четверти");
// }

// if (x<0 && y<0)
// {
//     Console.Write("Находится в 3 четверти");
// }

// if (x>0 && y<0)
// {
//     Console.Write("Находится в 4 четверти");
// }

// ВТОРОЙ ВАРИАНТ

// if (x > 0 && y > 0)
// {
//     Console.Write("Находится в 1 четверти");
// }

// else if (x < 0 && y > 0)
// {
//     Console.Write("Находится в 2 четверти");
// }

// else if (x < 0 && y < 0)
// {
//     Console.Write("Находится в 3 четверти");
// }

// else if (x > 0 && y < 0)
// {
//     Console.Write("Находится в 4 четверти");
// }

// else
// {
//     Console.Write("Определить четверть не возможно");
// }

// ТРЕТИЙ ВАРИАНТ

// Console.Write("Введите координаты точки X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine()!);
// string mes = "";

// switch (x, y)
// {
//     case (>0, >0): mes = "1"; break;
//     case (>0, <0): mes = "4"; break;
//     case (<0, >0): mes = "2"; break;
//     case (<0, <0): mes = "3"; break;
//     default : mes = "введите отличное от 0"; break;
// }
// Console.WriteLine(mes);

// Четвертый вариант (через функцию, void - это функция, которая ничего не возвращает)

// void PrintQuarter(int x, int y)
// {

//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Первая четверть");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("Вторая четверть");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Третья четверть");
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Четвертая четверть");
//     }
//     else
//     {
//         Console.WriteLine("Определить четверть не возможно");

//     }
// }

// Console.WriteLine("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());

// PrintQuarter(x, y);


// Другой вариант (с возвращающей функцией)

// int printQuarter(int a, int b)
// {
//     if (a>0 && b>0)
//     {
//         return 1;
//     }
//     else if (a<0 && b>0)
//     {
//         return 2;
//     }
//     else if (a<0 && b<0)
//     {
//         return 3;
//     }
//     else if (a>0 && b<0)
//     {
//         return 4;
//     }
//     else
//     {
//         return 0;
//     }
// }


// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Номер четверти - {printQuarter(x, y)}");



// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }
    
//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }


// Тоже самое, только с функцией

// ...

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

// Console.WriteLine($"d={d:f2}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
double sqrt = 1;
int number = 1;

Console.Write($"These are squares of numbers from 1 to {n}: ");

while (number <= n)
{
    sqrt = Math.Pow(number, 2);
    Console.Write(sqrt + ", ");
    number++;
}


