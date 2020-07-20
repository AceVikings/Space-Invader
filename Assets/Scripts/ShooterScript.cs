using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public Camera Cam;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position,Cam.transform.forward,out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}