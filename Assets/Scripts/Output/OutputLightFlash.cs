using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputLightFlash : MonoBehaviour
{
    public Light targetLight; 
    public float intensityA = 1f; 
    public float intensityB = 5f; 
    public float duration = 1f; 
    public int repeatCount = 3; 

    private bool isChanging = false;

    private void Start()
    {
        if (targetLight == null) { targetLight = GetComponentInChildren<Light>(); }
    }

    public void StartChangingIntensity()
    {
        if (!isChanging)
        {
            StartCoroutine(ChangeLightIntensity());
        }
    }

    private IEnumerator ChangeLightIntensity()
    {
        isChanging = true;
        for (int i = 0; i < repeatCount; i++)
        {
            yield return StartCoroutine(ChangeIntensityOverTime(intensityA, intensityB));
            yield return StartCoroutine(ChangeIntensityOverTime(intensityB, intensityA));
        }
        isChanging = false;
    }

    private IEnumerator ChangeIntensityOverTime(float startIntensity, float endIntensity)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            targetLight.intensity = Mathf.Lerp(startIntensity, endIntensity, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        targetLight.intensity = endIntensity;
    }
}
