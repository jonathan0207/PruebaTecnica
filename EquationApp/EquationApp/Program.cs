using System;

namespace EcuacionCuadratica
{
    class Ecuacion
    {
        static void Main()
        {
            double A, B, C;
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

                switch (opcion)
                {
                    case '1':
                        Console.Write("Ingresa el valor de A: ");
                        A = double.Parse(Console.ReadLine());

                        Console.Write("Ingresa el valor de B: ");
                        B = double.Parse(Console.ReadLine());

                        C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
                        Console.WriteLine($"El valor de C es: {C}");
                        break;

                    case '2':
                        Console.Write("Ingresa el valor de B: ");
                        B = double.Parse(Console.ReadLine());

                        Console.Write("Ingresa el valor de C: ");
                        C = double.Parse(Console.ReadLine());

                        A = Math.Sqrt(Math.Pow(C, 2) + Math.Pow(B, 2));
                        Console.WriteLine($"El valor de A es: {A}");
                        break;

                    case '3':
                        Console.Write("Ingresa el valor de A: ");
                        A = double.Parse(Console.ReadLine());

                        Console.Write("Ingresa el valor de C: ");
                        C = double.Parse(Console.ReadLine());

                        B = Math.Sqrt(Math.Pow(C, 2) + Math.Pow(A, 2));
                        Console.WriteLine($"El valor de B es: {B}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }


                Console.Write("¿Quieres realizar un nuevo calculo? (s/n): ");
                continuar = Console.ReadLine()[0];
            }
            while (continuar != 'n' && continuar != 'N' && continuar != ' ');
            Console.WriteLine("HASTA PRONTO");
        }

    }
}
