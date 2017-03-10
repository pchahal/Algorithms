//------------------------------------------------------------------------------
/*Value types are not polymorphic.	They are better suited to storing the data that your application manipulates.
reference types can be polymorphic and should be used to define the behavior of your application.Structs store data. Classes define behavior.
In C#, you declare whether a new type should be a value type or a reference type using the struct or class keywords. Value types should be small, lightweight types. Reference
types form your class hierarchy.

1. Is this type’s principal responsibility data storage?
2. Is its public interface defined entirely by properties that access its data
members?
3. Am I confident that this type will never have subclasses?
4. Am I confident that this type will never be treated polymorphically?
Build low-level data storage types as value types. Build the behavior of
your application using reference types. You get the safety of copying data
that gets exported from your class objects. You get the memory usage benefits
that come with stack-based and inline value storage, and you can utilize
standard object-oriented techniques to create the logic of your
application. When in doubt about the expected use, use a reference type.
	*/	
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	MyType[] arrayOfTypes = new MyType[100];
	//If MyType is a value type, one allocation of 100 times the size of a MyType
	//object occurs. However, if MyType is a reference type, one allocation just
	//occurred. Every element of the array is null. When you initialize each element
	//in the array, you will have performed 101 allocations—and 101 allocations
	//take more time than 1 allocation. Allocating a large number of
}

