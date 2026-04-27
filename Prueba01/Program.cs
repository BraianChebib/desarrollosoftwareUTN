using ProyectoUTN.Services;

class Program
{
    static void Main(string[] args)
    {
        var calculadora = new CalculadoraService();
         var input = new InputService();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Elegí una opción: ");

            string opcion = input.LeerOpcionValida();

            if (opcion == "5")
            {
                continuar = false;
                break;
            }

            // VALIDACIÓN NÚMERO 1
            int num1 = input.LeerNumero("Ingresá el primer número: ");

            // VALIDACIÓN NÚMERO 2
            int num2 = input.LeerNumero("Ingresá el segundo número: ");

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {calculadora.Sumar(num1, num2)}");
                    break;

                case "2":
                    Console.WriteLine($"Resultado: {calculadora.Restar(num1, num2)}");
                    break;

                case "3":
                    Console.WriteLine($"Resultado: {calculadora.Multiplicar(num1, num2)}");
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("ERROR: No se puede dividir por 0");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {calculadora.Dividir(num1, num2)}");
                    }
                    break;

                default:
                    Console.WriteLine("ERROR: Opción inválida");
                    break;
            }

            Console.WriteLine();
        }
    }
}   