using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public Camera Cam;
    public ParticleSystem muzzleFlash;
    public AudioSource shootSound;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        shootSound.Play();
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position,Cam.transform.forward,out hit))
        {
            Debug.Log(hit.transform.name);

            EnemyDamage enemy = hit.transform.GetComponent<EnemyDamage>();
            if (enemy != null)
            {
                enemy.Die();
            }
        }
    }
}