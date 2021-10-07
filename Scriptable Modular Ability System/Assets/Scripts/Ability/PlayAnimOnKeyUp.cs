using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimOnKeyUp : MonoBehaviour
{
    public GameObject mainProjectile;
    public ParticleSystem mainParticleSystem;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            mainProjectile.SetActive(true);
        }

        if (mainParticleSystem.IsAlive() == false)
        {
            mainProjectile.SetActive(false);
        }
    }
}
