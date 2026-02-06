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
}