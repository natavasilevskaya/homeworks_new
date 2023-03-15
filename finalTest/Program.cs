string[] array = new string[] { "verification", "o11", "27", "sdgwiuhlq;j", "sun", "213", "constant" };

void PrintArray(string[] arr)
{   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] CheckElements(string[] arr)
{
    int maxLength = 3;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength)
        {
            arr[i] = arr[i];
        }
        else arr[i] = "";
    }
    return arr;
}

Console.Write("Initial array: ");
PrintArray(array);
Console.Write("New array: ");
PrintArray(CheckElements(array));
