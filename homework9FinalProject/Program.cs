
// Задача 1. Показать натуральные числа от N до 1, N задано

string NumberRec (int a, int b)
{
	if (a <= b) return NumberRec(a + 1, b)+ $"{a} ";
	else return String.Empty;
}

Console.WriteLine(NumberRec(1,23));

// Задача 2. Показать натуральные числа от M до N, N и M заданы

string NumberRec(int a, int b)
{
   	if (a <= b) return $"{a} " + NumberRec(a + 1, b); 
	else return String.Empty;
}

Console.WriteLine(NumberRec(7,21));

// Задача 3. Найти сумму элементов от M до N, N и M заданы

int SumRec(int m, int n)
{
	if (n == m) return n; // условие выхода
	else return m + SumRec(m+1, n);
}
Console.WriteLine(SumRec(3, 7)); 

// Задача 4. Написать программу вычисления функции Аккермана

int AckkermanFun(int m, int n)
{
    if (m < 0 || n < 0 ) return -1;
    else if (m == 0) return n + 1;
    else if (n == 0) return AckkermanFun(m - 1, 1);
    else return AckkermanFun(m - 1, AckkermanFun(m, n - 1));
}   
Console.WriteLine(AckkermanFun(3, 5));

// Задача 5. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int FindSums(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;

return FindSums(x, y, num - 1) + FindSums(x, y, num - 2);
}

void PrintNums(int x, int y, int n)
{
    Console.WriteLine();
    for (int i = 1; i <= n; i++)
        Console.Write(FindSums(x, y, i) + " ");

}

Console.WriteLine("Input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input num of elements: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNums(num1, num2, N);