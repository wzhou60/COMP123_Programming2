namespace FirstProject;

class Program
{
    static void Main(string[] args)
    {
		int number = 5;
        Console.WriteLine("Hello, World! fro first project");
		
		
		MyMethod(number);
		Console.WriteLine($"Back in main and the number is {number}");
    }
	
	private static void MyMethod(double number){
	
number = 999;
Console.WriteLine("$"number = {number}");	
		
	}
	
	private static void MyMethod(int number){
	
number = 888;
Console.WriteLine("$"number = {number}");	
		
	}
	
}
