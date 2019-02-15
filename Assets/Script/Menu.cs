using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public AudioClip POUM;
    public AudioClip Pascal;

    public void Quitter()
    {
        Application.Quit() ;
    }

    public void Change()
    {
        SceneManager.LoadScene(1);
        GetComponent<AudioSource>().PlayOneShot(Pascal);
    }

    public void Poum()
    {
        GetComponent<AudioSource>().PlayOneShot(POUM);
    }

}
