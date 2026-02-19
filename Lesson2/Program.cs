using System.Data.Common;
using System.Threading.Channels;

namespace Lesson2;

class Program
{
    static void Main(string[] args)
    {
        // Масъалаҳо барои List<>
        // #1
        List<int> numbers = new List<int>() { 5, 4, 8, 1, -1, 6, 0, 12 };
        int min = numbers.Min();
        numbers.Remove(min);
        numbers.Add(min);
        foreach (int number in numbers)
            Console.Write(number + " ");
        Console.WriteLine();
        
        // #2
        List<int> numbers2 = new List<int>() { 12, 85, 45, -98, 1, 74, 0, 33 };
        numbers2.Insert(numbers2.Count / 2, numbers2.Sum());
        foreach (int number2 in numbers2)
            Console.Write(number2 + " ");
        Console.WriteLine();
        
        // #3
        List<int> numbers3 = [2, 8, -5, 0, 12, -10, 36, 2, -25];
        numbers3.RemoveAll(a => a < 0);
        foreach (int number in numbers3)
            Console.Write(number + " ");
        Console.WriteLine();
        
        // #4
        List<double> numbers4 = new List<double> { 1.4, 6.5, 7.8, 0.9, 10.1, 3.4, 5.6 };
        for (int i = 1; i < numbers4.Count; i += 2)
            numbers4.RemoveAt(i);
        foreach (var number in numbers4)
            Console.Write(number + " ");
        Console.WriteLine();
        
        // #5
        List<string> names = new List<string> { "Vali", "Ali", "Daler", "Bakhtovar" };
        names.Sort();
        foreach (var name in names)
            Console.Write(name + " ");
        Console.WriteLine();

        Console.WriteLine("- - - - - - - - - - - -");
        
        // Масъалаҳо барои Dictionary<>
        // #1
        Console.WriteLine("Масъалаи №1");
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        contacts.Add("+992937770771", "Bakhtovar Ismatjonov");
        contacts.Add("+992105000510", "Saidov Salmon");
        contacts.Add("+992927331070", "Osimkhon Pulotov");
        contacts.Add("+992976666609", "Madalizoda Muhammadshakur");
        contacts.Add("+992551115750", "Asiri Safokhon");
        
        string person = Name("+992937770771");
        Console.WriteLine($"Name: {person}");
        
        string Name(string tel)
        {
            if (contacts.ContainsKey(tel))
                return contacts[tel];
            return "Not found";
        }
        Console.WriteLine();
        
        // #2
        Console.WriteLine("Масъалаи №2");
        string text = "apple banana apple orange banana apple";
        string[] textArray = text.ToLower().Split(' ').ToArray();
        Dictionary<string, int> counter = new Dictionary<string, int>();
        foreach (string t in textArray)
            if (counter.ContainsKey(t))
                counter[t]++;
            else
                counter.Add(t, 1);
        foreach (var count in counter)
            Console.WriteLine($"Word: {count.Key}, Count: {count.Value}");
        Console.WriteLine();
        
        // #3
        Console.WriteLine("Масъалаи №3");
        Dictionary<string, int> products = new Dictionary<string, int>
        {
            {"Ҷадвал", 7}, 
            { "Китоб", 50 }, 
            { "Ручка", 5 }, 
            { "Қалам", 12 }, 
            { "Дафтар", 20 }
        };

        Sell("Ручка", 5);
        Sell("Бӯр", 5);
        Buy("Дафтар", 5);
        Search("Қалам");

        Console.WriteLine();
        foreach (var product in products)
            Console.WriteLine($"Product: {product.Key}, Quantity: {product.Value}");
        Console.WriteLine();
        void Sell(string product, int quantity)
        {
            if (products.ContainsKey(product))
                if (products[product] >= quantity)
                    products[product] -= quantity;
                else
                    Console.WriteLine($"Инхел миқдор дар мағоза нест!");
            else
                Console.WriteLine("Чунин чиз дар мағоза нест!");
        }
        void Buy(string product, int quantity)
        {
            if (products.ContainsKey(product))
                products[product] += quantity;
            else
                products.Add(product, quantity);
        }
        void Search(string product)
        {
            if (products.ContainsKey(product))
                Console.WriteLine($"Дар мағоза {products[product]}-то {product} мавҷуд аст.");
            else
                Console.WriteLine($"Дар мағоза {product} мавҷуд нест!");
        }
        // #4
        Console.WriteLine("Масъалаи №4");
        Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
        students.Add("Bakhtovar", new List<int> { 6, 9, 7 });
        students.Add("Nurmuhamad", new List<int> { 3, 5, 1 });
        students.Add("Sharifjon", new List<int> { 10, 9, 9 });
        Dictionary<string, double> averageScore = new Dictionary<string, double>();
        foreach (var student in students)
            averageScore.Add(student.Key, student.Value.Sum() / 3);
        foreach (var score in averageScore)
            Console.WriteLine($"{score.Key}: {score.Value} ");
        Console.WriteLine();
        
        // #5
        Console.WriteLine("Масъалаи №5");
        string word = Console.ReadLine()!.ToUpper();
        Dictionary<char, int> symbols = new Dictionary<char, int>();
        foreach (char w in word)
        {
            if (symbols.ContainsKey(w))
                symbols[w]++;
            else
                symbols.Add(w, 1);
        }
        symbols.Remove(' ');
        foreach (var symbol in symbols)
            Console.WriteLine($"{symbol.Key}: {symbol.Value} ");
    }
}