using ProyectoUTN.Services;

class Program
{
    static void Main(string[] args)
    {
        var calculadora = new CalculadoraService();

        Console.WriteLine(calculadora.Sumar(5, 3));
        Console.WriteLine(calculadora.Restar(5, 3));
    }
}