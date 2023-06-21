using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xprl : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            other.GetComponentInChildren<Finic>().Energy();
        }
    }
}
