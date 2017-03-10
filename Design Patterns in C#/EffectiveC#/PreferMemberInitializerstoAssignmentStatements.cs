//------------------------------------------------------------------------------
/*Classes often have more than one constructor. Over time, it’s easy for the member variables and the constructors to get out of sync. The best way to make sure this doesn’t happen is to initialize
	variables where you declare them instead of in the body of every constructor. You should utilize the initializer syntax for both static and instance variables.

*/
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;


namespace EffectiveC
{
	public class PreferMemberInitializerstoAssignmentStatements
	{
		// declare the collection, and initialize it.
		private List<string> labels = new List<string>();


		//The C# compiler dutifully adds the extra instructions to set memory to 0 again. It’s not wrong—it’s just inefficient. In fact, when value types are involved, it’s very inefficient.			
		//MyValType myVal1;  // initialized to 0
		//MyValType myVal2 = new MyValType(); // also 0
	}
}

