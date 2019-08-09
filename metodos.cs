using System;
class Metodos{
	static void Main(){
		Console.Write("Quieres llamar a el metodo? ");
		string resp = Console.ReadLine();
		if(resp == "si" || resp == "sí"){
			MiMetodo();
		}
		else{
			Console.WriteLine("\n\nNo has llamado al metodo.");
		}
	}
	static void MiMetodo(){
		Console.WriteLine("\n\nLlamaste al metodo.");
	}
}