using System;
class promedio{
	static void Main(){
		Console.Write("Input how many numbers you want to input: ");
		int max = int.Parse(Console.ReadLine());
		int i;
		int total = 0;
		for(i=0; i < max; i++){
			Console.Write("Input a number [{0} remainding]: ", max-i);
			total += int.Parse(Console.ReadLine());
		}
		Console.WriteLine("The total is {0}",total);
		Console.Write("The average is {0}.", (float)total/(float)max);
	}
}