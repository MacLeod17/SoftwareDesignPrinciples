using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected GameObject obj;

    public Command(GameObject gameObj)
    {
        obj = gameObj;
    }

    public abstract void Do();
    public abstract void Undo();
}
