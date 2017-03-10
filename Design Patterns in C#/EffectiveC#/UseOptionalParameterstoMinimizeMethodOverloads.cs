//------------------------------------------------------------------------------
/*Now, after that explanation, the guidance should be clearer. For your initial release, use optional and named parameters to create whatever combination of overloads your users may want to use. 
	However, once you start creating future releases, you must create overloads for additional parameters. That way, existing client applications will still function. Furthermore, 
	in any future release, avoid changing parameter names. They are now part of your public interface.

Annotating the names of the parameters ensures that people reading this code later won’t wonder if the parameters are in the right order or not. 
Developers will use named parameters whenever adding the names will increase the clarity of the code someone is trying to read. 
Anytime you use methods that contain multiple parameters of the same type, 
naming the parameters at the callsite will make your code more readable.
	*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class UseOptionalParameterstoMinimizeMethodOverloads
	{
		private void SetName(string lastName, string firstName)
		{
			// elided
		}
		
		//Can be called using named parameters to avoid any confusion on the order:
		public void Tester()
		{
			SetName(lastName: "Wagner", firstName: "Bill");
		}
	}
}

