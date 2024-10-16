using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OutputMoveSliderTo : MonoBehaviour
{
    [SerializeField] private Image sliderFill;
    [SerializeField] private float speed, fluidity;

    public void SlideTo(int Ammount)
    {
        StopAllCoroutines();
        StartCoroutine(FillBar(Ammount));
    }

    private IEnumerator FillBar(int Ammount)
    {
        while (Mathf.Abs(sliderFill.fillAmount - Ammount) > 0.01f)
        {
            sliderFill.fillAmount = Mathf.Lerp(sliderFill.fillAmount, Ammount, speed * Time.deltaTime);
            yield return new WaitForSeconds(fluidity);
        }

        sliderFill.fillAmount = Ammount;  // Assure que la valeur finale est atteinte
    }
}
