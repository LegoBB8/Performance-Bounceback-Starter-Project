using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTrampoline : MonoBehaviour
{

    public ParticleSystem pSystem;
    public GameManager scoreScript;

    // Use this for initialization
    void Start()
    {
        pSystem = GetComponentInChildren<ParticleSystem>();
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            scoreScript.score = scoreScript.score + 2;
            //Particle effect
            pSystem.Play();


        }

    }
}
