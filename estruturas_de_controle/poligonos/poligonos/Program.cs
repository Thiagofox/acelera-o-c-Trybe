namespace poligonos;
public class Polygon
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Identifypolygon(3));
    }

    public static string Identifypolygon(int sideCount)
    {
        var name = "";

        switch (sideCount)
        {
            case < 3:
                name = "Não é um polígono";
                break;

            case 3:
                name = "Triângulo";
                break;

            case 4:
                name = "Quadrado";
                break;

            case 5:
                name = "Pentágono";
                break;

            default:
                name = "Polígono não identificado";
                break;
        }
        return name;
    }
}
