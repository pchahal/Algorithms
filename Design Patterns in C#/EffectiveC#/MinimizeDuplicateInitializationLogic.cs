//------------------------------------------------------------------------------
/*Constructor initializers allow one constructor to call another 
 * Writing constructors is often a repetitive task. Many developers write the first constructor and then copy and paste the code into other constructors, to satisfy the multiple overrides defined in 
 * the class interface. Hopefully, you’re not one of those. If you are, stop it. Veteran C++ programmers would factor the common algorithms into a private helper method. Stop that, too. 
 * When you find that multiple constructors contain the same logic, factor that logic into a common constructor instead. You’ll get the benefits of avoiding code duplication, 
 * and constructor initializers generate much more efficient object code. The C# compiler recognizes the constructor initializer as special syntax and removes the duplicated 
 * variable initializers and the duplicated base class constructor calls. The result is that your final object executes the minimum amount of code to properly initialize the object.
 * You also write the least code by delegating responsibilities to a common constructor.
 * */
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class MinimizeDuplicateInitializationLogic
	{
		public MinimizeDuplicateInitializationLogic ()
		{
		}
	}
}

