﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followhero: MonoBehaviour{


    public GameObject hero;

    private Vector3 currVelocity;
    public float smooth;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newCameraPositrion = new Vector3(hero.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, newCameraPositrion,ref currVelocity, smooth);
        
    }
}
