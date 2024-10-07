using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(OutputShowScore))]
public class OutputSetBonus : MonoBehaviour
{
    private OutputShowScore _showScore;

    private void Start()
    {
        _showScore = GetComponent<OutputShowScore>();
    }
}
