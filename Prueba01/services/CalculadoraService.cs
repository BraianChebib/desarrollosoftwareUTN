namespace ProyectoUTN.Services
{
    public class InputService
    {
        public string LeerOpcionValida()
        {
            while (true)
            {
                Console.Write("Elegí una opción (1-5): ");
                string opcion = Console.ReadLine();

                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5")
                    return opcion;

                Console.WriteLine("ERROR: Opción inválida. Elegí entre 1 y 5.");
            }
        }

        public int LeerNumero(string mensaje)
        {
            int numero;

            while (true)
            {
                Console.Write(mensaje);

                if (int.TryParse(Console.ReadLine(), out numero))
                    return numero;

                Console.WriteLine("ERROR: Entrada inválida. Ingresá un número.");
            }
        }
    }
    
    public class CalculadoraService
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            return (double)a / b;
        }
    }
}