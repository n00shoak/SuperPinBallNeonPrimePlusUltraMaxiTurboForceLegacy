using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputKeyboard : MonoBehaviour
{
    [SerializeField] private InputType typeOfInput;
    [SerializeField] private KeyCode trigger;
    [SerializeField] private UnityEvent totrigger;

    private void Update()
    {
        switch(typeOfInput)
        {
            case InputType.pressed:
                if (Input.GetKeyDown(trigger)) { totrigger.Invoke(); }
                break;

            case InputType.realeased:
                if (Input.GetKeyUp(trigger)) { totrigger.Invoke(); }
                break;
            
            case InputType.held:
                if (Input.GetKey(trigger)) { totrigger.Invoke(); }
                break;

            default:
                Debug.LogError("KEYINPUT >> no input type selected ");
                break;
        }
    }

    private enum InputType
    {
        pressed,
        realeased,
        held
    }
}
