using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class OutputShowScore : MonoBehaviour
{
    [SerializeField] private int targetscore;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private UnityEvent scoreChange,bonusChange,onReset;
    private int currentscore = 0;
    public float bonus = 1;

    public void AddBonus(int value)
    {
        bonus += value;
        bonusChange.Invoke();  
    }

    public void SetBonus(int value)
    {
        bonus = value; 
    }

    public void AddScore(int Value)
    {
        targetscore += Mathf.RoundToInt(Value * bonus);
        scoreChange.Invoke();
    }

    public void SetScore(int Value)
    {
        targetscore = Value;
    }

    public void resetScore()
    {
        targetscore = 0;
        currentscore = 0;
        text.text = currentscore.ToString();
        onReset.Invoke();
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            targetscore = 0;
        }


        if(currentscore != targetscore)
        {
            currentscore += Mathf.RoundToInt((targetscore - currentscore) / 50) + 1;
            text.text = currentscore.ToString();
        }
    }
}
