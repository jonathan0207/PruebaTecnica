using System;

namespace EcuacionCuadratica
{

    public class EcuacionCuadratica
    {
        public void CalcularEcuacion(char option)
        {
            double A, B, C;
            switch (option)
            {
                case '1':
                    A = SolicitarValor("Ingresa el valor de A: ");
                    B = SolicitarValor("Ingresa el valor de B: ");
                    C = Math.Pow(Math.Pow(A, 2) + Math.Pow(B, 2), 2);
                    Console.WriteLine($"El valor de C es: {C}");
                    break;

                case '2':
                    B = SolicitarValor("Ingresa el valor de B: ");
                    C = SolicitarValor("Ingresa el valor de C: ");
                    A = Math.Pow(Math.Pow(C, 2) + Math.Pow(B, 2), 2);
                    Console.WriteLine($"El valor de A es: {A}");
                    break;

                case '3':
                    A = SolicitarValor("Ingresa el valor de A: ");
                    C = SolicitarValor("Ingresa el valor de C: ");
                    B = Math.Pow(Math.Pow(C, 2) + Math.Pow(A, 2), 2);
                    Console.WriteLine($"El valor de B es: {B}");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }

        static double SolicitarValor(string mensaje)
        {
            double valor;
            string input;

            while (true)
            {
                Console.Write(mensaje);
                input = Console.ReadLine();

                if (double.TryParse(input, out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Error: Ingresa un número válido.");
                }
            }
        }
    }

    class Ecuacion
    {
        static void Main()
        {
            char opcion;
            char continuar;
            do
            {

                Console.WriteLine("Ecuación:");
                Console.WriteLine("Selecciona qué opcion deseas calcular");
                Console.WriteLine("1. Calcular C");
                Console.WriteLine("2. Calcular A");
                Console.WriteLine("3. Calcular B");
                opcion = Console.ReadLine()[0];
                EcuacionCuadratica calculo = new EcuacionCuadratica();
                calculo.CalcularEcuacion(opcion);
                Console.WriteLine("¿Quieres realizar un nuevo calculo? Pulsa s para continuar:");
                Console.WriteLine("Ingresa cualquier tecla para salir");
                continuar = Console.ReadLine()[0];


            }
            while (continuar == 'S' || continuar == 's');
            Console.WriteLine("HASTA PRONTO");

        }
    }
}
