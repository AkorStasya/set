using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apcert : MonoBehaviour
{
    public LayerMask interactLayer;
    public float interactDistance;
    public Image interactIcon;
    GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        interactIcon.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, interactDistance, interactLayer)){
            interactIcon.enabled = true;
            if(Input.GetKeyDown(KeyCode.V)){
                 Destroy(GameObject.FindGameObjectWithTag("acp1"));
                    player.GetComponentInChildren<Finic>().ill();
            }
        }
        else{
            interactIcon.enabled = false;
            
        }
    }
}
