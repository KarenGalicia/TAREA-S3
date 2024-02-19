//1. CALCULA EL MAYOR DE TRES NUMEROS

class Program
{
    static void Main(string[] arg)
    {
        Console.WriteLine("**1.CALCULA EL MAYOR DE TRES NÚMEROS**");
        Console.WriteLine("--------------------------");

        int num1, num2, num3;
        int mayor;

        Console.WriteLine("Introduzca el primer número:");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número:");

        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el tercer número:");

        num3 = Convert.ToInt32(Console.ReadLine());


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
//2. INGRESO AL CLUB
        Console.WriteLine("**2.INGRESO AL CLUB DE AMIGOS**");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Introduzca su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        // Validar la edad
        if (edad >= 18)
        {
      
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("** ¡AL CLUB DE AMIGOS, DISFRUTA DE NUESTROS EVENTOS!**");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**ACCESO DENEGADO AL CLUB DE AMIGOS,DISFRUTA TU NIÑEZ. REGRESA CUANTO TENGAS 18 AÑOS COMO MÍNIMO**");
            Console.ResetColor();
        }
    }
}
