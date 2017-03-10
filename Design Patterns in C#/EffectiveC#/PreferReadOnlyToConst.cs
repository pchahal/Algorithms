//------------------------------------------------------------------------------
//C# has two different versions of constants: compile-time constants and runtime constants. 
/*They have very different behaviors, and using the wrong one will cost you performance or 
	correctness. Neither problem is a good one to have, but if you must pick one, a slower, 
	correct program is better than a faster, broken program. For that reason, you should 
		prefer runtime constants over compile-time constants. Compile-time constants are 
			slightly faster, but far less flexible, than runtime constants. Reserve the 
			compile-time constants for when performance is critical and the value of the
				constant will never change between releases.
				*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class PreferReadOnlyToConst
	{
		// Compile time constant:
		public const int Millennium = 2000;
		
		// Runtime constant:
		public static readonly int ThisYear = 2004;
	}
}

