internal class Program
{
    private static void Main(string[] args)
    {
        // Declare variables;
        string heightStr, radiusStr;
        float height, radius;
        float vol, supArea;

        // Ask the user for height;
        Console.Write("Input a height: ");
        heightStr = Console.ReadLine();

        // Ask the user for radius;
        Console.Write("Input a radius: ");
        radiusStr = Console.ReadLine();

        // Convert height string to height float;
        height = Convert.ToSingle(heightStr);

        // Convert radius string to radius float;
        radius = Convert.ToSingle(radiusStr);

        // Calculate volume;
        vol = (float)Math.PI * (float)Math.Pow(radius, 2) * height;

        // Calculate superficial area;
        supArea = 2 * (float)Math.PI * radius + height;

        // Show volume;
        Console.WriteLine($"Volume is {vol:f3}");

        // Show superficial area;
        Console.WriteLine($"Superficial area is {supArea}");

        
    }
}