//------------------------------------------------------------------------------
/*When you create your own types (either classes or structs), you define what equality means for that type. C# provides four different functions that determine whether two different objects are “equal”:
	
	public static bool ReferenceEquals		(object left, object right);
	public static bool Equals				(object left, object right);
	public virtual bool Equals				(object right);
	public static bool operator ==			(MyClass left, MyClass right);

You should never redefine the first two static functions. You’ll often create your own instance Equals() method to define the semantics of your type, 
and you’ll occasionally override operator==(), typically for performance reasons in value types.
Two variables of a reference type are equal if they refer to the same object, referred to as object identity. Two variables of a value type are equal if they are the same type and they contain the same contents. 
Always create an override of ValueType.Equals() whenever you create a value type.

You should override the instance Equals() function only when you want to change the defined semantics for a reference type. A number of classes in the .NET Framework Class Library use value semantics
instead of reference semantics for equality. Two string objects are equal if they contain the same contents. Two DataRowView objects are equal if they refer to the same DataRow. The point is 
that if your type should follow value semantics (comparing contents) instead of reference semantics (comparing object identity), you should write your own override of instance Object.Equals().

Now that you know when to write your own override of Object.Equals(), you must understand how you should implement it. The equality relationship for value types has many implications for boxing 
and is discussed in Item 45. For reference types, your instance method needs to follow predefined behavior to avoid strange surprises for users of your class. Whenever you override Equals(), 
you’ll want to implement IEquatable<T> for that type.
You always override instance Equals() and operator==() for value types to provide better performance. You override instance Equals() for reference types when 
you want equality to mean something other than object identity. 
nytime you override Equals() you implement IEquatable<T>.
*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class Foo : IEquatable<Foo>
	{
		public override bool Equals(object right)
		{
			// check null:
			// this pointer is never null in C# methods.
			if (object.ReferenceEquals(right, null))
				return false;
			
			if (object.ReferenceEquals(this, right))
				return true;
			// Discussed below.
			
			if (this.GetType() != right.GetType())
				return false;
			
			// Compare this type's contents here:
			return this.Equals(right as Foo);
		}
		
		#region IEquatable<Foo> Members
		public bool Equals(Foo other)
		{
			// elided.
			return true;
		}
		#endregion
	}
}

