//------------------------------------------------------------------------------
/*anytime
	you use types that have a Dispose() method, it’s your responsibility to
		release those resources by calling Dispose(). The best way to ensure that
		Dispose() always gets called is to utilize the using statement or a
		try/finally block.The using statement works only if the compile-time type supports the
		IDisposable interface. You cannot use it with arbitrary objects:
		Less than 100 classes in the .NET Framework implement
	IDisposable—that’s out of more than 1,500 types. When you use the ones
	that do implement IDisposable, remember to dispose of them in all cases.
	You should wrap those objects in using clauses or try/finally blocks.
	Whichever you use, make sure that objects get disposed properly all the
	time, every time.
		*/
//------------------------------------------------------------------------------
using System;
namespace EffectiveC
{
	public class UtilizeUsingandTryFinallyforResourceCleanup
	{
		//Suppose you wrote this code:

			public void ExecuteCommand(string connString,string commandString)
			{
				SqlConnection myConnection = new SqlConnection(
					connString);
				SqlCommand mySqlCommand = new SqlCommand(commandString,
				                                         myConnection);
				myConnection.Open();
				mySqlCommand.ExecuteNonQuery();
			}
		//Two disposable objects are not properly cleaned up in this example:
		//SqlConnection and SqlCommand. Both of these objects remain in memory
		//until their finalizers are called. (Both of these classes inherit their finalizer from System.ComponentModel.Component.)
		//You fix this problem by calling Dispose when you are finished with the command and the connection:
				
		//happen. The using statement ensures that Dispose() is called. You allocate an object inside a using
		//statement, and the C# compiler generates a try/finally block around  each object:

		public void ExecuteCommand(string connString,
		                           string commandString)
		{
			using (SqlConnection myConnection = newSqlConnection(connString))
			{
				using (SqlCommand mySqlCommand = new SqlCommand(commandString, myConnection))
				{
					myConnection.Open();
					mySqlCommand.ExecuteNonQuery();
				}
			}
		}
	}
}

