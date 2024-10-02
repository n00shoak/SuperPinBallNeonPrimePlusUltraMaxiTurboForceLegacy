using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Bumper : MonoBehaviour
{
    public float bumpPower;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OUI");
        Rigidbody rb = collision.rigidbody;
        if(rb != null)
        {
            rb.velocity = Vector3.Distance(transform.position,collision.transform.position) *Vector3.one * bumpPower;
        }
    }
}
