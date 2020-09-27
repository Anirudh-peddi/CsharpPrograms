using System;

class Untitled
{
	static void Main(string[] args)
	{
		int a=10, b=0;
		try{
			
			//a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(a/b);
		}
		
		catch(DivideByZeroException e)
		{
			Console.WriteLine(e.Message);
		}
		catch(FormatException e)
		{
			Console.WriteLine(e.Message);
		}
		//Console.ReadLine();
	}
}