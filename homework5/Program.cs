// Задача 1. Программа принмиает на вход координаты двух прямых, заданных точками  y = k1 * x + b1, y = k2 * x + b2, где b1, k1 и b2, k2 вводит пользователь и находит точку их пересечения.

void PointOfIntersection (int k1, int b1, int k2, int b2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Lines are match!");

    else if(k1 == k2)
        Console.WriteLine("Lines are parallel!");

    else
    {
        string result = string.Empty;
        
        int x = 0;
        int y = 0;
        x = (b2-b1)/(k1-k2);  
        y = (k1*(b2-b1))/(k1-k2)+b1;
        // x = (b1 - b2) / (k2 - k1);
        // y = (k2 * b1  - k1 * b2)/(k2-k1); 
        result = $"({x}, {y})";
        Console.WriteLine(result);
    }
}

PointOfIntersection(2, -1, 2, -12);

// Задача 2. // Числа Фиббоначи - каждое следующее задается через предыдущее
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("Input number of elements of Fibonaci: ");
int length = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= length; i++)
{
    Console.Write(Fibonacci(i) + " ");
}

// Задача 3. Программа принимает на вход координаты фигуры - (0,0) (2,0) (2,2) (0,2) и масштабирует фигуру.

double[] Scaling(double[] array, double n)
{
    double[] newArray = new double[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * n;
    }
    return newArray;
}

void PrintArray(double[] array)
{   
    double x1 = array[0];
    double y1 = array[1];
    double x2 = array[2];
    double y2 = array[3];
    double x3 = array[4];
    double y3 = array[5];
    double x4 = array[6];
    double y4 = array[7];

    Console.WriteLine($"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})");
}

double[] myArray = {0, 0, 2, 0, 2, 2, 0, 2};
Console.WriteLine("Input coef of scaling: ");
double coef = Convert.ToDouble(Console.ReadLine());
PrintArray(Scaling(myArray, coef));

// string Scaling(double x1, double y1, double x2, double y2, 
// double x3, double y3, double x4, double y4, double k)
// {
//     x1 = x1 * k;
//     y1 = y1 * k;
//     x2 = x2 * k;
//     y2 = y2 * k;
//     x3 = x3 * k;
//     y3 = y3 * k;
//     x4 = x4 * k;
//     y4 = y4 * k;
    
//     return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
// }

// Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, 0.5));

// Задача 4. Программа принимает на вход массив, создает его копию и выводит ее на экран

int[] CreateRandomArray(int size, int min, int max)
{
    Console.WriteLine("Original array: ");

    int[] myArray = new int[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(min,max);
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{   
    Console.WriteLine("Copy of array: ");

    int size = array.Length;
    int[] copyArray = new int[size];

    for(int i = 0; i < array.Length; i++)
    {   
        copyArray[i] = array[i];
    }
    return copyArray;   
}

int[] arr = CreateRandomArray(12, 10, 29);
PrintArray(arr);

PrintArray(CopyArray(arr));
