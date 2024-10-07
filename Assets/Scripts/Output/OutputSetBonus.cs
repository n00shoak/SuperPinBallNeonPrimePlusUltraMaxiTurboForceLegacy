using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(showScore))]
public class OutputSetBonus : MonoBehaviour
{
    private showScore _showScore;

    private void Start()
    {
        _showScore = GetComponent<showScore>();
    }
}
