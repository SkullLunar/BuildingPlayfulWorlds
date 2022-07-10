using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField] ParticleSystem fireParticle1 = null;
    [SerializeField] ParticleSystem fireParticle2 = null;
    [SerializeField] ParticleSystem fireParticle3 = null;
    [SerializeField] ParticleSystem fireParticle4 = null;
    [SerializeField] ParticleSystem fireParticle5 = null;
    [SerializeField] ParticleSystem fireParticle6 = null;
    [SerializeField] ParticleSystem fireParticle7 = null;
    [SerializeField] ParticleSystem fireParticle8 = null;
    void OnTriggerEnter(Collider col)
{
    Debug.Log("COLLIDED");
      fireParticle1.Play();
      fireParticle2.Play();
      fireParticle3.Play();
      fireParticle4.Play();
      fireParticle5.Play();
      fireParticle6.Play();
      fireParticle7.Play();
      fireParticle8.Play();
}
}
