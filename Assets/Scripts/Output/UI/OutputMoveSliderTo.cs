using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputMoveSliderTo : MonoBehaviour
{
    [SerializeField] private Image sliderFill;
    [SerializeField] private float speed,fluidity;

    public void SlideTo(int Ammount)
    {
        StartCoroutine(FillBar(Ammount));
    }

    private IEnumerator FillBar(int Ammount = 1)
    {
        sliderFill.fillAmount +=0.0001f;
        Debug.Log("CAAAl");
        yield return new WaitForSeconds(fluidity);

        if(sliderFill.fillAmount < Ammount + 0.005f || sliderFill.fillAmount > Ammount - 0.005f)
        {
            //sliderFill.fillAmount = Ammount;
        }
        else
        {
            StartCoroutine(FillBar(Ammount));
        }
    }
}
