using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorLeft : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;
    public float maxDoorMoveHoriz = 100f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (ElevatorRight.DoorMoveHoriz >= -maxDoorMoveHoriz)
            {
                lift.transform.Translate(Vector3.left * (Time.deltaTime * liftSpeed));
                ElevatorRight.DoorMoveHoriz -= 1;
            }
        }
    }
}
