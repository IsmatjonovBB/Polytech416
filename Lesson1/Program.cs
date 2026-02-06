using System.Xml;

namespace Lesson1;

class Program
{
    static void Main(string[] args)
    {
        // #1
        int n = 6;
        int result = Factorial(n);
        Console.WriteLine($"{n}!! = {result}");
        n = 5;
        result = Factorial(n);
        Console.WriteLine($"{n}!! = {result}");
        
        // #2
        int a = 4;
        result = Square(a);
        Console.WriteLine($"Result: {result}");
        
        // #3
        int[] array = { 1, 2, 3, 4, 5 };
        int[] newArray = GetArray(array, 2);
        Console.Write("{ ");
        foreach (var nr in newArray)
        {
            Console.Write(nr + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        
        // #4
        char[] symbols = { 'c', 's', 'h', 'a', 'r', 'p' };
        int[] charToint = GetInteger(symbols);
        Console.Write("{ ");
        foreach (var ints in charToint)
        {
            Console.Write(ints + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        
        // #5
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int average = GetAverage(numbers);
        Console.WriteLine($"Average: {average}");
    }
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = n; i >= 1; i -= 2)
        {
            result *= i;
        }
        return result;
    }
    static int Square(int n)
    {
        int summa = 0;
        for (int i = 1; i < n; i++)
        {
            summa += i * i;
        }
        return summa;
    }

    static int[] GetArray(int[] array, int n)
    {
        if (array.Length < n)
        {
            return array;
        }
        else
        {
            int[] newArray = new int[array.Length - n];
            for (int i = n, j = 0; j < array.Length - n; i++)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }
    }

    static int[] GetInteger(char[] symbol)
    {
        int[] ints = new int[symbol.Length];
        for (int i = 0; i < symbol.Length; i++)
        {
            ints[i] = symbol[i];
        }
        return ints;
    }

    static int GetAverage(int[] intArray)
    {
        int result = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            result += intArray[i];
        }
        return result / intArray.Length;
    }
}