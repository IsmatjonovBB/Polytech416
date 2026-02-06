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
        Console.WriteLine("------------");
        
        // #2
        int a = 4;
        result = Square(a);
        Console.WriteLine($"Result: {result}");
        Console.WriteLine("------------");
        
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
        Console.WriteLine("------------");
        
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
        Console.WriteLine("------------");
        
        // #5
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int average = GetAverage(numbers);
        Console.WriteLine($"Average: {average}");
        Console.WriteLine("------------");
        
        // #6
        int[,] massive =
        {
            { 5, 9, 1 },
            { 3, 6, 7 },
            { 2, 5, 8 }
        };
        int max = MaxValue(massive);
        Console.WriteLine($"Max: {max}");
        Console.WriteLine("------------");
        
        // #7
        char[] charArray = { 'B', 'a', 'k', 'h', 't', 'o', 'v', 'a', 'r' };
        char[] sortedChar = SortChars(charArray);
        Console.Write("{ ");
        foreach (var c in sortedChar)
        {
            Console.Write(c + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        Console.WriteLine("------------");
        
        // #8
        int[] intArray = MyMethod(2, 4);
        Console.Write("{ ");
        foreach (int arr in intArray)
        {
            Console.Write(arr + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        
        char[] CharArray = MyMethod('A', 'Z');
        Console.Write("{ ");
        foreach (char arr in CharArray)
        {
            Console.Write(arr + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        Console.WriteLine("------------");
        
        // #9
        int[] Method9 = MaxAndMin(3, 8, 0, 4, 9);
        Console.Write("{ ");
        foreach (int arr in Method9)
        {
            Console.Write(arr + " ");
        }
        Console.Write("};");
        Console.WriteLine();
        Console.WriteLine("------------");
        
        // #10
        string text = "Hello ";
        string newText = CreateText(text, 'H', 'o', 'r', 'l', 'd', '!');
        Console.WriteLine(newText);
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

    static int MaxValue(int[,] intArray)
    {
        int max = intArray[0, 0];
        int a = 0;
        int b = 0;
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                if (max < intArray[i, j])
                {
                    max = intArray[i, j];
                    a = i;
                    b = j;
                }
            }
        }
        return max;
    }

    static char[] SortChars(char[] array)
    {
        char[] result = new char[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i];
        }
        return result;
    }

    static int[] MyMethod(int x, int y)
    {
        int[] result = new int[y - 1];
        for (int i = 0, j = x; i < y - 1; i++)
        {
            result[i] = j;
            j++;
        }
        return result;
    }

    static char[] MyMethod(char x, char y)
    {
        int arrLen = y - x;
        int[] chatToIntArray = new int[arrLen + 1];
        for (int i = 0; i <= arrLen; i++)
        {
            chatToIntArray[i] = x;
            x++;
        }
        char[] result = new char[chatToIntArray.Length];
        for (int i = 0; i < chatToIntArray.Length; i++)
        {
            result[i] = (char)chatToIntArray[i];
        }
        return result;
    }

    static int[] MaxAndMin(params int[] numbers)
    {
        int[] massive = numbers;
        int max = 0;
        int min = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            if (max < massive[i])
            {
                max = massive[i];
            }

            if (min > massive[i])
            {
                min = massive[i];
            }
        }
        int[] resultArray = { min, max};
        return resultArray;
    }

    static string CreateText(string text, params char[] symbols)
    {
        string result = "";
        for (int i = 0; i < symbols.Length; i++)
        {
            result += symbols[i];
        }
        return text + result;
    }
}