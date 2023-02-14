// Задача 1. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] Create2DArrayRand(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    {
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                newArray[i,j] = new Random().Next(min,max);

        return newArray;
    }
}

void Print2DArray(int[,] array) 
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }  
}

int[,] ReverseArray(int[,] array)
{
        for(int i = 0; i < array.GetLength(0); i++) // проходит по строкам
            for(int j = 0; j < array.GetLength(1); j++) // переход к сл столбцу
                for (int k = 0; k < array.GetLength(1) - j - 1; k++) // сортировка пузырьком - сравниваются соседние лементы и сортируются
                {                                                     //array.GetLength(1)- j-1 - при сл проходе пропускает 1-й отсортированный элемент
                    if (array[i, k] < array[i, k + 1]) // сравниваваем соседние элементы
                    {
                        int temp = array[i, k]; 
                        array[i, k] = array[i, k + 1]; // меняем элементы местами, если подходит условие: сл эл в паре больше
                        array[i, k + 1] = temp; // он становится в начало 
                    }
                }

        return array;
}


Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArrayRand(m,n,1,94);
Print2DArray(myArray);

Print2DArray(ReverseArray(myArray));

// Задача 2. Программа задает двумерный массив и заменяет в нем строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] Create2DArrayRand(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    {
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                newArray[i,j] = new Random().Next(min,max);

        return newArray;
    }
}

void Print2DArray(int[,] array) 
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }  
}

int[,] ReverseArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Uncorrect array format");
        return array;
    }

    for(int i = 0; i < array.GetLength(0) - 1; i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    return array;

}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArrayRand(m,n,1,94);
Print2DArray(myArray);

Console.WriteLine();

Print2DArray(ReverseArray(myArray));

// Задача 3. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] Create2DArrayRand(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    {
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                newArray[i, j] = new Random().Next(min, max);

        return newArray;
    }
}

void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("-> " + SummRow(array, i));
        Console.WriteLine();
        //Console.WriteLine(Print2DArrayAndSumOfRows(array));
    }
}

int SummRow(int[,] matr, int forRow)
{
    int summRow = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        if (m == forRow) // m(значение индекса строки) равна номеру введеной строки
        {
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                summRow += matr[m, i];
            }
        }
    }
    return summRow;
}

int Sum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += array[i, j];
                minSum += array[i, j];
            }
            else sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;cd
        }
        sum = 0;
    }
    return minNum;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArrayRand(m, n, 1, 9);
Print2DArray(myArray);

Console.WriteLine();
Console.WriteLine($"Row is number {Sum(myArray) + 1} have min sum of elements");