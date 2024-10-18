using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGroundSnap : MonoBehaviour
{
    public float groundDist;
    public float correction;
    public LayerMask LayerMask;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        if (!Physics.Raycast(transform.position , Vector3.down,groundDist, LayerMask))
        {
            transform.position += Vector3.down * correction;
        }
        Debug.DrawLine(transform.position, transform.position + Vector3.down * groundDist,Color.red);
    }
}
