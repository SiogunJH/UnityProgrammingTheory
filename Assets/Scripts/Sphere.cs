using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ShapeBase //INHERETANCE
{
    //POLYMORPHISM
    public override void DebugMessage() => Debug.Log("I'm a Sphere");

    void OnMouseEnter()
    {
        SetColor(Color.cyan);
        DebugMessage(); //ABSTRACTION
    }
    void OnMouseExit()
    {
        SetColor(Color.green);
    }
}
