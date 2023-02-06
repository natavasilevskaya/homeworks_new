// Задача 1. Программа задает массив из 8 элементов, заполняет его нулями и единицами и вывести их на экран.

int[] FillArray (int size, int min, int max)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    {
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
    }
}

int [] myArray = FillArray(8, 0, 1);
PrintArray(myArray);

// Задача 2. Программа создает массив. Принимает на вход число и показывает, содержит ли заданный массив это число

int[] CreateArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random() .Next(minValue,maxValue+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

bool IsExistElement(int[] array, int n)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == n)
        {
            return true;
        }
    }
    return false;
}

int[] myArray = CreateArray(18, 1, 9);
PrintArray(myArray);

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

if(IsExistElement(myArray, num)) Console.WriteLine("Element exist");
else Console.WriteLine("Where is no element");

// Задача 3. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] FillThreeDigitNum (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random() .Next(minValue, maxValue);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " " );
    }
    Console.WriteLine();
}

int ShowAmountEven (int[] array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int ShowAmountOdd (int[] array) 
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 > 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] myArray = FillThreeDigitNum(12, 100, 1000);
ShowArray(myArray);

int sumEven = ShowAmountEven(myArray);
int sumOdd = ShowAmountOdd(myArray);
Console.WriteLine($"The number of even elements is {sumEven}, and odd elements is {sumOdd}");

// Задача 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreateArray (int size)
{
    int[] someArray = new int[size];
    for(int i = 0; i < someArray.Length; i++)
    {
        someArray[i] = new Random().Next(-21, 199);
    }
    return someArray;
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            sum+=1;
        }
    }
    return sum;
}

int[] array = CreateArray(123);
PrintArray(array);

int amount = FindElements(array);
Console.WriteLine("Amount of elements in range 10-99 is " + amount);

// Задача 5.Задается массив. Программа находит сумму чисел, стоящих на нечетной позиции

int[] CreateRandomArray (int size, int min, int max)
{
    int[] myArray = new int[size];

    {
        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = new Random().Next(min, max);
        }
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOfElementsOddPos(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0)
        {
            sum += array[i];

        }
    }
    return sum;
}

int[] array = CreateRandomArray(12, 1, 23);
PrintArray(array);

int sum = SumOfElementsOddPos(array);

Console.WriteLine("Sum of elements with odd position is " + sum);

// Задача 6. Программа находит произведения пар чисел в одномерном массиве - 1-последний, второй-предпоследний

int[] CreateArray(int size, int min, int max)
{
    int[] someArray = new int[size];

    for(int i = 0; i < someArray.Length; i++)
    {
        someArray[i] = new Random() .Next(min,max);
    }
    return someArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Если количество элементов в массиве - четное количество, если нечетное - добавить условие
int[] ProdOfPairs (int[] array)
{
    int j = array.Length - 1;
    int[] myArray = new int[array.Length / 2];
    int prod = 1;

    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        prod = array[i] * array[j];
        j--;
        myArray[i] = prod;
    }
    return myArray;
}

int[] myArray = CreateArray(6, 1, 9);
PrintArray(myArray);

PrintArray(ProdOfPairs(myArray));

// Задача 7. Программа задает массив вещественных чисел и находит разницу между максимальным и минимальным элементом.

double[] CreateArray (int size, int min, int max)

{
    double[] myArray = new double[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(1,10) + new Random().NextDouble();
    }
    return myArray;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write("{0:0.##} ", array[i]);
    Console.WriteLine();
}

double DiffMinMax (double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
            if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    double decision = maxNumber - minNumber;
    return decision;
}

double[] someArray = CreateArray(6, 1, 12);
PrintArray(someArray);

double num = DiffMinMax(someArray);
Console.WriteLine("The difference between the largest and smallest array element is " + "{0:0.##}", num);
    
    


