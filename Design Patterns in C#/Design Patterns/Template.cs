//------------------------------------------------------------------------------
//You use the Template Method design pattern when you’ve got an algorithm of
//	several steps and you want to allow customization by subclasses. It’s that
//		easy. Implement the steps in that algorithm as an overridable method calls in
//		an abstract class, and let the subclasses override those steps as required
//------------------------------------------------------------------------------
using System;
namespace Patterns
{
	public abstract class RobotTemplate
	{
		public void Go()
		{
			Start();
			GetParts();
			Assemble();
			Test();
			Stop();
		}
		public virtual void Start(){Console.WriteLine("Starting...");}
		public virtual void GetParts(){Console.WriteLine("Getting Parts...");}
		public virtual void Assemble(){Console.WriteLine("Assembling...");}
		public virtual void Test(){Console.WriteLine("Testing...");}
		public virtual void Stop(){Console.WriteLine("Stopping...");}
	}


	public class AutoMotiveRobot:RobotTemplate
	{
		private string name;
		public AutoMotiveRobot(string n)
		{
			name = n;
		}
		public override void GetParts(){Console.WriteLine("Getting a carburetor...");}
		public override void Assemble(){Console.WriteLine("Installing carburetor...");}
		public override void Test(){Console.WriteLine("Revving the engine...");}
		public string GetName(){return name;}
	}
	public class CookieRobot:RobotTemplate
	{
		private string name;
		public CookieRobot(string n)
		{
			name = n;
		}		
		public override void GetParts(){Console.WriteLine("Getting flour and sugar....");}
		public override void Assemble(){Console.WriteLine("InBaking a cookie...");}
		public override void Test(){Console.WriteLine("RCrunching a cookie...");}
		public string GetName(){return name;}
	}

}


