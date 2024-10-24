using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputQuitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Bye bye");
        Application.Quit();
    }
}
