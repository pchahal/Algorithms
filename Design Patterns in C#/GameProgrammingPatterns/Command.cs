using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
/*
namespace GameProgrammingPatterns
{
    public interface ICommand
    {
        void execute();
    }

    public class JumpCommand : ICommand
    {
        public void execute()
        {
            //go.Jump();
        }
    }
    public class FireCommand : ICommand
    {
        public void execute()
        {
            //go.fire();
        }
    }

    class InputHandler
    {
        void handleInput()
        {
            if (isPressed(BUTTONS.BUTTON_X)) buttonY.execute();
            else if (isPressed(BUTTONS.BUTTON_Y)) buttonY.execute();
            else if (isPressed(BUTTONS.BUTTON_A)) buttonA.execute();
            else if (isPressed(BUTTONS.BUTTON_B)) buttonB.execute();
        }
        bool isPressed(BUTTONS buttonType)
        {
            return true;
        }
        // Methods to bind commands...


        ICommand buttonX;
        ICommand buttonY;
        ICommand buttonA;
        ICommand buttonB;

    };

    public enum BUTTONS
    {
        BUTTON_X,
        BUTTON_Y,
        BUTTON_A,
        BUTTON_B
    };
}
*/


namespace GameProgrammingPatterns
{
public interface ICommand
{
    void execute(GameObject go);
}

public class JumpCommand : ICommand
{
    public void execute(GameObject go)
    {
        go.Jump();
    }
}
public class FireCommand : ICommand
{
    public void execute(GameObject go)
        {
        go.fire();
    }
}

public class InputHandler
{
    public ICommand handleInput()
    {
        if (isPressed(BUTTONS.BUTTON_X)) return buttonX;
        if (isPressed(BUTTONS.BUTTON_Y)) return buttonY;
        if (isPressed(BUTTONS.BUTTON_A)) return buttonA;
        if (isPressed(BUTTONS.BUTTON_B)) return buttonB;

        return null;
    }
    bool isPressed(BUTTONS buttonType)
    {
        return true;
    }
    // Methods to bind commands...


    ICommand buttonX=new FireCommand();
    ICommand buttonY=new JumpCommand();
    ICommand buttonA=new FireCommand();
    ICommand buttonB=new JumpCommand();

};

public enum BUTTONS
{
    BUTTON_X,
    BUTTON_Y,
    BUTTON_A,
    BUTTON_B
};
}

