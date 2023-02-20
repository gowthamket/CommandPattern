// CONCRETE COMMAND
using UnityEngine;

public class ChangeColorCommand : ICommand
{
    // stored lightbulb receiver
    Lightbulb _lightbulb;

    //stored previous color
    Color _previousColor;

    // constructor to set lightbulb
    public ChangeColorCommand(Lightbulb lightbulb) {
        _lightbulb = lightbulb;
        _previousColor = lightbulb.GetComponent<Renderer>().material.color;
    }
    
    // execute the stored logic
    public void Execute() {
        _lightbulb.SetRandomLightColor();
    }

    public void Undo() {
        _lightbulb.SetLightColor(_previousColor);
    }
}


















