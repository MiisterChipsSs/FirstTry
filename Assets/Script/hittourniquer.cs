using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittourniquer : MonoBehaviour
{
    public AudioClip SoudDead;
    private Vector3 spawnpoint;

    private void Start()
    {
        spawnpoint = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(SoudDead);
            other.gameObject.transform.position = spawnpoint;
        }
    }

}
