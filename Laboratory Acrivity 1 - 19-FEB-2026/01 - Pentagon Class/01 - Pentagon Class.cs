internal class Program
{
    private static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon();
        p1.Sides = 5;

        double perim = p1.GetPerimeter(p1.Sides);
        double area = p1.GetArea(p1.Sides);

        Pentagon.Display(p1.Sides, area, perim);
    }
}

class Pentagon
{
    private double _sides;

    public double Sides
    {
        get => _sides;
        set => _sides = value;
    }
    public double GetPerimeter(double Sides)
    {
        double perim = 5 * Sides;
        return perim;
    }

    public double GetArea(double Sides)
    {
        double area = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * (Sides * Sides)) / 4;
        return area;
    }

    public static void Display(double Sides, double area, double perim)
    {
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Side length: {0}", Sides);
        Console.WriteLine("Perimeter: {0:N3}", perim);
        Console.WriteLine("Area: {0:N3}", area);
    }
}