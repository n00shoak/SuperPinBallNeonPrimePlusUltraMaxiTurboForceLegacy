using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPlayParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] effect;
    public void PlayParticleEffect()
    {
        for(int i = 0; i < effect.Length; i++)
        {
            effect[i].Play();
        }
    }
}
