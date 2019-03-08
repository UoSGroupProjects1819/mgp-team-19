using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject door;
    public string player;
    public float doorSpeed = 5;
    public float DoorMovement = 0;
    public float maxDoorMovement = 0;

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == player)
        {
            if (DoorMovement <= (maxDoorMovement))
            {
                door.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
                DoorMovement += 1;
            }
            
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
