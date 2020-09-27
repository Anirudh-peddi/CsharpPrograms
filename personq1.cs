using System;

class Person
{
	private string firstName;
	private string lastName;
	private string emailAddress;
	private DateTime dob;}
	
	/*public Person (string firstName, string lastName,string emailAddress)
	{
		this.firstName =firstName;
		this.lastName =lastName;
		this.emailAddress =emailAddress;
	}
	*/
	
	public Person(string firstName, string lastName,string emailAddress, DateTime dob)
		{
			this.firstName =firstName;
			this.lastName =lastName;
			this.emailAddress =emailAddress;
			this.dob =dob;
		}

	
	public Person(string firstName, string lastName,DateTime dob)
		{
			this.firstName =firstName;
			this.lastName =lastName;
			this.dob =dob;
		}

	
	
	//public string DOB{get=> dob.ToString(); set=>dob = new DateTime(Convert.ToInt32(value.Substring(0,4)),Convert.ToInt32(value.Substring(4,2)),Convert.ToInt32(value.Substring(6,2)));}
	public DateTime DOB {get => dob; set=>dob=value;}
	public string EmailAddress{get=> emailAddress; set=>dob=value;}
	public string LastName{get=> lastName; set=>dob=value;}
	
	public bool Adult{
		get {
			if((DateTime.Today.Year - dob.Year)>=18)
			return true;
			else return false;
		}
	}
	
	
	public string SunSign
	{
		get{
			
			switch (dob.Month){
				case 1: if(dob.Day<=20)
				{
					return "Capricorn";
				}
				else return "aquarius";
				case 2: if(dob.Day <=18)
				{
					return "Aquarius";
				}
				else return "Pisces";
				default: return null;
			}
		}
		
		public bool BirthDay{
			get {
				if((dob.Month==DateTime.Today.Month)&&(dob.Day==DateTime.Day))
			}
					return true;
				{
				else return false;
				}
		
		
		public sting ScreenName
		{
			get {
				string ScreenName;
				ScreenName = firstName.Substring(0,4) + dob.Month.ToString();
				return ScreenName;
			}
		}
		
	
		


class Program{
static void Main(string[] args)
	{
		static fName,lName,email,dob;
		
		Console.WriteLine("Enter the first Name");
		fName = Consome.ReadLine();
		Console.WriteLine("Enter the last Name");
		lName = Consome.ReadLine();
		Console.WriteLine("Enter the email address");
		email = Consome.ReadLine();
		Console.WriteLine("Enter the dob in y/m/d order");
		dob = Consome.ReadLine();
		
		DateTime dT = new DateTime(Convert.ToInt32(dob.Substring(0,4)),Convert.ToInt32(dob.Substring(4,2)),Convert.ToInt32(dob.Substring(6,2)));
		
		Person p1 = new Person(fName,lName,email,dT);
		Console.WriteLine("The person is an adult?: " + p1.Adult);
		Console.WriteLine("The sunsign:" + p1.SunSign);
		Console.WriteLine("Today is BirthDay?: " + p1.BirthDay);
		Console.WriteLine("The allotted screen name:" + p1.ScreenName);
		Console.ReadLine();
		
		
		
	}
}
		