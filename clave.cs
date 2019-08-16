using System;

class claves{
	static void Main(){
		Console.Write("Input your new user: ");
		string nuser = Console.ReadLine();
		Console.Write("Input your new password: ");
		string npassword = Console.ReadLine();
		Console.WriteLine("Log in...");
		string user, password;
		int attemps = 0;
		do{
			Console.WriteLine("Attemps: {0}", 3-attemps);
			Console.Write("Input your user:  ");
			user = Console.ReadLine();
			Console.Write("Input your password: ");
			password = Console.ReadLine();
			if(user == nuser && password == npassword){
				break;
			}
			else{
				attemps += 1;
			}
		}while(attemps < 3);
		if(attemps != 3){
			Console.WriteLine("Logged correctly :)");
		}
		else{
			Console.WriteLine("Incorrect login");
		}
		
	}
}