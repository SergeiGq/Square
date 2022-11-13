namespace Sqr;

public class Circle
{
    private double Radius { get; set; }

    public Circle(double r )
    {
        Radius = r;
    }
    public double S()
    {
        if (Radius<0)
        {
            throw new Exception("Неверный радиус");
        }
        return Radius * Radius * Math.PI;
        
    }
}