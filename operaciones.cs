using System;
namespace Operaciones{
	class Calculadora{
		static public void Main(){
			Console.Write("Ingresa un numero: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Ingresa otro numero: ");
			int n2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Suma: {0}", n1+n2);
			Console.WriteLine("Resta: {0}", n1-n2);
			Console.WriteLine("Multipicación: {0}", n1*n2);
			Console.WriteLine("Division: {0}", n1/n2);
		}
	}
}