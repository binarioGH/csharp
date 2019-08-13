using System;
class multiplos{
	static void Main(){
		Console.Write("Input a number: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Input the top: ");
		int max = int.Parse(Console.ReadLine());
		int i;
		for(i=0; i<=max; i++){
			if(i%n == 0){
				Console.WriteLine("{0} is multiple of {1}",i,n);
			}
		}
	}
}