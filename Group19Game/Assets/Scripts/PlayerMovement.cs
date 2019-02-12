using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Character speed as a float")]
    public float speed = 12f;

    private bool NSpawned = false;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        GameObject SpawnHalt = GameObject.Find("PlayerSetup");

        SpawnHalt.GetComponent<PlayerInstantiate>().willSpawnPlayer = false;
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
    }
}
