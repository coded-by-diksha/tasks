//task 2
class Circle
{
    public const double PI = 3.14;

    public static double Area(double radius) => PI * radius * radius;

    public static double Perimeter(double radius) => 2 * PI * radius;
    static void Main(string[] args)
    {
        double radius = 5.0;
        Console.WriteLine();
        Console.WriteLine($"Circle PI constant: {Circle.PI}");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {Circle.Area(radius)}");
        Console.WriteLine($"Perimeter: {Circle.Perimeter(radius)}");
    }

}
