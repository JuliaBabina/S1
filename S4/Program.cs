// 4 Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// выводим текст с запросом в терминал
// Console.Write("Введите число: ");
// присваиваем переменной N введенное число
// int N = Convert.ToInt32(Console.ReadLine());
// обяъвляем новую переменную, в которую сохраняем значение N с противоположным знаком
// int B = -N;

// условный цикл, который будет "работать" до тех пор, пока значение переменной B меньше либо равно значению N
// while (B <= N)
// {
//     выводим на экран значение B и пробел
//     Console.Write(B+ " ");
//     увеличиваем значение B на единицу
//    B++; // B = B + 1 аналогично B += 1 
// }


// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//    int x = num % 10;
//    Console.WriteLine(x);
// }
// else{
//    Console.WriteLine("Введенное число не трехзначное");
// }

// или с модулем

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//     Console.Write("Последняя цифра: " + Math.Abs(num) % 10);;
// }
// else{
//     Console.WriteLine("Введенное число не трехзначное");
// }


// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 78 - 8
// 12 - 2
// 85 - 8

// Console.Clear();
// int num = new Random().Next(10, 100);
// int first = num%10;
// int second = num/10;
// System.Console.WriteLine(num);
// if(first > second)
// {
//     System.Console.WriteLine(first);
// }
// else
// {
//     System.Console.WriteLine(second);
// }


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Console.Clear();
// int num = new Random().Next(10, 1000);
// Console.WriteLine(num);
// int first = num / 100;
// int second = num % 10;
// Console.WriteLine(first +""+second);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if(number1 % number2 == 0)
// {
//     System.Console.WriteLine(number1 + ", " + number2 + " -> " + "кратно" );
// }
// else
// {
//     System.Console.WriteLine(number1 + ", " + number2 + " -> " + "не кратно, остаток " + number1 % number2);
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number % 7 == 0 && number % 23 == 0)
// {
//     System.Console.WriteLine(number + " -> да");
// }
// else
// {
//     System.Console.WriteLine(number + " -> нет");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2 || number2 == number1 * number1)
{
    System.Console.WriteLine(number1 + " " + number2 + " -> да");
}
else
{
    System.Console.WriteLine(number1 + " " + number2 + " -> нет");
}
