﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public int speed = 1;


    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);    
    }
}
