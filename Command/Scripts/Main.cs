using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    GameObject obj;
    Receiver receiver;

    // Start is called before the first frame update
    // Start is basically private static void main, before the gameplay loop starts
    void Start()
    {
        receiver = new User();
        obj = GameObject.Find("Square");
    }

    // Update is called once per frame
    // Update is basically private static void main, the code that would go within the gameplay loop
    void Update()
    {
        // Movement Commands
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Move Up
            receiver.Do(new MoveUpCommand(1, obj));
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Move Down
            receiver.Do(new MoveDownCommand(1, obj));
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Move Left
            receiver.Do(new MoveLeftCommand(1, obj));
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Move Right
            receiver.Do(new MoveRightCommand(1, obj));
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // Change Color
            float r = Random.Range(0f, 1);
            float g = Random.Range(0f, 1);
            float b = Random.Range(0f, 1);

            Color color = new Color(r, g, b, 1f);

            receiver.Do(new ColorCommand(color, obj));
        }

        // Undo/Redo
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            // Undo
            if (Input.GetKeyDown(KeyCode.U))
            {
                receiver.Undo();
            }

            // Redo
            else if (Input.GetKeyDown(KeyCode.R))
            {
                receiver.Redo();
            }
        }
    }
}
