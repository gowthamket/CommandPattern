// CONCRETE COMMAND
public class TogglePowerCommand : ICommand
{
    // stored lightbulb receiver
    Lightbulb _lightbulb;

    // constructor to store lightbulb reference
    public TogglePowerCommand(Lightbulb lightbulb) {
        _lightbulb = lightbulb;
    }

    // execute the stored logic
    public void Execute() { 
        _lightbulb.TogglePower();
    }

    public void Undo() {
        _lightbulb.TogglePower();
    }
}















