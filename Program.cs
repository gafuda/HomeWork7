// //Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

// Console.Clear();
// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] SortRowAscending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int minPosition = j;                                            
//             for (int k = j + 1; k < array.GetLength(1); k++)                
//             {
//                 if (array[i, k] > array[i, minPosition]) minPosition = k;    
//             }
//             int tmp = array[i, j];                                          
//             array[i, j] = array[i, minPosition];                            
//             array[i, minPosition] = tmp;                                    
//         }

//     }
//     return array;
// }

// void PrintTable(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 4;
// int col = 7;
// int min = 10;
// int max = 100;

// int[,] table = GetMatrix(row, col, min, max);
// PrintTable(table);

// System.Console.WriteLine();
// int[,] rowSort = SortRowAscending(table);
// PrintTable(rowSort);


// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void TransposeMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             int tmp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = tmp;
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}  ");
//         }
//         System.Console.WriteLine("");
//     }
// }

// int row = 4;
// int col = 4;
// int min = 10;
// int max = 100;

// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine("---");
// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     TransposeMatrix(matrix);
//     PrintMatrix(matrix);
// }
// else System.Console.WriteLine("Данную матрицу транспонировать невозможно (матрица не квадратная)" + "\n");



//  В прямоугольной матрице найти строку с наименьшей суммой элементов.

// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int rowNumber(int[,] array)
// {
//     int index = 0;
//     int sum = 0;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0) result = sum;
//         else if (sum < result)
//         {
//             result = sum;
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 5;
// int col = 8;
// int min = 1;
// int max = 10;

// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine("-----------------------");
// int index = rowNumber(matrix);
// System.Console.WriteLine(index);
