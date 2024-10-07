using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OutputTextFlash : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public Color colorA, colorB; 
    public float duration = 1f; 
    public int repeatCount = 3; 

    private bool isChanging = false;

    private void Start()
    {
        if (text == null) { text = GetComponentInChildren<TextMeshProUGUI>(); }
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
            yield return StartCoroutine(ChangeIntensityOverTime(colorA, colorB));
            yield return StartCoroutine(ChangeIntensityOverTime(colorB, colorA));
        }
        isChanging = false;
    }

    private IEnumerator ChangeIntensityOverTime(Color startColor, Color endColor)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            text.color = Color.Lerp(startColor, endColor, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        text.color = endColor;
    }
}
