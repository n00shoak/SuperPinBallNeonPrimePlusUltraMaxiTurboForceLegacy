using System.Collections;
using UnityEngine;

public class OutputSetSize : MonoBehaviour
{
    [SerializeField] private Transform target;  // L'objet dont on veut modifier la taille
    [SerializeField] private float speed, fluidity;

    public void ResizeTo(float Ammount)
    {
        target.localScale = Vector3.one * Ammount;
    }
}
