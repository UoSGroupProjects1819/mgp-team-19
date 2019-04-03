using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Tooltip("Character Animation Handling")]
    public bool playerNum;
    public Transform cosmeticObj;
    public Animator anim;
    [Tooltip("Character speed as a float")]
    public float speed = 12f;
    public int player;
    public float closeDistance = 5.0f;
    public Transform pickupHolder;
    private bool iscarrying;
    private GameObject itemCarried;
    private void Start()
    {
        GameObject SpawnHalt = GameObject.Find("PlayerSetup");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (playerNum == false)
            {
                anim.SetBool("isWalking", true);
            }
            else
            {
                anim.SetBool("isRunning", true);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed / 2);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
            this.gameObject.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 200);
            anim.SetBool("isWalking", true);
            //anim.SetBool("isRunning", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime);
            this.gameObject.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 200);
            anim.SetBool("isWalking", true);
            //anim.SetBool("isRunning", true);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isWalking", false);
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
                else if (objectHit.gameObject.tag == "Pickup_Obj" && iscarrying == false && playerNum == false)
                {
                    Vector3 offset = objectHit.transform.position - this.transform.position;
                    float sqrMag = offset.sqrMagnitude;

                    Debug.Log("sqr mag is " + sqrMag);
                    if (sqrMag < closeDistance * closeDistance)
                    {
                        objectHit.SetParent(pickupHolder);
                        objectHit.SetPositionAndRotation(pickupHolder.position, Quaternion.Euler(0, 0, 0));
                        itemCarried = objectHit.gameObject;
                        iscarrying = true;
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(1) && iscarrying == true)
        {
            DropObject();
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "MovingPlatform" || collision.gameObject.tag == "Platform")
        {
            this.gameObject.transform.SetParent(collision.gameObject.transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.transform.SetParent(null);
    }
    private void DropObject()
    {
        if (iscarrying == true)
        {
            itemCarried.transform.parent = null;
            itemCarried = null;
            iscarrying = false;
        }
    }
}
