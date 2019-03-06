using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorRight : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;
    public float maxDoorMoveHoriz = 100f;
    public static int DoorMoveHoriz = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (DoorMoveHoriz <= maxDoorMoveHoriz)
            {
                lift.transform.Translate(Vector3.right * (Time.deltaTime * liftSpeed));
                DoorMoveHoriz += 1;
            }
        }
    }
}
