// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Clear();

// void fillMatrixWithRandomIntegers(int[,] matrix)
// {
//     Random rnd = new Random();
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             matrix[rowIndex, columnIndex] = rnd.Next(-10, 11);
//         }
//     }
// }

// void printMatrixOfIntegersToConsole(int[,] matrix)
// {
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         Console.Write("\n");
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             Console.Write($"  {matrix[rowIndex, columnIndex]}");
//         }
//     }
//     Console.Write("\n");
// }
// Console.WriteLine("Введите количество строк матрицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m < 1 || n < 1)
// {
//     Console.WriteLine("Некорректные значения");
// }

// else
// {   
// int[,] matrix = new int[m, n];
//     fillMatrixWithRandomIntegers(matrix);
//     printMatrixOfIntegersToConsole(matrix);
//     int indexFerstrool = 0;
//     int indexLastrool = m - 1;
//     int[] TempArray = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//        TempArray[i] = matrix[indexFerstrool,i];
//     }
//     for (int i = 0; i < n; i++)
//     {
//         matrix[indexFerstrool,i] = matrix[indexLastrool,i];
//     }
//     for (int i = 0; i < n; i++)
//     {
//         matrix[indexLastrool,i] = TempArray[i];
//     }
//     Console.WriteLine("New matrix revers");
//     printMatrixOfIntegersToConsole(matrix);
// }



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя (это если матрица не квадратная).

// НА ДЗ (проходим от i и j И заменять result[j, i] = array[i, j];) и войд на вывод



// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// НА ДЗ



// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Console.Clear();
// Console.WriteLine($"Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");
// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int[,] positionSmallElement = new int[1, 2];
// positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
// Console.Write($"Позиция элемента: \n");
// WriteArray(positionSmallElement);

// int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// DeleteLines(array, positionSmallElement, arrayWithoutLines);
// Console.WriteLine($"\nПолучившийся массив:");
// WriteArray(arrayWithoutLines);


// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FindPositionSmallElement(int[,] array, int[,] position)
// {
//   int temp = array[0, 0];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] <= temp)
//       {
//         position[0, 0] = i;
//         position[0, 1] = j;
//         temp = array[i, j];
//       }
//     }
//   }
//   Console.WriteLine($"\nMинимальный элемент: {temp}");
//   return position;
// }

// void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
// {
//   int k = 0, l = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
//       {
//         arrayWithoutLines[k, l] = array[i, j];
//         l++;
//       }
//     }
//     l = 0;
//     if (positionSmallElement[0, 0] != i)
//     {
//       k++;
//     }
//   }
// }



// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника 

// Console.Clear();
// Console.WriteLine($"Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.");

// int n = InputNumbers("Введите количество строк: ");

// double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

// FillPascalTriangle(pascalTriangle);

// Console.WriteLine();
// WriteArray(pascalTriangle);

// TransformationPascalTriangle(pascalTriangle);

// Console.WriteLine();
// WriteArray(pascalTriangle);

// void TransformationPascalTriangle(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     int count = 0;
//     for (int j = array.GetLength(1) - 1; j >= 0; j--)
//     {
//       if (array[i, j] != 0)
//       {
//         array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
//         array[i, j] = 0;
//         count++;
//       }
//     }
//   }
//   array[array.GetLength(0) - 1, 0] = 1;
// }

// void FillPascalTriangle(double[,] pascalTriangle)
// {
//   for (int k = 0; k < pascalTriangle.GetLength(0); k++)
//   {
//     pascalTriangle[k, 0] = 1;
//   }
//   for (int i = 1; i < pascalTriangle.GetLength(0); i++)
//   {
//     for (int j = 1; j < i + 1; j++)
//     {
//       pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
//     }
//   }
// }

// void WriteArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] != 0)
//       {
//           Console.Write($"{array[i, j]} ");
//       }
//       else Console.Write("  ");
//     }
//     Console.WriteLine();
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }