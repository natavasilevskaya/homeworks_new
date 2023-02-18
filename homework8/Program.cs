// Задача 1. Составить частотный словарь элементов двумерного массива

int[,] Create2DArr(int m, int n)
{
    int[,] myArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            myArray[i, j] = new Random().Next(0, 10);

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

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DArr(rows, columns);
Print2DArray(array);

int[] num = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int[] count = new int[9];

for (int i = 0; i < num.Length; i++)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            if (array[k, m] == num[i])
                count[i]++;
        }
    }
}

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($" Number {num[i]} is repeating in the array {count[i]} time ");
}

// Задача 2. Программа принимает на вход две матрицы, находит их произведение и выводит результат в консоль
// Программа будет работать только с двумерными массивами, с одинаковым размером столбцов и строк. Можно добавить проверку

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minValue, maxValue);
    return matrix;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultipleMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] prodOfMatrixes = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix1.GetLength(1); j++)
            prodOfMatrixes[i, j] = matrix1[i, j] * matrix2[i, j];
    return prodOfMatrixes;
}

int[,] myArray = CreateMatrix(3, 4, 1, 9);
Console.WriteLine("Matrix 1:");
PrintArray(myArray);

int[,] myArray2 = CreateMatrix(3, 4, 1, 9);
Console.WriteLine("Matrix 2:");
PrintArray(myArray2);

Console.WriteLine("Product of Matrix1 and Matrix2 is: ");
int[,] prodMat = MultipleMatrix(myArray, myArray2);

PrintArray(prodMat);


// Задача 3. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] Create2DArr(int m, int n)
{
    int[,] myArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            myArray[i, j] = new Random().Next(0, 99);

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

int[,] array = Create2DArr(3, 4);
Print2DArray(array);
Console.WriteLine();

int x = 0;
int y = 0;
int min = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Min element is " + min);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((i == x) || (j == y))
            continue;
        else
            Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

// Задача 4. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

bool is3dArray10to99(int x, int y, int z)
{
    if (x * y * z > 99)
    {
        return false;
    }
    else if (x <= 0 || y <= 0 || z <= 0)
    {
        return false;
    }
    return true;
}

int getRandomNumber10to99()
{
    return new Random().Next(10, 100);
}

bool isNumberToList(int targetNumber, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (targetNumber == array[i, j, k])
                    return true;
            }
    return false;
}
int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    int[,,] numberArray = new int[matrix.GetLength(0), matrix.GetLength(1), matrix.GetLength(2)];
    int num = 10;

    if (!is3dArray10to99(row, col, dep))
    {
        Console.WriteLine("It is not possible to create a 3-dimensional array with non-repeated two-digit numbers, row*col*dep must be < 89");
        int[,,] arr = new int[0, 0, 0];
        return arr;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int number = getRandomNumber10to99();

                while (isNumberToList(number, numberArray))
                {
                    number = num;
                    num += 1;
                }
                numberArray[i, j, k] = number;
                matrix[i, j, k] = number;
            }


        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во 3D стобцов массива: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array3D = CreateMatrix(rows, column, z, 10, 98);
PrintMatrix(array3D);

// Задача 5. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int row = 8;
int[,] triangle = new int[row, row];
const int tab = 2;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void Magic()
{
    int columns = tab * row;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(columns, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],tab}");
            columns += tab * 2;
        }
        columns = tab * row - tab * (i + 1);
        Console.WriteLine();
    }
}

Console.ReadLine();
FillTriangle();
Console.ReadLine();
Magic();