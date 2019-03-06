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
        
        if (other.gameObject.tag == "Player")
        {
            anim1.GetComponent<Animator>().enabled = false;
            anim2.GetComponent<Animator>().enabled = false;
            collision.SetActive(false);

        }
        if (other.gameObject.tag == "SecondPlayer")
        {
            endPlate.SetActive(false);
            cam.GetComponent<Camera>().transform.position = Vector3.Lerp(endMarker.position, endMarker.position , Time.deltaTime);
            this.gameObject.SetActive(false);
            GameObject.Find("GameManager").GetComponent<GameManager>().SwitchPlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
