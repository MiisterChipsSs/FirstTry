using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShoot : MonoBehaviour
{
    public AudioClip SoundShoot;
    public GameObject prefabProjectil;
    private GameObject projectil;
    public float shootRate = 2f;
    public float destroy = 2f;
    private float nextShoot;
    public int speed = 1000;


    void Update() {

        if(Time.time > nextShoot)
        {
            nextShoot = Time.time + shootRate;
            projectil = Instantiate(prefabProjectil, transform.position, Quaternion.identity) ;
            GetComponent<AudioSource>().PlayOneShot(SoundShoot);
            projectil.GetComponent<Rigidbody>().AddForce(transform.TransformDirection (Vector3.forward) * speed);
            Destroy(projectil, destroy);
        }

        
    }
}
