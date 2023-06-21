using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finic : MonoBehaviour
{
    public Image xpImag;
    public float maxLife = 100;
    float curLife;
    float cvr = 10;
    public Image Losis;
    // Start is called before the first frame update
    void Start()
    {
        Losis.enabled = false;
        curLife = maxLife;
        
    }
    public void Energy()
    {
        curLife = curLife-cvr;
    }
    public void Boom(){
        curLife = curLife-30;
    }
    public void ill(){
        curLife = maxLife;
    }

    void Update()
    {
        if (curLife <= 0)
        {
            Losis.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
            {
                if (curLife<maxLife)
                {
                    curLife += 1;
                }
                if (curLife > 0)
            {
                Debug.Log("Текущий xp: " + curLife);
            }
            }
            
        xpImag.transform.localScale = new Vector3(curLife / maxLife, 
        xpImag.transform.localScale.y, 
        xpImag.transform.localScale.z);
    }
    // Update is called once per frame
    
}
