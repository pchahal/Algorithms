//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace Patterns
{
	public class Singleton_
	{
		private static Singleton_ instance;
		private Singleton_ (){}

		public  static Singleton_ GetInstance()
		{
			if (instance==null)
				instance=new Singleton_();
			return instance;
		}
	}


	//Thread safe not quite lazy
	public sealed class Singleton
	{
		private static readonly Singleton instance = new Singleton();
		
		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static Singleton()
		{
		}
		
		private Singleton()
		{
		}
		
		public static Singleton Instance
		{
			get
			{
				return instance;
			}
		}
	}

}

