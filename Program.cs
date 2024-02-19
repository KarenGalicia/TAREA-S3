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

#pragma warning disable CS8604 // Posible argumento de referencia nulo
		num1 = int.Parse(s:Console.ReadLine());

		Console.WriteLine("Introduzca el segundo número:");

		num2 = int.Parse(s:Console.ReadLine()) ;

		Console.WriteLine("Introduzca el tercer número:");

#pragma warning disable CA1305 
		num3 = int.Parse(s: Console.ReadLine());


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
