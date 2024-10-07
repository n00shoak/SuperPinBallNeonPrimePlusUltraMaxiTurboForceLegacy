using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform ballPos;
    public float maxPos, minPos;

    void Update()
    {

        transform.position = new Vector3 (transform.position.x,transform.position.y, Mathf.Clamp(ballPos.position.z,minPos,maxPos));  
    }
}
