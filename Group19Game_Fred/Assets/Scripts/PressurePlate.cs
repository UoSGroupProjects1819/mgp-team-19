using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject door;
    public GameObject player;
    public float doorSpeed = 5;

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            door.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
        }
    }
    /*
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            door.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
        }
    }
    */
}
