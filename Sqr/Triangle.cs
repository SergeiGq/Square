namespace Sqr;

public class Triangle
{
    public double Line1 { get; set; }
    public double Line2 { get; set; }
    public double Line3 { get; set; }
    
    public Triangle(double a,double b,double c)
    {
        Line1 = a;
        Line2 = b;
        Line3 = c;
    }

    public Triangle()
    {
        
    }

    public double SCalc()
    {
        if (Line3>=Line1+Line2||Line2>=Line1+Line3||Line1>=Line2+Line3)
        {
            throw new Exception("Такого треугольника не существует");
            return 0;
        }
        double p = (Line1 + Line2 + Line3) / 2;
        double s = Math.Sqrt(p * (p - Line1) * (p - Line2) * (p - Line3));
        return s;
    }
    public double SCalc(double a,double b,double c)
    {
        if (c<a+b||a<c+b||b<a+c)
        {
            throw new Exception("Такого треугольника не существует");
            return 0;
        }
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }

    public bool GetIsRectangularTriangle()
    {
        if ( Line1 * Line1 + Line2 * Line2 == Line3 * Line3|| Line3 * Line3 + Line2 * Line2 == Line1 * Line1|| Line1 * Line1 + Line3 * Line3 == Line2 * Line2)
        {
            return true;
        }
        return false;
    }
    
}