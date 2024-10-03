using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class InputColision : MonoBehaviour
{
    [SerializeField] private UnityEvent<object> totrigger;

    private void OnCollisionEnter(Collision collision)
    {
        totrigger.Invoke(collision);
    }

}
