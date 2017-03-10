//------------------------------------------------------------------------------
/*The Conditional attribute tells the C# compiler that this method should be called only
	when the compiler detects the DEBUG environment variable. The Conditional attribute
		does not affect the code generated for the CheckState() function; it modifies 
	the calls to the function. If the DEBUG symbol is defined, you get this:
	*/
//------------------------------------------------------------------------------
using System;
using System.Diagnostics;
namespace EffectiveC
{
	public class UseConditionalAttributesInsteadofIfDef
	{
		string lastName;
		[Conditional("DEBUG")]
		private void CheckState()
		{
			// same code as above
		}


		//The Conditional attribute tells the C# compiler that this method should be called only when the compiler detects the DEBUG environment variable. 
		//The Conditional attribute does not affect the code generated for the CheckState() function; it modifies the calls to the function. 
		//If the DEBUG symbol is defined, you get this:
			
			public string LastName
			{
			get
			{
				CheckState();
				return lastName;
			}
			set
			{
				CheckState();
				lastName = value;
				CheckState();
			}
		}

		//If not, you get this:		
			public string LastName2
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}



		//You can also create methods that depend on more than one environment variable.
		//When you apply multiple conditional attributes, they are combined with OR.
		//For example, this version of CheckState would be called when either DEBUG or TRACE is true:
		//	[Conditional("DEBUG"),
		//	 Conditional("TRACE")]
		//	private void CheckState()
	}
}

