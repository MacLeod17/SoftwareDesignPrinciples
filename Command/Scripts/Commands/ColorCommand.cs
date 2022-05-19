using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCommand : Command
{
    protected Color originalColor;
    protected Color newColor;

    public ColorCommand(Color rgb, GameObject obj) : base(obj)
    {
        newColor = rgb;

        originalColor = obj.GetComponent<SpriteRenderer>().color;
    }

    public override void Do()
    {
        obj.GetComponent<SpriteRenderer>().color = newColor;
    }

    public override void Undo()
    {
        obj.GetComponent<SpriteRenderer>().color = originalColor;
    }
}
