using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSetRotation : MonoBehaviour
{
    [SerializeField] private Transform target;

    public void SetTargetRotation(float posZ)
    {
        target.eulerAngles = new Vector3(0, 0, posZ);
    }
}
