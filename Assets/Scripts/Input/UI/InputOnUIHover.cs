using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class InputOnUIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // D�clare deux �v�nements Unity qui seront invoqu�s lors du survol et de la sortie
    public UnityEvent onHoverEnter;
    public UnityEvent onHoverExit;

    // M�thode appel�e lorsque la souris commence � survoler l'�l�ment
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (onHoverEnter != null)
        {
            onHoverEnter.Invoke();
        }
    }

    // M�thode appel�e lorsque la souris quitte l'�l�ment
    public void OnPointerExit(PointerEventData eventData)
    {
        if (onHoverExit != null)
        {
            onHoverExit.Invoke();
        }
    }
}
