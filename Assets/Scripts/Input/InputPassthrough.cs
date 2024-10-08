using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPassThrough : MonoBehaviour
{
    [SerializeField] private UnityEvent toDo;

    private void OnTriggerEnter(Collider other)
    {
        toDo.Invoke();
    }
}
