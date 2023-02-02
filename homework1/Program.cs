/ Задача 1. Вывести квадрат числа

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int quad = n * n;

Console.WriteLine($"Quad of {n} is {quad}");

// Задача 2. По двум заданным чслам проверить, является ли первое число квадратом второго

Console.WriteLine("Input 1st number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 1st number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad = n2 * n2;

if (n1 == quad)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

// Задача 3. По номеру дня недели вывести его название

Console.WriteLine("Input number 1-7: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("Today is Mondey!");
}
if (n == 2)
{
    Console.WriteLine("Today is Tuesday!");
}
if (n == 3)
{
    Console.WriteLine("Today is Wednesday!");
}
if (n == 4)
{
    Console.WriteLine("Today is Thursday!");
}
if (n == 5)
{
    Console.WriteLine("Today is Friday!");
}
if (n == 6)
{
    Console.WriteLine("Today is Sunday!");
}
if (n == 7)
{
    Console.WriteLine("Today is Mondey!");
}

else
{
    if (n>7)
    {
        Console.WriteLine("It is not correct number!");
    }
}

//Задача 4. Программа на вход принимает 3 числа. Найти максимальное

Console.WriteLine("Input 1st number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 3rd number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.WriteLine("Max number is " + max);

// Задача 5 Программа принимает на вход число и проверяет, является ли оно четным

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 > 0)
{
    Console.WriteLine($"Number {num} is odd");
}
else
{
    Console.WriteLine($"Number {num} is even");
}

// Задача 6. Программа принимает на вход число N и показывает все четные числа в диапазоне до этого числа

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=num; i++) 
{
    if(i%2 == 0) 
    {
        Console.Write(i + " ");
    }
}

// Задача 7. Программа принимает на вход трехзначное число и выводит в терминал его последнюю цифру

Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine($"The last digit of {num} is {lastDigit}");
}
else
{
    Console.WriteLine("It is not correct number! Choose number in range 100 - 999 and try again");
}

// Задача 8. Задача принимает на вход трехзначное число и выводи вторую цифру этого числа в терминал

Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
{
    int lastDigit = num % 100 / 10;
    Console.WriteLine($"The second digit of {num} is {lastDigit}");
}
else
{
    Console.WriteLine("It is not correct number! Choose number in range 100 - 999 and try again");
}

// Задача 9. Программа генерирует случайное число в диапазоне от 10 до 99 и показывает большую цифру этого числа

int num = new Random ().Next(10,99);  //10,11...99

int firstDigit = num / 10;
int secondDigit = num % 10;

if(firstDigit > secondDigit)
{
    Console.WriteLine($"The max digit of {num} is {firstDigit}");

}
if(firstDigit < secondDigit)
{
    Console.WriteLine($"The max digit of {num} is {secondDigit}");
}
else
if (firstDigit == secondDigit)
{
    Console.WriteLine("Digits are equal, because number is " + num);
}

// Задача 9. Программа принимает на вход трехзначное число. Необходимо удалить вторую цифру числа и вывести результат в терминал

int num = new Random ().Next(100,999);  //10,11...99
Console.WriteLine(num);

int result = num / 100 * 10 + num % 10;
Console.WriteLine(result);

//Задача 10. Программа принимает на вход число, и проверяет, кратно ли оно N. Если число не кратно N - программа выводит остаток от деления

int num = new Random ().Next(100,999);
int n = 5;

if(num % n == 0)
{
    Console.WriteLine($"{num} multiple {n}");
}
else
{
    Console.WriteLine(num);
    Console.WriteLine(num % n);
}

// Задача 11. Программа принимает на вход число, выводит в терминал его третью цифру, или сообщает, что таковой нет

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num);

if(num >= 100 && num <= 999)
{
    Console.WriteLine(num % 10);
}

if(num > 999 && num < 9999)
{
    Console.WriteLine(num / 10 % 10);
}

if(num < 100)
{
    Console.WriteLine("This number has not third digit");
}

else
{
    Console.WriteLine("Its not avalibale range, use numbers 0 - 9999");
}

//Будет работать для чисел в диапозоне от 0 до 9999, чтобы расширить диапозон - увеличивать цифру, на которую
// будет делиться число на 0 - пр: num / 1000 % 10 - позволит работать с пятизначными числами и т.д.

