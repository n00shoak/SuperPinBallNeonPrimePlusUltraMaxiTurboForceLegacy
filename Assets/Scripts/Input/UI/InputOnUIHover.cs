using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class InputOnUIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Déclare deux événements Unity qui seront invoqués lors du survol et de la sortie
    public UnityEvent onHoverEnter;
    public UnityEvent onHoverExit;

    // Méthode appelée lorsque la souris commence à survoler l'élément
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (onHoverEnter != null)
        {
            onHoverEnter.Invoke();
        }
    }

    // Méthode appelée lorsque la souris quitte l'élément
    public void OnPointerExit(PointerEventData eventData)
    {
        if (onHoverExit != null)
        {
            onHoverExit.Invoke();
        }
    }
}
