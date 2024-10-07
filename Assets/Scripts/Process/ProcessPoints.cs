using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProcessPoints : MonoBehaviour
{
    public bool[] Points;
    public UnityEvent toDo;

    public void AddPoint(int id)
    {
        if(Points[id] == false) {  Points[id] = true; }

        int index = 0;
        for (int i = 0; i < Points.Length; i++) 
        {
            if(Points[i] == true) {  index++; }
        }

        if(index == Points.Length)
        {
            toDo.Invoke();
            Points = new bool[Points.Length] ;
        }
    }
}
