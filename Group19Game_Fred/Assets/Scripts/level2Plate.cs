using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Plate : MonoBehaviour
{
    public Camera cam;
    public Transform endMarker;
    public Animator anim1;
    public Animator anim2;
    public GameObject endPlate;
    public GameObject collision;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        //upon collision with first player(red) disables the animation for player 2 to pass and disables collision so they cannot restart.
        
        if (other.gameObject.tag == "Player")
        {
            anim1.GetComponent<Animator>().enabled = false;
            anim2.GetComponent<Animator>().enabled = false;
            collision.SetActive(false);

        }

        //upon collision with second player(black sets green plate to false, moves camera for progression and switches to other character.
        if (other.gameObject.tag == "SecondPlayer")
        {
            endPlate.SetActive(false);
            cam.GetComponent<Camera>().transform.position = Vector3.Lerp(endMarker.position, endMarker.position , Time.deltaTime);
            GameObject.Find("GameManager").GetComponent<GameManager>().SwitchPlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
