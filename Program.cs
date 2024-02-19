//1. CALCULA EL MAYOR DE TRES NUMEROS

using System;
class Program
{
    static void Main(string[] arg)
    {
        Console.WriteLine("**1.CALCULA EL MAYOR DE TRES NÚMEROS**");
        Console.WriteLine("--------------------------");

        // Declaración de variables
        int num1, num2, num3;
        int mayor;

        // Solicitud de los números al usuario
        Console.WriteLine("Introduzca el primer número:");
#pragma warning disable CS8604 
        num1 = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 
        Console.WriteLine("Introduzca el segundo número:");
#pragma warning disable CS8604 
        num2 = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 
        Console.WriteLine("Introduzca el tercer número:");
#pragma warning disable CS8604 
        num3 = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 

        // Encontrar el mayor
        mayor = num1;
        if (num2 > mayor)
        {
            mayor = num2;
        }
        if (num3 > mayor)
        {
            mayor = num3;
        }

        // Mostrar el mayor
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("El mayor de los tres números es: " + mayor);
        Console.ResetColor();
    }
}
