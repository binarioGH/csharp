using System;
class descuento{
	static void Main(){
		int total = 0;
		int compra;
		do{
			Console.Write("Ingresa cuanto costó tu compra: ");
			compra = int.Parse(Console.ReadLine());
			if(compra != -1){
				total += compra;
			}
		}while(compra != -1);
		double descuento = 0.15 * total;
		Console.WriteLine("Sin descuento: {0}", total);
		Console.WriteLine("Con descuento: {0}", total-descuento);
	}
}