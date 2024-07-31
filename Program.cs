abstract class FormaGeometrica
{

    public abstract double CalcularArea();
}

class Rectangulo : FormaGeometrica
{

    public double _Largo
    {
        get; 
        set;
    }

    public double _Ancho
    {
        get; 
        set;
    }

    public Rectangulo(double largo, double ancho)
    {

        _Largo = largo;
        _Ancho = ancho;
    }

    public override double CalcularArea()  //override sobreescribe el original.
    {

        return _Largo * _Ancho;
    }
}

class Program
{

    static void Main()
    {

        FormaGeometrica rectangulo = new Rectangulo(4, 6);

        Console.WriteLine("Area del rectangulo: " + rectangulo.CalcularArea());

    }
}