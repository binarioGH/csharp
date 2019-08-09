using System;
class ParImpar{
	static void Main(){
		int i;
		for(i=1; i <= 100; i++){
			if(esPar(i)){
				Console.WriteLine(i + " es par.");
			}
			else{
				Console.WriteLine(i + " es impar.");
			}
		}
	}
	static bool esPar(int n){
		if(n%2 == 0){
			return true;
		}
		return false;
	}
}