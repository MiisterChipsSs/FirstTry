using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitproj : MonoBehaviour
{
    public AudioClip SoundDead;
    private Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;
        
    }

    void OnTriggerEnter (Collider other){

        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(SoundDead);
            Debug.Log("HitPlayer");
            other.transform.position = spawnPoint;
        }
        
    }
}
