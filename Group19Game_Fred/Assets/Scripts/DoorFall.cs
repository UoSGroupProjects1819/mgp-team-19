using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFall : MonoBehaviour
{
    public GameObject door;
    public GameObject seperationDoor;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public int doorSpeed = 40;
    public GameObject collider;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "SecondPlayer")
        {
            door.transform.Translate(Vector3.down * doorSpeed);
            seperationDoor.SetActive(true);
            wall1.SetActive(false);
            wall2.SetActive(false);
            wall3.SetActive(false);
            wall4.SetActive(false);
            collider.SetActive(false);
        }
    }
}
