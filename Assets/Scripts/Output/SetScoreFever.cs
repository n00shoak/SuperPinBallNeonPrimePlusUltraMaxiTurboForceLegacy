using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScoreFever : MonoBehaviour
{
    [SerializeField] private Image bar;

    public float SmoothFactor;
    public float fever = 0;
    public float Consumption;

    public float targetFever;

    private void Start()
    {
        targetFever = fever;
        StartCoroutine(FeverConsumption());
    }

    private void Update()
    {
        fever = Mathf.Lerp(targetFever, fever, SmoothFactor * Time.deltaTime);
        bar.fillAmount = fever;
    }

    private IEnumerator FeverConsumption()
    {
        if(targetFever > 0)
        {
            targetFever -= Consumption/100;
        }
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(FeverConsumption());
    }
}
