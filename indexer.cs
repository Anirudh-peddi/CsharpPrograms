using System;

class Student<T>
{
	private T[] marks = new T[5];
	
	public T this[int index]{
		
		get{
			return marks[index];
		}
		set{
			marks[index]=value;
		}
	}
}
class program
{
	static void Main(string[] args)
	{
		var s1 = new Student<doublew>();
		s1[0] = 90.5;
		var s2 = new Student<int>();
		s2[0] = 70;
		Console.WriteLine(s2[0]);
		Console.WriteLine(s1[0]);
	}
}