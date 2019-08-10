using System;
class Metodos{
	static public void Main(){
		Console.Write("Input a number: ");
		int n1 = int.Parse(Console.ReadLine());
		Console.Write("Input another number: ");
		int n2 = int.Parse(Console.ReadLine());
		int sum = suma(n1, n2);
		Console.Write("The sum of {0} and {1} is {2}",n1,n2,sum);

	}
	static int suma(int n1, int n2){
		return n1 + n2;
	}
}