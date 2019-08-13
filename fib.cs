using System;
class Fib{
	static void Main(){
		Console.Write("Input a number: ");
		int max = int.Parse(Console.ReadLine());
		int a = 0, b=1,c;
		int i;
		Console.Write("0, 1,");
		for(i=2;i<max;i++){
			c = a + b;
			a = b;
			b = c;
			Console.Write(" {0}",c);
			if(i != max - 1){
				Console.Write(",");
			}
		}

	}
}