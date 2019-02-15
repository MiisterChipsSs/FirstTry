using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class finishlevel2 : MonoBehaviour
{
    public AudioClip finish;


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(finish);
            Debug.Log("Finish level1");
            SceneManager.LoadScene(3);
        }

    }
}