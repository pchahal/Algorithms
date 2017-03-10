//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace Patterns
{



	public abstract class ConnectionFactory
	{
		public abstract Connection CreateConnection(string type);		
	}

	public class SecureFactory:ConnectionFactory
	{
		public override Connection CreateConnection(string type)
		{
			if (type==("Oracle")){
				return new SecureOracleConnection();
			}
			else if (type==("SQL Server")){
				return new SecureSqlServerConnection();
			}
			else {
				return new SecureSqlServerConnection();
			}
		}
	}
		
	public class SecureSqlServerConnection:Connection
	{
		public override string description()
		{
			return "SQL";
		}
	}

	public class SecureOracleConnection:Connection
	{
		public override string description()
		{
			return "Oracle";
		}
	}
}

