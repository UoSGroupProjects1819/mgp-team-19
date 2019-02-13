using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPlatform : MonoBehaviour
{
    public Material default_Material;
    public Material New_Material;

    public string MyPart;
    public PlatformPartPicker parent;
    private void Start()
    {
        
        this.gameObject.GetComponent<Renderer>().material = default_Material;
    }
    private void OnMouseOver()
    {
        this.gameObject.GetComponent<Renderer>().material = New_Material;

        switch(MyPart)
        {
            case "Area1":
                parent.Area1 = true;
                return;
            case "Area2":
                parent.Area2 = true;
                return;
            case "Area3":
                parent.Area3 = true;
                return;
            case "Area4":
                parent.Area4 = true;
                return;
            case "Area5":
                parent.Area5 = true;
                return;
            case "Area6":
                parent.Area6 = true;
                return;
        }
    }

    private void OnMouseExit()
    {
        parent.Area1 = false;
        parent.Area2 = false;
        parent.Area3 = false;
        parent.Area4 = false;
        parent.Area5 = false;
        parent.Area6 = false;

        this.gameObject.GetComponent<Renderer>().material = default_Material;
    }
}
