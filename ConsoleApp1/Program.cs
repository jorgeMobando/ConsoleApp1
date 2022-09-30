using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

			int count;

			Console.WriteLine("Ingrese un texto");
			string cadenaDeCaracteres = Console.ReadLine();
			//cadenaDeCaracteres = cadenaDeCaracteres.Replace(" ", String.Empty);
			count = cadenaDeCaracteres.Length;

			if (count > 20)
			{
				Console.WriteLine("Los 20 primeros caracteres son: " + cadenaDeCaracteres.Substring(0, 20) + "...");
			}
			else
			{
				Console.WriteLine($"Los {count} primeros caracteres son: " + cadenaDeCaracteres);
			}

			Console.ReadKey();
		}
	}
    
}
