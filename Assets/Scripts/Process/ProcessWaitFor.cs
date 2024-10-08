using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProcessWaitFor : MonoBehaviour
{
    [SerializeField] private UnityEvent toDo;

    public void waitFor(float duration)
    {
        StartCoroutine(waiting(duration));
    }

    private IEnumerator waiting(float duration)
    {
        yield return new WaitForSeconds(duration);
        toDo.Invoke();
    }
}
