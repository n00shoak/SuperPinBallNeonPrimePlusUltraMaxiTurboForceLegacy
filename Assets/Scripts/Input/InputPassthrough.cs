using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPassthrough : MonoBehaviour
{
    [SerializeField] private UnityEvent<object> totrigger;

    private void OnTriggerEnter(Collider other)
    {
        totrigger.Invoke(other);
    }
}
