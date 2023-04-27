using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBase : MonoBehaviour
{
    // Protected
    protected Color defaultColor = Color.black;

    // Public
    public virtual void DebugMessage() => Debug.Log("I'm a Shape");
    public void SetColor(Color newColor) => gameObject.GetComponent<MeshRenderer>().material.color = newColor;

}
