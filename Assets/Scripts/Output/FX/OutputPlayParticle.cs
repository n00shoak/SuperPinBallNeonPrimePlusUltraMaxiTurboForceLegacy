using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class OutputPlayParticle : MonoBehaviour
{
    [SerializeField] private VisualEffect effect;
    public void PlayParticleEffect()
    {
        effect.Play();
    }
}
