﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitlerPlane : MonoBehaviour
{
    public int Speed;
    public int Upp; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody lol = GetComponent<Rigidbody>();
        lol.AddRelativeForce(new Vector3(0, Upp, Speed));
    }
}
