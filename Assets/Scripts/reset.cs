using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class reset : MonoBehaviour
{
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = startPos;
        }
    }
}
