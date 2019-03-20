using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject SecondCamera;

    void OnMouseOver()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("player", 1);
            PlayerCamera.SetActive(false);
            SecondCamera.SetActive(true);

        }
        

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
