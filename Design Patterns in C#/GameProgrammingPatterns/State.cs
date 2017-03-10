using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace GameProgrammingPatterns
{
    

    public interface HeroineState
    {
         void HandleInput(Heroine heroine, int input);
         void update(Heroine heroine);
    }

   

    public class Heroine
    {
        public void setGraphics(object imageStand)
        {   
        }

        public void superBomb()
        {
        }

         void handleInput(int input)
        {

            state.HandleInput(this, 1);
            

        }

         void update()
        {
            state.update(this);
        }

        public HeroineState state;
      
        static DuckingState ducking;
        static StandingState standing;
       
      
    }

    public class StandingState : HeroineState
    {
        public void HandleInput(Heroine heroine, int input)
        {
            throw new NotImplementedException();
        }

        public void update(Heroine heroine)
        {
            throw new NotImplementedException();
        }
    }

    public class DuckingState : HeroineState
    {

        public DuckingState(int chargeTime)
        {
            chargeTime_ = chargeTime;
        }

        private int chargeTime_;
        private int MAX_CHARGE=100;

        public void HandleInput(Heroine heroine, int input)
        {
            int RELEASE_DOWN = 1;
            if (input == RELEASE_DOWN)
            {
                // Change to standing state...
                object IMAGE_STAND = null;
                heroine.setGraphics(IMAGE_STAND);
               // heroine.state = HeroineState.ducking;
            }
        }

        public void update(Heroine heroine)
        {
            chargeTime_++;
          
            if (chargeTime_ > MAX_CHARGE)
            {
                heroine.superBomb();
            }
        }

        
    };
}
