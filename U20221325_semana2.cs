
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


          

        string miNombre = "Cruz Gerardo";
        string nombrePadre = "Raudilio Amaya";
        string nombreMadre = "Santo Rivera";
        string nombreHermano = "Denis Gustavo";

      
        int miEdad = 30;
        int edadPadre = 58;
        int edadMadre = 53;

     
        float gastosAlimentacion = 300.50f;
        float gastosTransporte = 100.75f;
        float gastosEntretenimiento = 50.25f;

       
        bool soyEstudiante = true;
        bool esBecado = false;

        Console.WriteLine("Información Personal:");
        Console.WriteLine("Nombre: " + miNombre);
        Console.WriteLine("Edad: " + miEdad + " años");

        Console.WriteLine("\nInformación de la Familia:");
        Console.WriteLine("Padre: " + nombrePadre);
        Console.WriteLine("Edad del Padre: " + edadPadre + " años");
        Console.WriteLine("Madre: " + nombreMadre);
        Console.WriteLine("Edad de la Madre: " + edadMadre + " años");
        Console.WriteLine("Hermano: " + nombreHermano);

        Console.WriteLine("\nGastos Frecuentes:");
        Console.WriteLine("Alimentación: $" + gastosAlimentacion);
        Console.WriteLine("Transporte: $" + gastosTransporte);
        Console.WriteLine("Entretenimiento: $" + gastosEntretenimiento);

        Console.WriteLine("\nEstado en esta Materia:");
        Console.WriteLine("¿Es estudiante? " + soyEstudiante);
        Console.WriteLine("¿Es becado? " + esBecado);

        Console.ReadKey();
        //auto evaluacion 10

        }
        




    }
}