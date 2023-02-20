using System.Collections.Generic;

// INVOKER
public class Lightswitch
{
    // stores the TurnOnCommand
    ICommand _onCommand;

    // constructor that expects the TurnOnCommand
    public Lightswitch(ICommand onCommand) {
        _onCommand = onCommand;
    }

    // method that executes the TogglePowerCommand
    public void TogglePower() {
        _onCommand.Execute();
    }
}














