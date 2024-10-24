using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSetCursor : MonoBehaviour
{
    public void SetCursorVisibilyty(bool state)
    {
        Cursor.visible = state;
    }

    public void SetCursorLock(bool state)
    {
        if (state) { Cursor.lockState = CursorLockMode.Locked; }
        else { Cursor.lockState = CursorLockMode.None;}
    }
}
