using System;
using System.Collections.Generic;

class Shape
{
	public virtual void Draw()
	{
		Console.WriteLine("base class draw method");
	}


class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Drawing a circle");
		//base.Draw();
	}

	
}

class Triangle : Shape
{
	public override void Draw()
		{
			Console.WriteLine("Drawing a triangle");
			//base.Draw();
		}

}

class Square : Shape
{
	public override void Draw()
		{
			Console.WriteLine("Drawing a square");
			//base.Draw();
		}

}

class program{
	public static void Main(string[] args)
	{
		Shape s=null; int ui;
		do{
		Console.WriteLine("Choose the shape");
		Console.WriteLine("1: Circle");
		Console.WriteLine("2: Triangel");
		Console.WriteLine("3: Square");
		Console.WriteLine("4: Exit");
		Console.WriteLine("Enter your input");
		 ui = Convert.ToInt32(Console.ReadLine());
		
		switch(ui)
		{
			case 1: s= new Circle();
			break;
			case 2: s= new Triangle();
			break;
			case 3: s= new Square();
			break;
			case 4: return;
			default: Console.WriteLine("Invalid option");
			Environment.Exit(0);
			break;
		}
		s.Draw();
		}
		while(ui>=1 && ui<= 4);
		
		/*var drawObjects = new List<Shape>
		{
			new Circle(),
			new Triangle(),
			new Square()
		};
		foreach (Shape s in drawObjects)
		{
			s.Draw();
		}
		Console.ReadLine();*/
	}
}
}