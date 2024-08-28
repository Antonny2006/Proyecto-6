// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
     bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Ventas Varias");
            Console.WriteLine("1. Transistores");
            Console.WriteLine("2. Capacitores");
            Console.WriteLine("3. Leds");
            Console.WriteLine("4. Salir");
            Console.WriteLine("================");
            Console.WriteLine("Seleccione una opcion: ");


            string opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    Console.WriteLine("Has Seleccionado la opcion 1.");
                    // Logica para la Opcion 1
                    break;

                case "2":
                    Console.WriteLine("Has Seleccionado la opcion 2.");
                    // Logica para la Opcion 2
                    break;

                case "3":
                    Console.WriteLine("Has Seleccionado la opcion 3.");
                    // Logica para la Opcion 3
                    break;

                case "4":
                    Console.WriteLine("Has Seleccionado la opcion 4.");
                    // Logica para la Opcion 4
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();

            }


        }
    }
}
