using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : Receiver
{
    public override void Do(Command cmd)
    {
        cmd.Do();
        commands.Add(cmd);
        redoCommands.Clear();
    }

    public override void Redo()
    {
        if (redoCommands.Count == 0) return;

        Command cmd = redoCommands[redoCommands.Count - 1];
        cmd.Do();
        redoCommands.Remove(cmd);
        commands.Add(cmd);
    }

    public override void Undo()
    {
        if (commands.Count == 0) return;

        Command cmd = commands[commands.Count - 1];
        cmd.Undo();
        commands.Remove(cmd);
        redoCommands.Add(cmd);
    }
}
