//------------------------------------------------------------------------------
/*
 * Instead, you should be concerned about expressing your algorithms in a manner that makes it easiest for the tools in the environment to do the best job they can. 
 * Luckily, those rules are consistent with the rules you already follow for good software-development practices. One more time: smaller and simpler functions.
 *  It’s not just smallness: Simpler control flow matters just as much. Fewer control branches inside functions make it easier for the JIT compiler to enregister variables. 
 * It’s not just good practice to write clearer code; it’s how you create more efficient code at runtime.*/
//------------------------------------------------------------------------------
using System;
using System.Text;


namespace EffectiveC
{
	public class UnderstandtheAttractionofSmallFunctions
	{
		public string BuildMsg(bool takeFirstPath)
		{
		    StringBuilder msg = new StringBuilder();
		    if (takeFirstPath)
		    {
		        msg.Append("A problem occurred.");
		        msg.Append("\nThis is a problem.");
		        msg.Append("imagine much more text");
		    }
		    else
		    {
		        msg.Append("This path is not so bad.");
		        msg.Append("\nIt is only a minor inconvenience.");
		        msg.Append("Add more detailed diagnostics here.");
		    }
		    return msg.ToString();
		}

		public string BuildMsg2(bool takeFirstPath)
		{
			if (takeFirstPath)
			{
				return FirstPath();
			}
			else
			{
				return SecondPath();
			}
		}
		private string FirstPath(){return "first";}
		private string SecondPath(){return "second";}
	}


}

