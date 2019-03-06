using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUp : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;
    public static int DoorMoveVert = 0;
    public float maxDoorMoveVert = 100f;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (DoorMoveVert <= (maxDoorMoveVert))
            {
                lift.transform.Translate(Vector3.up * (Time.deltaTime * liftSpeed));
                DoorMoveVert += 1;
            }
        }
    }
}
