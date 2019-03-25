using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brokenBoxExplode : MonoBehaviour
{
    private Rigidbody rb;
    public float explosion_force = 12;

    public void Start()
    {
        Vector3 explosionPos = transform.position;
        rb = GetComponent<Rigidbody>();

        rb.AddExplosionForce(explosion_force, explosionPos, 20, 30, ForceMode.Impulse);
    }
}
