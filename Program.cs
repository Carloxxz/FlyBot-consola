using System;

namespace FlyBot_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soy FlyBot tu bot personal\n" +
               "¿Cómo te llamas?");
            String NombreDeUsuario = Console.ReadLine();
            do
            {
                Console.WriteLine("Mucho gusto " + NombreDeUsuario + " ¿en qué puedo ayudarte?");

                Console.WriteLine("\n1.- Suma" +
                   "\n2.- Resta" +
                   "\n3.- Multiplicación" +
                   "\n4.- División" +
                   "\n5.- Salir del bot\n");
                string seleccion = (Console.ReadLine());

                switch (seleccion)
                {
                    case "1":
                        Console.WriteLine("Sumas");
                        float dato1s, dato2s;
                        Console.WriteLine("Ingrese un dato");
                        dato1s = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo dato");
                        dato2s = float.Parse(Console.ReadLine());
                        float suma = dato1s + dato2s;
                        Console.WriteLine("\nLa suma de tus datos es " + suma);
                        break;
                    case "2":
                        Console.WriteLine("Restas");
                        float dato1r, dato2r;
                        Console.WriteLine("Ingrese un dato");
                        dato1r = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo dato");
                        dato2r = float.Parse(Console.ReadLine());
                        float resta = dato1r - dato2r;
                        Console.WriteLine("\nLa resta de tus datos es " + resta);
                        break;
                    case "3":
                        Console.WriteLine("Multiplicaciónes");
                        float dato1m, dato2m;
                        Console.WriteLine("Ingrese un dato");
                        dato1m = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo dato");
                        dato2m = float.Parse(Console.ReadLine());
                        float multiplicacion = dato1m * dato2m;
                        Console.WriteLine("\nLa multiplicacion de tus datos es " + multiplicacion);
                        break;
                    case "4":
                        Console.WriteLine("Divisiones");
                        float dato1d, dato2d;
                        Console.WriteLine("Ingrese un dato");
                        dato1d = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo dato");
                        dato2d = float.Parse(Console.ReadLine());
                        float division = dato1d / dato2d;
                        Console.WriteLine("\nLa division de tus datos es " + division);
                        break;
                    case "5":
                        Environment.Exit(5);
                        break;
                    default:
                        Console.WriteLine("Seleccione una de las opciones");
                        break;
                }

            } while (true);
        }
    }
}
