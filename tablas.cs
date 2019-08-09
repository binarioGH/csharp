using System;
class Tablas{
	static void Main(){
		Console.Write("Ingresa un numero: ");
		int n = int.Parse(Console.ReadLine());
		int i;
		for(i=1;i<=10;i++){
			if(i != 10){
				Console.Write(i*n +", ");
			}
			else{
				Console.Write(i*n);
			}
		}
	}
}