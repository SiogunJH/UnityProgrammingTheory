using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ShapeBase //INHERETANCE
{
    //POLYMORPHISM
    public override void DebugMessage() => Debug.Log("I'm a Cube");
    void Update()
    {
        defaultColor = Color.red;
    }
    void OnMouseDown()
    {
        SetColor(defaultColor);
        DebugMessage(); //ABSTRACTION
    }
}
