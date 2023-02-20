using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Lightbulb _lightbulb;
    LightApp _lightApp;

    void Start() {
        // setup Invoker
        _lightApp = new LightApp();
    }

    // Update is called once per frame
    void Update()
    {
        // Add/Execute to invoker list and execute the command or Undo Command
        if (Input.GetKeyDown(KeyCode.Space)) {
            ICommand togglePowerCommand = new TogglePowerCommand(_lightbulb);
            _lightApp.AddCommand(togglePowerCommand);
        } else if (Input.GetKeyDown(KeyCode.C)) {
            ICommand changeColorCommand = new ChangeColorCommand(_lightbulb);
            _lightApp.AddCommand(changeColorCommand);
        } else if (Input.GetKeyDown(KeyCode.Z)) {
            _lightApp.UndoCommand();
        }
    }
}





















