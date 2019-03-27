using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public Material _default;
    public Material newMaterial;

    public float moveSpeedMultiplier = 8;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseOver()
    {
        GetComponent<Renderer>().material = newMaterial;

        if(Input.GetMouseButton(0))
        {
            rb.useGravity = false;

            this.gameObject.transform.Translate(Vector3.up * (Time.deltaTime * moveSpeedMultiplier));
        }
        if(Input.GetMouseButtonUp(0))
        {
            rb.useGravity = true;
        }
    }

    private void OnMouseExit()
    {
        rb.useGravity = true;
        GetComponent<Renderer>().material = _default;
    }
}
