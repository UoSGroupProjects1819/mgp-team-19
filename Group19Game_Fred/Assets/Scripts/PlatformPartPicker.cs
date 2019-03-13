using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPartPicker : MonoBehaviour
{
    public bool Area1;
    public bool Area2;
    public bool Area3;
    public bool Area4;
    public bool Area5;
    public bool Area6;

    public float move_multiplier = 2f;
    public void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //A1 = Y+, A2 = Y-, A3 = X+ , A4 = X- , A5 = Z+, A6 = Z-
            if (Area1)
            {
                this.gameObject.transform.Translate(Vector3.up * (Time.deltaTime * move_multiplier));
            }
            if (Area2)
            {
                this.gameObject.transform.Translate(Vector3.down * (Time.deltaTime * move_multiplier));
            }
            if (Area3)
            {
                this.gameObject.transform.Translate(Vector3.forward * (Time.deltaTime * move_multiplier));
            }
            if (Area4)
            {
                this.gameObject.transform.Translate(Vector3.back * (Time.deltaTime * move_multiplier));
            }
            if (Area5)
            {
                this.gameObject.transform.Translate(Vector3.left * (Time.deltaTime * move_multiplier));
            }
            if (Area6)
            {
                this.gameObject.transform.Translate(Vector3.right * (Time.deltaTime * move_multiplier));
            }
        }
    }
}
