using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSetLight : MonoBehaviour
{
    [SerializeField] private Light targetedLight;
    [SerializeField] private float intensity;
    [SerializeField] private Color color;

    private void Start()
    {
        if (targetedLight == null) { targetedLight = GetComponentInChildren<Light>(); }
        if (color == null) { color = GetComponentInChildren<Light>().color; }
    }

    public void SetLight()
    {
        targetedLight.intensity = intensity;
        targetedLight.color = color;   
    }
}
