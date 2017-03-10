//------------------------------------------------------------------------------
/*If you want to convert another type into your type, use a constructor. This more clearly reflects the action of creating a new object. Conversion operators can introduce hard-to-find problems in your code
 * 
 */
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class Shape
	{
		public virtual void Draw(){}
	}

	public class Circle : Shape
	{
		private float center;
		private float radius;
		
		public Circle() :
			this(0, 0)
		{
		}
		
		public Circle(float c, float r)
		{
			center = c;
			radius = r;
		}
		
		public override void Draw()
		{
			//...
		}
		
		static public implicit operator Ellipse(Circle c)
		{
			return new Ellipse();
		}
	}

	public class Ellipse{}

}

