using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Receiver
{
    protected List<Command> commands = new List<Command>();
    protected List<Command> redoCommands = new List<Command>();

    public abstract void Do(Command cmd);
    public abstract void Redo();
    public abstract void Undo();
}
