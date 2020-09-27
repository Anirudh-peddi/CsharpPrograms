using System;

class Untitled
{
	static void Main(string[] args)
	{
		int yob; int mob; int dob;
		
		Console.WriteLine("Enter the year of your birth");
		yob = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the month of your birth");
		mob = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the day of your birth");
		dob = Convert.ToInt32(Console.ReadLine());
		
		int rCode = CheckTheBirthDate(yob,mob,dob);
		
		switch(rCode)
		{
			case 0: Console.WriteLine("Hey you are born today");
			break;
			case 1: Console.WriteLine("You have entered a future date...");break;
			case 2: Console.WriteLine("You are lucky to have lived >=135 Years");break;
			default: Console.WriteLine("Age of the user is: "+rCode);break;
		}
		
		Console.ReadLine();
	}
	
	private static int CheckTheBirthDate(int yob,int mob,int dob)
	{
		DateTime bDate = new DateTime(yob,mob,dob);
		DateTime tDate = DateTime.Today;
		int rValue = DateTime.Compare(bDate,tDate);
		if(rValue<0)
		{
			if((tDate.Year-bDate.Year)>=135)
			return 2;
			else return(tDate.Year - bDate.Year);
		}
		else if (rValue > 0) 
		{
			return 1;
		}
		else return 0;
	}
	
}