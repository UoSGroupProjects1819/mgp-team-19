using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Character speed as a float")]
    public float speed = 12f;
    public int player; 

    private bool NSpawned = false;
    private void Start()
    {
        GameObject SpawnHalt = GameObject.Find("PlayerSetup");
        
    }
    void Update()
    {
        // if statements to determine movement based on keys, multiplied by the float val above
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }


        //Mouse input for interaction
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log("Hit " + objectHit);

                if (objectHit.gameObject.tag == "BoomCube")
                {
                    objectHit.GetComponent<Box_Damage>().health--;
                }
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "MovingPlatform" || collision.gameObject.tag == "Platform")
        {
            this.gameObject.transform.SetParent(collision.gameObject.transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.transform.SetParent(null);
        
    }
}
