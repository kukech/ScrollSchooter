﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTransform : MonoBehaviour
{
    private float speedRotation = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speedRotation, 0));
    }
}
