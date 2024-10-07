using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSetBallPosition : MonoBehaviour
{
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;  
    }

    public void SetBallPos(Vector3 pos)
    {
        transform.position = pos;
    }

    public void ResetBallPos()
    {
        transform.position = startPos;
    }
}
