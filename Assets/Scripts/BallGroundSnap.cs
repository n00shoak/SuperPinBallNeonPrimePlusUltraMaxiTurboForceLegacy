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

    private void LateUpdate()
    {
        if (!Physics.Raycast(transform.position , Vector3.down,groundDist))
        {
            Debug.LogWarning("CACA");
            rb.velocity = rb.velocity + Vector3.down * correction;
        }

        if (rb.velocity.y > 5) 
        {
            Debug.Log("Denied");
            rb.velocity = rb.velocity + Vector3.down;
        }

        Debug.DrawLine(transform.position, transform.position + Vector3.down * groundDist,Color.red);
    }
}
