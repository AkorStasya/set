using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public int selectedWeapon = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SwitchWeapon();
    }

    void SwitchWeapon()
    {
        for (int i = 0 ; i < transform.childCount ; i++)
        {
            if (i == selectedWeapon)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int prevWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (selectedWeapon >= transform.childCount - 1)
            {
                selectedWeapon = 0;
            }
            else {
                selectedWeapon++;
            }
        }

         if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (selectedWeapon <= 0)
            {
                selectedWeapon = transform.childCount - 1;
            }
            else {
                selectedWeapon--;
            }
        }

        if (prevWeapon != selectedWeapon) 
        {
            SwitchWeapon();
        }
    }
}
