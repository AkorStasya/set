using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gung : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public float imactForce = 100f;
    public TextMeshProUGUI txt;

    public float fireRate = 0.2f;
    public float countdown = 0f;

    public ParticleSystem shootEffect;

    public int maxAmmo = 10;
    int curAmmo;
    public float reloadTime = 1f;
    bool isReloading = false;

    void Start()
    {
        curAmmo = maxAmmo;
    }
    void OnEnadle(){
        isReloading = false;
    }
    void Update()
    {
        if(isReloading){
            return;
        }
        if(curAmmo<=0){
            StartCoroutine(Reload());
            return;
        }
        IEnumerator Reload(){
            isReloading = true;
            Debug.Log("Reloading...");
            yield return new WaitForSeconds(reloadTime);
            curAmmo = maxAmmo;
            isReloading = false;
            txt.text= "Осталось "+curAmmo+"";
        }
        if(Input.GetButtonDown("Fire1") && countdown<=0){
            Shoot();
            countdown = fireRate;
        }
        if(countdown>0){
            countdown -= Time.deltaTime;
        }
    }
    void Shoot (){
        curAmmo--;
        txt.text= "Осталось "+curAmmo+"";
        shootEffect.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, 
        fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.collider.name);
        }
        Target target = hit.collider.GetComponent<Target>();
        if(target != null){
            target.TakeDamage(damage);
        }
        if(hit.rigidbody != null){
            hit.rigidbody.AddForce(-hit.normal * imactForce);
        }
    }
}
