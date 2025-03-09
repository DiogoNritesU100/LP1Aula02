internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 5;
        int c = a++ + --b;
        
        Console.WriteLine($"a={a}"); // 2
        Console.WriteLine($"b={b}"); // 4
        Console.WriteLine($"c={c}"); // 1 + 4 = 5
        

    }
}