using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputAddScore : MonoBehaviour
{
    [SerializeField] private showScore score;
    [SerializeField] private int bonusAmount; 
    public void AddScore()
    {
        score.addScore(bonusAmount);
    }
}
