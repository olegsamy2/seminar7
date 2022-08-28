// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] FillMatrix1(int rowsCount, int columnsCount)	
{	
    int[,] matrix = new int[rowsCount, columnsCount];  // размер матрицы из случайных чисел	
	
    Random rand = new Random();	
	
    for (int i = 0; i < matrix.GetLength(0); i++)	
    {	
        for (int j = 0; j < matrix.GetLength(1); j++)	
        {	
            matrix[i, j] = i + j;  // заполнение по формуле условия задачи
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
int[,] matrix = FillMatrix1(m, n);	                 // вызываем метод для заполнения по условию данной задачи
PrintMatrix(matrix);	