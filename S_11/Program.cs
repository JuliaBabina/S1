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

// НА ДЗ



// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника 

// НА ДЗ