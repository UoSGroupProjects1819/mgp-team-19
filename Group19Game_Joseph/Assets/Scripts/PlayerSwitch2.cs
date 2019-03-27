using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch2 : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject SecondCamera;


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("player", 0);
            PlayerCamera.SetActive(false);
            SecondCamera.SetActive(true);

        }
    }
   





    // Update is called once per frame
    void Update()
    {

    }
}
