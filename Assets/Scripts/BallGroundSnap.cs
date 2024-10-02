using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGroundSnap : MonoBehaviour
{
    public float groundDist;
    public float correction;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!Physics.Raycast(transform.position , Vector3.down,groundDist))
        {
            Debug.LogWarning("CACA");
            rb.velocity = rb.velocity + Vector3.down * correction;
        }

        if (rb.velocity.y > 2) 
        {
            rb.velocity = rb.velocity + Vector3.down;
        }

        Debug.DrawLine(transform.position, transform.position + Vector3.down * groundDist,Color.red);
    }
}
