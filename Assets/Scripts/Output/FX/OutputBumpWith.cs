using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputBumpWith : MonoBehaviour
{
    [SerializeField] private float force;
    public void Bump(GameObject collision)
    {
        Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();

        if (ballRb != null)
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            direction.y = 0;

            ballRb.velocity = Vector3.zero;
            ballRb.AddForce(direction * force, ForceMode.Impulse);
            Debug.Log("bUMPED" );
        }
    }
}
