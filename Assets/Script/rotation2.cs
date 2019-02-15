using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation2 : MonoBehaviour
{
    public int speed = 1;


    void Update()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
