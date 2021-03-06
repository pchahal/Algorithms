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
	public interface State
	{
		 String gotApplication();
		 String checkApplication();
		 String rentApartment();
		 String dispenseKeys();
	}
	public interface AutomatInterface 
	{
		 void gotApplication();
		 void checkApplication();
		 void rentApartment();
		 void setState(State s);
		 State getWaitingState();
		 State getGotApplicationState();
		 State getApartmentRentedState();
		 State getFullyRentedState();
		 int getCount();
		 void setCount(int n);
	}

	public class Automat : AutomatInterface
	{
		State waitingState;
		State gotApplicationState;
		State apartmentRentedState;
		State fullyRentedState;
		State state;
		int count;
		
		public Automat(int n)
		{
			count = n;
			waitingState = new WaitingState(this);
			gotApplicationState = new GotApplicationState(this);
			apartmentRentedState = new ApartmentRentedState(this);
			waitingState = new WaitingState(this);
			state = waitingState;
		}
		
		public void gotApplication(){Console.WriteLine(state.gotApplication());}
		
		public void checkApplication(){Console.WriteLine(state.checkApplication());}
		
		public void rentApartment(){Console.WriteLine(state.rentApartment());Console.WriteLine(state.dispenseKeys());}
		
		public State getWaitingState(){return waitingState;}
		
		public State getGotApplicationState(){return gotApplicationState;}
		
		public State getApartmentRentedState(){return apartmentRentedState;}
		
		public State getFullyRentedState(){return fullyRentedState;}
		
		public int getCount(){return count;}
		
		public void setCount(int n){count = n;}
		
		public void setState(State s){state = s;}
	}

	public class WaitingState : State
	{
		AutomatInterface automat;		
		public WaitingState(AutomatInterface a){automat = a;}		
		public String gotApplication()
		{
			automat.setState(automat.getGotApplicationState());
			return "Thanks for the application.";
		}		
		public String checkApplication()
		{
			return "You have to submit an application.";
		}		
		public String rentApartment()
		{
			return "You have to submit an application.";
		}		
		public String dispenseKeys()
		{
			return "You have to submit an application.";
		}
	}

	
	public class GotApplicationState : State
	{
		AutomatInterface automat;
				
		public GotApplicationState(AutomatInterface a)
		{
			automat = a;

		}
		
		public String gotApplication()
		{
			return "We already got your application.";
		}
		
		public String checkApplication()
		{
			int yesno = 22;
			
			if (yesno > 4 && automat.getCount() > 0) {
				automat.setState(automat.getApartmentRentedState());
				return "Congratulations, you were approved.";
			} else {
				automat.setState(automat.getWaitingState());
				return "Sorry, you were not approved.";
			}
		}
		
		public String rentApartment()
		{
			return "You must have your application checked.";
		}
		
		public String dispenseKeys()
		{
			return "You must have your application checked.";
		}
	}

	public class ApartmentRentedState : State
	{
		AutomatInterface automat;
		
		public ApartmentRentedState(AutomatInterface a)
		{
			automat = a;
		}
		
		public String gotApplication()
		{
			return "Hang on, we're renting you an apartment.";
		}
		
		public String checkApplication()
		{
			return "Hang on, we're renting you an apartment.";
		}
		
		public String rentApartment()
		{
			automat.setCount(automat.getCount() - 1);
			return "Renting you an apartment....";
		}
		
		public String dispenseKeys()
		{
			if(automat.getCount() <= 0){  
				automat.setState(automat.getFullyRentedState());
			} else {
				automat.setState(automat.getWaitingState());
			}
			return "Here are your keys!";
		}
	}

	public class FullyRentedState : State
	{
		AutomatInterface automat;
		
		public FullyRentedState(AutomatInterface a)
		{
			automat = a;
		}
		
		public String gotApplication()
		{
			return "Sorry, we're fully rented.";
		}
		
		public String checkApplication()
		{
			return "Sorry, we're fully rented.";
		}
		
		public String rentApartment()
		{
			return "Sorry, we're fully rented.";
		}
		
		public String dispenseKeys()
		{
			return "Sorry, we're fully rented.";
		}
	}


}

