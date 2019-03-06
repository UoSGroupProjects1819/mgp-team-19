using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDown : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (ElevatorUp.DoorMoveVert >= 0)
            {
                lift.transform.Translate(Vector3.down * (Time.deltaTime * liftSpeed));
                ElevatorUp.DoorMoveVert -= 1;
            }
        }
    }
}
