namespace triangulos;

public class Triangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IdentifyTriangle(4, 4, 4));
    }
    public static string IdentifyTriangle(double xSide, double ySide, double zSide)
    {
        var name = "";


        if (xSide == ySide && xSide == zSide)
        {
            name = "Triângulo Equilátero";
        }
        else if ((xSide == ySide) || (xSide == zSide) || (ySide == zSide))
        {
            name = "Triângulo Isóscele";
        }
        else
        {
            name = "Triângulo Escaleno";
        }
        return name;
    }

}

