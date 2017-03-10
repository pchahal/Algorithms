//------------------------------------------------------------------------------
/*sphere is 0, which is not a valid value. Any code that relies on the (normal)
	fact that enums are restricted to the defined set of enumerated values
		won’t work. When you create your own values for an enum, make sure that
			0 is one of them. If you use bit patterns in your enum, define 0 to be the
				absence of all the other properties.
				*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public enum Planet
	{

		// Default starts at 0 otherwise.
		Mercury = 1,
		Venus = 2,
		Earth = 3,
		Mars = 4,
		Jupiter = 5,
		Saturn = 6,
		Neptune = 7,
		Uranus = 8
		// First edition included Pluto.
	}

	Planet sphere = new Planet();
	//As it stands now, you force all users to explicitly initialize the value:
	Planet sphere2 = Planet.Mars;



	//Another common initialization problem involves value types that contain references. Strings are a common example:
	public struct LogMessage
	{
		private int ErrLevel;
		private string msg;
	}
	LogMessage MyMessage = new LogMessage();
	//MyMessage contains a null reference in its msg field. There is no way to 	force a different initialization

	//Add logic to that property to return the empty string instead of null:
	public struct LogMessage2
	{
		private int ErrLevel;
		private string msg;
		public string Message
		{
			get
			{
				return (msg != null) ?
					msg : string.Empty;
			}
			set
			{
				msg = value;
			}
		}
	}

}

