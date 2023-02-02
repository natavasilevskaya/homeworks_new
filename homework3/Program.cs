// // Задача 1. Программа принимает на вход число N и выводит в терминал кубы чисел от 1 до N

void FindCubes (int n)
{
for (int i = 1; i<=n; i++) 
{
    Console.Write(i * i * i + " ");
}
}

int num = new Random(). Next(5,12);
Console.WriteLine(num);
FindCubes(num);

// Задача 2. Программа находит сумму цифр в числе (работает с числами в диапозоне 0 - 999)

void SumOfDigits (int n)
{
if (n >= 0 && n <= 9)
{
    Console.WriteLine(n);
}
if (n >= 10 && n <=99)
{
    int sum = n / 10 + n % 10;
    Console.WriteLine($"Sum of digit of number {n} is {sum}");
}
if (n >= 100 && n <=999)
{   
    int hun = n / 100;
    int dec = n % 100 / 10;
    int ed = n % 10;
    int secthDigSum = hun + dec + ed;
    Console.WriteLine($"Sum of digit of number {n} is {secthDigSum}");
}
}

int num = new Random(). Next(0,999);
Console.WriteLine(num);
SumOfDigits(num);

// Задача 3. Программа принимает на вход число N и вычисляет произведение от 1 до N.

void Factorial (int n)
{
int product = 1;

for (int i = 2; i <= n; i++) 
{
    product = product * i;
    Console.Write(product + " ");
}
}

int num = new Random(). Next(1,9);
Console.WriteLine(num);
Factorial(num);

// Задача 4. Программа принимает на вход число N, возводит числа в диапазоне от 1 до N в куб и выводит в терминал
//кубы чисел, заканчивающихся на четную цифру 

void EvenCubes (int n)
{
for (int i = 1; i<=n; i++) 
{
    if (i % 2 == 0)
    {
        Console.Write(i * i * i + " ");
    }
}
}

int num = new Random(). Next(2,15);
Console.WriteLine(num);
EvenCubes(num);