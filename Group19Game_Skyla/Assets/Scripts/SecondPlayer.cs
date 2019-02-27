using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{

    public float speed = 12f;
    public int player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if global value is this, movement can be achieved
        if (PlayerPrefs.GetInt("player") == player)
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
}
