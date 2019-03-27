using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePressure : MonoBehaviour
{
    public GameObject door;
    public GameObject pressurePlate1;
    public GameObject pressurePlate2;
    public string player;
    public string player2;
    public float doorSpeed = 5;
    public float DoorMovement = 0;
    public float maxDoorMovement = 0;
    public GameObject collider;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == player || other.gameObject.tag == player2)
        {


            if (pressurePlate1.GetComponent<PlayerDetection>().player_hit_me == true && pressurePlate2.GetComponent<PlayerDetection>().player_hit_me == true)
            {
                if (DoorMovement <= (maxDoorMovement))
                {
                    door.transform.Translate(Vector3.up * (Time.deltaTime * doorSpeed));
                    DoorMovement += 1;
                    collider.SetActive(true);
                }
            }
        }
    }
}
