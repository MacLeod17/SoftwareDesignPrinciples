using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownCommand : Command
{
    protected Vector3 translation;

    public MoveDownCommand(float newY, GameObject obj) : base(obj)
    {
        translation.y = -Mathf.Abs(newY);
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
