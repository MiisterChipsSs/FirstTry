using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class finishlvl1 : MonoBehaviour
{
    public AudioClip finish;


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(finish);
            Debug.Log("Finish level1");
            SceneManager.LoadScene(2);
        }

    }
}
