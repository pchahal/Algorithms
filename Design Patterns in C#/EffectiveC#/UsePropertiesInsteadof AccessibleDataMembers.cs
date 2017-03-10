//------------------------------------------------------------------------------
// Whenever you expose data in your type’s public or protected interfaces, use properties.
/*Use an indexer for sequences or dictionaries. All data members should be private, without 
	exception. You immediately get support for data binding, and you make it much 
		easier to make any changes to the implementation of the methods in the future. 
			The extra typing to encapsulate any variable in a property amounts to one
			or two minutes of your day. Finding that you need to use properties late
			r to correctly express your designs will take hours. Spend a little time now,
			and save yourself lots of time later.
*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveCSharp
{
	public class Customer
	{
		private object syncHandle = new object();
		
		private string name;
		public string Name
		{
			get
			{

					return name;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException(
						"Name cannot be blank",
						"Name");			
					name = value;
			}
		}
	}
}

