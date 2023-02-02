// Задача 1. Программа принимает на вход число 1-7 и сообщает пользователю, является ли этот день выходным

void FreeDay (int n)
{
if(n < 6) 
{
    Console.WriteLine("It is working day ");
}
if(n == 6 || n == 7) 
{
    Console.WriteLine("It is holiday! ");
}
else 
{
    Console.WriteLine("It is not correct number, choose number in range 1-7");
}
}

Console.WriteLine("Input number 1-7: ");
int num = Convert.ToInt32(Console.ReadLine());

FreeDay(num);


// Задача 2. Программа принимает на вход 2 числа и проверяет, является ли первое квадратом второго

void QuadCheck (int n1, int n2)
{
int quad2 = n2 * n2;

if(n1 == quad2)
{
    Console.WriteLine($"{n1} is quad of {n2}");
}
else
{
    Console.WriteLine($"{n1} is not quad of {n2}");
}
}

Console.WriteLine("Input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

QuadCheck(num1, num2);

// Задача 3. Программа принимает на вход номер четверти и выводит в консоль диапозоны для возможных координат

void FindRange (int n)
{
    if (n == 1) Console.WriteLine("Range of possible coordinates is X > 0 and Y > 0");
    if (n == 2) Console.WriteLine("Range of possible coordinates is X < 0 and Y > 0");
    if (n == 3) Console.WriteLine("Range of possible coordinates is X < 0 and Y < 0");
    if (n == 4) Console.WriteLine("Range of possible coordinates is X > 0 and Y < 0");
    if (n > 4 || n <1) Console.WriteLine("It is not correct number, choose number 1-3");
}

Console.WriteLine("Input number of part(1-4) ");
int num = Convert.ToInt32(Console.ReadLine());

FindRange(num);

// Задача 4.1 Программма принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindPoin2D (double x1, double y1, double x2, double y2)
{
double distance = Math.Sqrt ((x1 - x2)*(x1-x2) + (y1 - y2)*(y1-y2));
return distance;
}

Console.WriteLine ("Input point x1 number");
double x1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y1 number");
double y1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point x2 number");
double x2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y2 number");
double y2 = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine("The distance between two points in space is " + FindPoin2D (x1, y1, x2, y2));


// Задача 4.2 Программма принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindPoin3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
return distance;
}

Console.WriteLine ("Input point x1 number");
double x1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y1 number");
double y1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point z1 number");
double z1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point x2 number");
double x2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y2 number");
double y2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point x1 number");
double z2 = Convert.ToDouble(Console.ReadLine ());


Console.WriteLine("The distance between two points in space is " + FindPoin3D (x1, y1, z1, x2, y2, z2));

