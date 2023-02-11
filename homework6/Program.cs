
// Задача 1. Программа задает двумерный массив mxn и заполненняем его случайными вещественными числами.

// двумерный массив - это матрица, табличное представление, которое формируется из системы строки-столбцы, а обращение к элементам происходит уже по 
// двум индексам - строки и столбцы - row and columns

double[,] CreateRandom2DArray(int rows, int columns)
{

    double[,] myArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            myArray[i, j] = new Random().Next(1,9) + new Random().NextDouble();
    return myArray;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0:0.#} ", array[i, j] );
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(m, n);
Print2DArray(myArray);


// Задача 2.Программа задает двумерный массив m на n правилом: Aₘₙ = m + n и выводит его в терминал

int[,] Create2DArr(int m, int n, int min, int max)
{
    int[,] myArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            myArray[i, j] = i + j;

    return myArray;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input num of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Create2DArr(m, n, 1, 99);
Print2DArray(arr);


// Задача 3. Программа принимает на вход двумерный массив. Находит элементы, у которых оба индекса чётные, и заменяет эти элементы на их квадраты.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] myArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            myArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return myArray;
}

void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] RechangeQuad(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // i+=2 - цикл будет пробегаться сразу по четным индексам и возводить в квадрат
    {
        for (int j = 0; j < array.GetLength(1); j++) // j+=2 - тогда проверку на четность i можно будет опустить
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }

        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, 1, 9);
Print2DArray(myArray);

Print2DArray(RechangeQuad(myArray));

// Задача 4. Программа принимает на вход массив и обменивает элементы первой строки и последней строки

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

        Console.WriteLine();
    }
}

int[,] RechangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;
    }
    return array;

}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArrayRand(m, n, 1, 94);
Print2DArray(myArray);

Print2DArray(RechangeRows(myArray));

