//------------------------------------------------------------------------------
// The correct choice is to use the as operator whenever you can because it is safer than 
/*blindly casting and is more efficient at runtime. The as and is operators do not 
	perform any user-defined conversions. They succeed only if the runtime type 
		matches the sought type; they never construct a new object to satisfy a request.
The biggest difference between the as operator and the cast operator is how user-defined conversions are treated. The as and is operators examine the runtime type of the object being converted; they do not perform any other operations. If a particular object is not the requested type or is derived from the requested type, they fail. Casts, on the other hand, can use conversion operators to convert an object to the requested type. This includes any built-in numeric conversions. Casting a long to a short can lose information.

 */
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class PreferIsorAsOperatorsToCasts
	{
		public void MethodUsingIsorAs ()
		{
			object o = Factory.GetObject();
			
			// Version one:
			MyType t = o as MyType;
			
			if (t != null)
			{
				// work with t, it's a MyType.
			}
			else
			{
				// report the failure.
			}

		}

		public void MethodUsingCasts()
		{
			object o = Factory.GetObject();
			
			// Version two:
			try
			{
				MyType t;
				t = (MyType)o; // Fails. o is not MyType
				if (t != null)
				{
					// work with T, it's a MyType.
				}
			}
			catch (InvalidCastException)
			{
				// report the conversion failure.
			}
		}
		
	}

	public class MyType{}
	public class Factory{
		public static Object GetObject()
		{
			return new object();
		}
	}
}

