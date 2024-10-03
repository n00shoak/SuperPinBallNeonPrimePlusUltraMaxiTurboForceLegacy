using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class showScore : MonoBehaviour
{
    [SerializeField] private int targetscore;
    [SerializeField] private TextMeshProUGUI text;
    private int currentscore;

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            targetscore = 0;
        }


        if(currentscore != targetscore)
        {
            currentscore += Mathf.RoundToInt((targetscore - currentscore) / 100) + 1;
            text.text = currentscore.ToString();
        }
    }

    public void addScore(int value)
    {
        targetscore += value;
    }
}
