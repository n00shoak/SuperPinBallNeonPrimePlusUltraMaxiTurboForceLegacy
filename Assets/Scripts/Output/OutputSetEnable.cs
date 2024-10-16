using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSetEnable : MonoBehaviour
{
    [SerializeField] private GameObject target;

    public void SetEnable(bool state)
    {
        target.SetActive(state);
    }
}
