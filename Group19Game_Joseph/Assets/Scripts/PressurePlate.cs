using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject door;
    public GameObject door2;
    public string player;
    public string player2;
    public float doorSpeed = 5;
    public float DoorMovement = 0;
    public float maxDoorMovement = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == player || other.gameObject.tag == player2)
        {
            if (DoorMovement <= (maxDoorMovement))
            {
                door.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
                door2.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
                DoorMovement += 1;
            }
            
        }
    }
}
