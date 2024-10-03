using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPrint : MonoBehaviour
{
    public void NormalDebug()
    {
        Debug.Log("TEST");
    }

    public void WarningDebug()
    {
        Debug.LogWarning("TEST");
    }

    public void ErrorDebug()
    {
        Debug.LogError("TEST");
    }
}
