using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : Command
{
    protected Vector3 translation;

    public MoveRightCommand(float newX, GameObject obj) : base(obj)
    {
        translation.x = Mathf.Abs(newX);
    }

    public override void Do()
    {
        obj.transform.Translate(translation);
    }

    public override void Undo()
    {
        obj.transform.Translate(-translation);
    }
}
