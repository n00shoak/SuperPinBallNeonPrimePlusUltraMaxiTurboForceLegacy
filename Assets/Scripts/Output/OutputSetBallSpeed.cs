using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OutputSetBallSpeed : MonoBehaviour
{
    public Rigidbody ballRB;

    private void Start()
    {
        if(ballRB != null)
        {
            ballRB = GameObject.Find("BALL").GetComponent<Rigidbody>();
        }
    }
    public void SetSpeed(float speed)
    {
        ballRB.velocity = Vector3.ProjectOnPlane(new Vector3 (0, 0, speed),transform.position);
    }

    public void AddSpeed(float speed)
    {
        ballRB.velocity += new Vector3(ballRB.velocity.x, -0.5f, ballRB.velocity.z).normalized * speed;
    }
}
