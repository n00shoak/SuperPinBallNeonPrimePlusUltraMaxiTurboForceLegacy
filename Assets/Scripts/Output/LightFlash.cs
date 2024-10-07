using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlash : MonoBehaviour
{
    public Light targetLight; // La lumière à modifier
    public float intensityA = 1f; // Valeur A
    public float intensityB = 5f; // Valeur B
    public float duration = 1f; // Durée de chaque changement
    public int repeatCount = 3; // Nombre de répétitions (X)

    private bool isChanging = false;

    private void Start()
    {
        if (targetLight == null) { targetLight = GetComponentInChildren<Light>(); }
    }

    // Fonction pour démarrer le changement
    public void StartChangingIntensity()
    {
        if (!isChanging)
        {
            StartCoroutine(ChangeLightIntensity());
        }
    }

    // Coroutine pour changer l'intensité de la lumière
    private IEnumerator ChangeLightIntensity()
    {
        isChanging = true;
        for (int i = 0; i < repeatCount; i++)
        {
            // Change de A à B
            yield return StartCoroutine(ChangeIntensityOverTime(intensityA, intensityB));
            // Change de B à A
            yield return StartCoroutine(ChangeIntensityOverTime(intensityB, intensityA));
        }
        isChanging = false;
    }

    // Coroutine pour ajuster l'intensité sur le temps
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
