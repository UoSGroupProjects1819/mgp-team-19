using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverColourchange : MonoBehaviour
{
    public Material mat_1;
    public Material mat_2;
    // Start is called before the first frame update
    private void OnMouseOver()
    {
        GetComponent<Renderer>().material = mat_2;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = mat_1;
    }
}
