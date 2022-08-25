// Сгенерировать двумерный массив со случайными числами, вывести его на экран,
// оформить в виде функций (пригодится в дальнейшем)

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }


// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");     // Необязательно
// int minRand = Prompt("Введите нижнюю границу диапазона ");      // Необязательно    
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); // Диапазон значений можно не указывать, будут взяты условия по умолчанию
// PrintArray(matrix);

// ЕЩЕ РАЗ


// Сгенерировать двумерный массив со случайными числами, вывести его на экран,
// оформить в виде функций (пригодится в дальнейшем)

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }

// int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }


// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");     // Необязательно
// int minRand = Prompt("Введите нижнюю границу диапазона ");      // Необязательно    
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); // Диапазон значений можно не указывать, будут взяты условия по умолчанию
// PrintArray(matrix);


// *****************

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void ShowArrayAndCount (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//         if (array[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"You've entered {count} positive number(s)");
// }

// Console.WriteLine("How many numbers do You want to input? ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// int[] NumArray = new int[size];

// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"Input {i + 1} number: ");
//     NumArray[i] = int.Parse(Console.ReadLine() ?? "0");        
// }

// ShowArrayAndCount(NumArray);


// /* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 */

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }


// void InputAndCountNumbers(int number)              // Функция проверки корректности условий
// {
//     if (number > 0)
//     {
//         int[] myArr = ArrayInput(number);
//         ArrayPrint(myArr);
//         System.Console.WriteLine($"Количество положительных чисел равно {PositiveNumber(myArr)}");
//     }
//     else
//     {
//         System.Console.WriteLine("Количество не может быть отрицательным или равным нулю");
//     }
// }

// int[] ArrayInput(int number)                    // Функция ввода массива
// {
//     int[] myArr = new int[number];
//     int i = 0;
//     while (i < number)
//     {
//         Console.Write("Введите число ");
//         myArr[i] = int.Parse(Console.ReadLine());
//         i++;
//     }
//     return myArr;
// }

// int PositiveNumber(int[] myArr)            // Функция подсчета положительных чисел
// {
//     int count = 0;
//     for (int i = 0; i < myArr.Length; i++)
//     {
//         if (myArr[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// void ArrayPrint(int[] myArr)                            // Функция печати массива    
// {
//     for (int j = 0; j < myArr.Length; j++)
//     {
//         System.Console.Write($"{myArr[j]}  ");
//     }
// }


// int number = Prompt("Определите количество чисел для ввода ");  // Определяем количество элементов (М) массива
// InputAndCountNumbers(number);                                 // Начинаем проверку условий


//СЕМИНАР

// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле из задания
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = FillArray(Prompt("Введите число строк "), Prompt("Введите число столбцов "));
// PrintArray(array);

// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4


// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = i + j;      // [0; 20) по умолчанию 
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ConvertToSqr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     return array;
// }


// int[,] array = FillArray(5, 5);
// PrintArray(array);

// Console.WriteLine();
// int[,] array2 = ConvertToSqr(array);
// PrintArray(array2);


// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12


// Random rand = new Random();

// void FillMatrix(int[,] matr)         // Функция создания и заполнения двумерного массива случайными числами  
// {

//     for (int i = 0; i < matr.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)     // Столбец
//         {
//             matr[i, j] = rand.Next(1, 15);      // [0; 20) по умолчанию 
//         }
//     }
// ;
// }

// void PrintArray(int[,] arr)              // Функция печати массива 
// {
//     for (int i = 0; i < arr.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int GetSum(int[,] matrix)
// {
//     int sum = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }

// int[,] matrix = new int[3, 3];
// FillMatrix(matrix);
// PrintArray(matrix);
// Console.WriteLine(GetSum(matrix));


// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

// Random rand = new Random();

// void FillMatrix(int[,] matr)         // Функция создания и заполнения двумерного массива случайными числами  
// {

//     for (int i = 0; i < matr.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)     // Столбец
//         {
//             matr[i, j] = rand.Next(1, 15);      // [0; 20) по умолчанию 
//         }
//     }
// ;
// }

// void PrintArray(int[,] arr)              // Функция печати массива 
// {
//     for (int i = 0; i < arr.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElem(int[,] matrix, int element)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             if (element == matrix[i, j])
//             {
//                 Console.WriteLine($"Entered number is on the [{i},{j}] position");
//                 return;
//             }
//         }
//     }
//     Console.WriteLine($"There is no such element in this matrix");
// }



// int[,] matrix = new int[3, 3];
// FillMatrix(matrix);
// PrintArray(matrix);
// Console.WriteLine("Input a number: ");
// int element = int.Parse(Console.ReadLine());
// FindElem(matrix, element);



//********** от Гаи

// Random rand = new Random();

// void FillMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void findElem (int[,] matrix, int element)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(element == matrix[i, j])
//             {
//               System.Console.WriteLine($"Entered number is on the [{i},{j}] position");
//               return;
//             }
//         }

//     }
//     System.Console.WriteLine($"There is no such element in this matrix");


// }

// int[,] matrix = new int[3, 3];

// FillMatrix(matrix);
// PrintArray(matrix);

// System.Console.WriteLine("Input a number: ");
// int element = int.Parse(Console.ReadLine() ?? "0");
// findElem(matrix, element);



// НА ДЗ
// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
