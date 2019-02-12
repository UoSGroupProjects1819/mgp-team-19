using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Damage : MonoBehaviour
{
    public int health = 4;
    public GameObject BoomBoxPrefab;

    private void Update()
    {
        if(health <= 0)
        {
            Instantiate(BoomBoxPrefab);
            GetComponent<BoxCollider>().enabled = false;
            this.gameObject.SetActive(false);
        }
    }

}
