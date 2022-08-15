//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// int GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     } 
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//**Я

// Console.Clear();

// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// Console.WriteLine(num.Length);

//**** группа

// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// if (num == 0)
//     Console.Write("1");
// else
// {    
//     while(num!= 0)
//     {
//         num = num / 10;
//         i++;
//     }
//     Console.Write(i);
// }

//**********************************************

// Console.Write("Введите число - ");

// double N = Convert.ToDouble(Console.ReadLine());

// double digits_num = Math.Floor(Math.Log10(N) + 1);
// Console.WriteLine ("Количество цифр во введенном числе - " + digits_num);



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int mult = 1;
// for (int x = 1; x <= Math.Abs(n); x++)
// {
//     mult *= x;
// }
// Console.WriteLine($"Произведение чисел от 1 до {n} -> {mult}");


//*************рекурсия 

// long fact(long num)
// {

//     if (num == 1)
//     {
//         return num;
//     }
//     else
//     {
//         return num * fact(num - 1);
//     }
// }

// Console.WriteLine("Введите число N");
// long inputNumber = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Факториал числа " + fact(inputNumber));




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();

// int [] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,2);
//     Console.Write(array[i] + " ");
// }

// **********************************************

// int[] array1 = new int[8];

// Random rnd = new Random();
// Console.Write ("Случайный массив из 8 элементов в диапазоне [0,1] - ");
// for ( int i = 0; i < 8; i++)
// {
//     array1[i] = rnd.Next(0,2);
//     Console.Write (array1[i] + " ");
// }

