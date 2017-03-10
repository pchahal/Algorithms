//------------------------------------------------------------------------------
/*You know that you should initialize static member variables in a type before you create any instances of that type. C# lets you use static initializers and a static constructor for this purpose.
 * A static constructor is a special function that executes before any other methods, variables, or properties defined in that class are accessed for the first time. 
 * As with instance initialization, you can use the initializer syntax as an alternative to the static constructor. If you simply need to allocate a static member, use the initializer syntax. 
 * When you have more complicated logic to initialize static member variables, 
 * Static initializers and static constructors provide the cleanest, clearest way to initialize static members of your class. They are easy to read and easy to get correct.
 * They were added to the language to specifically address the difficulties involved with 
 * initializing static members in other languages.
 * 
 * create a static constructor.*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
//	Implementing the singleton pattern in C# is the most frequent use of a static constructor. Make your instance constructor private, and add an initializer:

public class MySingleton
{
    private static readonly MySingleton theOneAndOnly =
      new MySingleton();
    public static MySingleton TheOnly
    {
        get { return theOneAndOnly; }
    }

    private MySingleton()
    {
    }
    // remainder elided
}



	//The singleton pattern can just as easily be written this way, in case you have more complicated logic to initialize the singleton:
	
	public class MySingleton2
	{
		private static readonly MySingleton2 theOneAndOnly;
		
		static MySingleton2()
		{
			theOneAndOnly = new MySingleton2();
		}
		
		public static MySingleton2 TheOnly
		{
			get { return theOneAndOnly; }
		}
		
		private MySingleton2()
		{
		}
		
		// remainder elided
	}
}

