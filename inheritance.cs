using System;

class DataBase1
{
	
}
class DataBase 
{
	public int CommonField =10;
	
	public DataBase()
	{
		
	}
	public DataBase(int test)
	{
		
	}
	public void CommonMethod()
	{
		Console.WriteLine("inside the base class common");
	}
	/*public override string ToString()
	{
		return "overriding tostring";
	}*/
}
class SqlDatabase : DataBase
{
	public void SpecificMethodSql()
	{
		Console.WriteLine("sql specific method");
	}
}

class OracleDatabase : DataBase
{
	public void SpecificMethodOracle()
	{
		Console.WriteLine("Oracle specific method");
	}
}
class TestInheritance
{
	public static void Main()
	{
		OracleDatabase odata = new OracleDatabase();
		Console.WriteLine("common field:" + odata.CommonField);
		odata.CommonMethod();
		odata.SpecificMethodOracle();
		Console.WriteLine(odata);
		Console.ReadKey();
	}
}