using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformTombe : MonoBehaviour
{
    public float SecToFall = 1;
    private Rigidbody rb;
    private Material plateformColor;
    private Vector3 PositionDepart;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        PositionDepart = transform.position;
        plateformColor = GetComponent<Renderer>().material;

    }

    void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.tag == "Player")
        {
            plateformColor.color = Color.red;
            StartCoroutine(FallDown());

        }
        if (Other.gameObject.tag == "ZoneSpawn")
        {
            plateformColor.color = Color.white;
            rb.isKinematic = true;
            transform.position = PositionDepart;
        }
        
    }
    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(SecToFall);
        rb.isKinematic = false;
    }
}
