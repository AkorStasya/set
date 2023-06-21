using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class monster : MonoBehaviour
{
    GameObject player;
    NavMeshAgent navMesh;

    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.SetDestination(player.transform.position);
        
    }
    
}
