// Задача 46: Задайте двумерный массив 	
// размером m×n, заполненный случайными целыми числами.	
// m = 3, n = 4.	
// 1 4 8 19	
// 5 -2 33 -2	
// 77 3 8 1	
	
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)	
	
	
{	
    int[,] matrix = new int[rowsCount, columnsCount];  // размер матрицы из случайных чисел	
	
    Random rand = new Random();	
	
    for (int i = 0; i < matrix.GetLength(0); i++)	
    {	
        for (int j = 0; j < matrix.GetLength(1); j++)	
        {	
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);  // заполнение ячеек матрицы	
        }	
    }	
	
    return matrix;	
}	
void PrintMatrix(int[,] matrix)                       // метод который выводит матрицу на печать	
{	
    for (int i = 0; i < matrix.GetLength(0); i++)	
    {	
        for (int j = 0; j < matrix.GetLength(1); j++)	
        {	
            Console.Write(matrix[i, j] + " ");         // выводит каждую строку на печать в консоль	
        }	
        Console.WriteLine();   // строка пробел, что б строки матрицы двухмерной были отделены друг от друга	
    }	
}	
Console.Write("Введите m и n через Enter ");                       // ввод размеров матрицы	
int m = Convert.ToInt32(Console.ReadLine());                      //число строк	
int n = Convert.ToInt32(Console.ReadLine());                     //число столбцов	
int[,] matrix = FillMatrix(m, n);	
PrintMatrix(matrix);	
	
