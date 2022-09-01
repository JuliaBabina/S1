//Задача 63. Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.

// Console.Clear();
// Console.Write("Введите N: ");
// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1,n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.Clear();
// Console.Write("Введите M: ");
// int m=int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(m,n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

//ИЛИ

// int PrintNumbers(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end) return start;
//     return  PrintNumbers(start + 1, end);
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int numberM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int numberN=int.Parse(Console.ReadLine()!);

// PrintNumbers(numberM,numberN);



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Console.Clear();

// Console.Write("Введите N: ");
// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(SumNumbers(n));

// int SumNumbers(int n)
// {
// if (n%10==0)
// {
//     return 0;
// }
// else
// {
//     return SumNumbers(n/10)+n%10;
// }
    
// }

// ИЛИ

//Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.

// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine($"{m}->{SumNumbers(m)}");

// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
//}


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// Console.Clear();
// Console.Write("Введите A: ");
// int a=int.Parse(Console.ReadLine());
// Console.Write("Введите B: ");
// int b=int.Parse(Console.ReadLine());

// Console.WriteLine(MyPow(a,b));

// int MyPow(int a, int b)
// {
// if (b ==1)
// {
//     return a;
// }
// else
// {
//     return a *MyPow(a,b-1);
// }
    
// }

// ИЛИ

//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"{Pow(m,n)}");

// int Pow(int number,int rank)
// {
//     if (rank == 0) return 1;
//     if(rank==1) return number;
//     return (number * Pow(number,rank-1));
// }


//ИЛИ

// Console.Write("Введите базовое Число: ");
// int baseVal = int.Parse(Console.ReadLine());

// Console.Write("Введите степень Число: ");
// int exp = int.Parse(Console.ReadLine());

// int power(int baseValue, int exp) {
//     if (exp == 0) {
//         return 1;
//     } else {
//         return  baseValue * power(baseValue, exp -1);
//     }
// }
// Console.Write("В степен: " + power(baseVal, exp));
