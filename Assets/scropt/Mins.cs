using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mins : MonoBehaviour
{
    public ParticleSystem boomef;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            boomef.Play();
            Destroy(gameObject);
            other.GetComponentInChildren<Finic>().Boom();
        }
    }
}
