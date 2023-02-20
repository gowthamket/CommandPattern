using System.Collections.Generic;

public class LightApp
{
    Stack<ICommand> _commandList;

    public LightApp() {
        _commandList = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand) {
        newCommand.Execute();
        _commandList.Push(newCommand);
    }

    public void UndoCommand() {
        if (_commandList.Count > 0) {
            ICommand latestCommand = _commandList.Pop();
            latestCommand.Undo();
        }
    }
}


























