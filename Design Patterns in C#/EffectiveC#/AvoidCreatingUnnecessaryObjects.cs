//------------------------------------------------------------------------------
/*All reference types, even local variables,are allocated on the heap. Every local variable of a reference type becomes garbage as soon as that function exits.
 You can introduce serious performance drains on your program by creating an excessive number of reference objects that are local to your methods.
OnPaint() gets called frequently. Every time it gets called, you create
another Font object that contains the exact same settings. The Garbage
Collector needs to clean those up for you every time. That’s incredibly
inefficient.
Instead, promote the Font object from a local variable to a member variable.
Reuse the same font each time you paint the window:

The first time you request a black brush, the Brushes class creates it. The
Brushes class keeps a reference to the single black brush and returns that
same handle whenever you request it again. The end result is that you create
one black brush and reuse it forever.
*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	private static Brush blackBrush;
	public static Brush Black
	{
	get
		{
			if (blackBrush == null)
			blackBrush = new SolidBrush(Color.Black);
			return blackBrush;
		}
}
}

